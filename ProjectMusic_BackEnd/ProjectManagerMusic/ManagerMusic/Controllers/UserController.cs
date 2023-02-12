using DataApplication.ApplicationAdmin.ApplicationRole.Role_app;
using DataApplication.ApplicationAdmin.ApplicationStaff.Staff_App;
using DataViewModel.ViewModelAdmin.User_Vm;
using ManagerMusic.Models.ConvertImgToBase64;
using ManagerMusic.Models.FileImage;
using ManagerMusic.Models.Paging.Page_Notification;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;
using DataViewModel.ViewModelAdmin.ConverFile_Vm;
using static DataUtilities.NameRoleSetting;
using DataViewModel.ViewModelAdmin.Plan_Vm;
using ManagerMusic.Models.Plans;
using DataApplication.ApplicationAdmin.ApplicationUsers.Users_App;
using ManagerMusic.Models.Paging.Page_User;
using ManagerMusic.Models.EmailFile;
using DataViewModel.ViewModelAdmin.Users_Vm;
using ManagerMusic.Models.Paging.Page_Rating;
using ManagerMusic.Models.Paging.Page_Comment;
using ManagerMusic.Models.DowloadMuisc;

namespace ManagerMusic.Controllers
{
    [Authorize]
    public class UserController : BaseController
    {
        private readonly Irole_App context;
        private readonly Istaff_app context_Staff;
        private readonly Istaff_app convertImage;
        private readonly Iusers_app context_User;
        public UserController(Iusers_app _context_User, Irole_App _context, Istaff_app _context_Staff, Istaff_app _convertImage)
        {
            context = _context;
            context_Staff = _context_Staff;
            convertImage = _convertImage;
            context_User = _context_User;
        }
        //get all staff
        [Authorize(Roles = RoleSetting.symbolRole_Admin)]
        [HttpGet]
        public IActionResult Page_Staff()
        {
            return View();
        }

        [Authorize(Roles = RoleSetting.symbolRole_Admin)]
        [HttpGet]
        public IActionResult JsonGetAllSatff(int PageIndex, int PageSize)
        {
            var result = context_Staff.GetAllStaff();
            if (result.Count() != 0)
            {
                foreach (var item in result)
                {
                    item.ImageStaff = ConvertImage.ConverByeToImage(Convert.ToBase64String(item.ImageStaff));
                }
                var ModalPaging = result.Skip((PageIndex - 1) * PageSize).Take(PageSize);
                var resultModal = new PagingStaff()
                {
                    L_Staff = ModalPaging,
                    TotalStaff = result.Count()
                };
                return new JsonResult(resultModal);
            }
            return new JsonResult(0);
        }

        //create staff
        [Authorize(Roles = RoleSetting.symbolRole_Admin)]
        [HttpGet]
        public IActionResult PageCreateSatff()
        {
            return View();
        }
        [Authorize(Roles = RoleSetting.symbolRole_Admin)]
        [HttpPost]
        public async Task<IActionResult> JsonCreateStaff(SaveFile T_request)
        {
            var Stream = HttpContext.Request.Cookies["Token"];
            CreateSatff_V request = JsonConvert.DeserializeObject<CreateSatff_V>(T_request.Satff);
            request.DateCreate = DateTime.UtcNow.AddHours(7);
            request.Date = DateTime.Now.Day;
            request.Month = DateTime.Now.Month;
            request.Year = DateTime.Now.Year;
            request.ImageAvata = T_request.file;
            request.TokenData = Stream;
            var result = await context_Staff.CreateStaff(request);
            return new JsonResult(result);
        }


        //get all role
        [Authorize(Roles = RoleSetting.symbolRole_Admin)]
        [HttpGet]
        public IActionResult JsonGetAllRole()
        {
            var result = context.GetAllRole();
            if (result.Count() == 0)
            {
                return new JsonResult(0);
            }
            else
            {
                return new JsonResult(result);
            }
        }

        //get all status account
        [Authorize(Roles = RoleSetting.symbolRole_Admin)]
        [HttpGet]
        public IActionResult JsonGetAllStatusAccount()
        {
            var result = context_Staff.GetAllStatusAccount();
            if (result.Count() == 0)
            {
                return new JsonResult(0);
            }
            else
            {
                return new JsonResult(result);
            }
        }

        //get all marriage
        [Authorize(Roles = RoleSetting.symbolRole_Admin)]
        [HttpGet]
        public IActionResult JsonGetAllMarriage()
        {
            var result = context_Staff.GetAllMarriage();
            if (result.Count() == 0)
            {
                return new JsonResult(0);
            }
            else
            {
                return new JsonResult(result);
            }
        }

        //get all gender
        [Authorize(Roles = RoleSetting.symbolRole_Admin)]
        [HttpGet]
        public IActionResult JsonGetAllGender()
        {
            var result = context_Staff.GetAllGender();
            if (result.Count() == 0)
            {
                return new JsonResult(0);
            }
            else
            {
                return new JsonResult(result);
            }
        }

        //get lever by id role
        [Authorize(Roles = RoleSetting.symbolRole_Admin)]
        [HttpGet]
        public IActionResult JsonGetLeverByIdRole(Guid IdRole)
        {
            var result = context_Staff.GetLeverByIdRole(IdRole);
            if (result == null)
            {
                return new JsonResult(0);
            }
            else
            {
                return new JsonResult(result);
            }
        }

        //chat staff
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public async Task<IActionResult> IndexChatStaff()
        {
            var Stream = HttpContext.Request.Cookies["Token"];
            var hander = new JwtSecurityTokenHandler();
            var jsontoken = hander.ReadToken(Stream);
            var token = jsontoken as JwtSecurityToken;
            ViewBag.IdUser = Guid.Parse(token.Claims.FirstOrDefault(x => x.Type == "C_IdUser").Value);
            ViewBag.FullName = token.Claims.FirstOrDefault(x => x.Type == "C_FullName").Value;
            var result = await context_Staff.WasViewMessageByIdUser
                                    (Guid.Parse(token.Claims.FirstOrDefault(x => x.Type == "C_IdUser").Value));
            return View();
        }

        //loading staff
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public async Task<IActionResult> LoadingMessage(Guid IdUser, string FulterDate, int Index, int Size)
        {
            var result = await context_Staff.LoadingMessage();
            var TotalUser = context_Staff.GetAllStaff();
            result.IdUser = IdUser;
            result.TotalUser = TotalUser.Count();
            List<CreateChatStaff_V> L_ChatFulter = new List<CreateChatStaff_V>();
            if (FulterDate != null)
            {
                string[] StrDate = FulterDate.Split(" to ");
                DateTime DateTime_1 = Convert.ToDateTime(StrDate[0]);
                DateTime DateTime_2 = Convert.ToDateTime(StrDate[1]);
                L_ChatFulter = result.L_Chat.Where(x => x.DateCreate.Date >= DateTime_1 && x.DateCreate.Date <= DateTime_2).ToList();
                result.L_Chat = L_ChatFulter;
                result.Fuilter_Date = "FuilterDate";
            }
            else
            {
                if (Index == 1)
                {
                    L_ChatFulter = result.L_Chat.OrderByDescending(x => x.Id).Skip((Index - 1) * Size).Take(Size).ToList();
                    result.L_Chat = L_ChatFulter.OrderBy(x => x.Id).ToList();
                }
                else
                {
                    L_ChatFulter = result.L_Chat.OrderByDescending(x => x.Id).Skip((Index - 1) * Size).Take(Size).ToList();
                    result.L_Chat = L_ChatFulter;
                }
            }
            return new JsonResult(result);
        }

        //view info user chat
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public async Task<IActionResult> JsonInfoStaffChat(int IdChat, int PageIndex, int PageSize, int Sort)
        {
            var result = await context_Staff.InfoUserChat(IdChat, PageIndex, PageSize, Sort);
            return new JsonResult(result);
        }

        //sent images
        public static List<GetAllChatImages_V> L_ChatImages = new List<GetAllChatImages_V>();

        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpPost]
        public async Task<IActionResult> GetImageChat(SaveFileChat request)
        {
            if (request.L_File.Count() > 10)
            {
                return new JsonResult(0);
            }
            else
            {
                var ConverFile = new ConverFile();
                foreach (var item in request.L_File)
                {
                    string[] NameImageString = item.FileName.Split('.');
                    var result = new GetAllChatImages_V()
                    {
                        NameImage = item.FileName,
                        FileImage = item,
                        TypeImage = NameImageString[1],
                        DateCreate = DateTime.UtcNow.AddHours(7),
                    };
                    switch (result.TypeImage)
                    {
                        case "JPG":
                            var ImageConvert_JPG = await convertImage.ConverFormFileTobase64(result.FileImage);
                            var ImageConvert_JPG_Bye = await convertImage.ConverFromFileToByte(result.FileImage);
                            result.ImgBase64 = ImageConvert_JPG;
                            result.ContentImage_Doc = ImageConvert_JPG_Bye;
                            break;
                        case "jpg":
                            var ImageConvert_jpg = await convertImage.ConverFormFileTobase64(result.FileImage);
                            var ImageConvert_jpg_Bye = await convertImage.ConverFromFileToByte(result.FileImage);
                            result.ImgBase64 = ImageConvert_jpg;
                            result.ContentImage_Doc = ImageConvert_jpg_Bye;
                            break;
                        case "JPEG":
                            var ImageConvert_JPEG = await convertImage.ConverFormFileTobase64(result.FileImage);
                            var ImageConvert_JPEG_Bye = await convertImage.ConverFromFileToByte(result.FileImage);
                            result.ImgBase64 = ImageConvert_JPEG;
                            result.ContentImage_Doc = ImageConvert_JPEG_Bye;
                            break;
                        case "jpeg":
                            var ImageConvert_jpeg = await convertImage.ConverFormFileTobase64(result.FileImage);
                            var ImageConvert_jpeg_Bye = await convertImage.ConverFromFileToByte(result.FileImage);
                            result.ImgBase64 = ImageConvert_jpeg;
                            result.ContentImage_Doc = ImageConvert_jpeg_Bye;
                            break;
                        case "PNG":
                            var ImageConvert_PNG = await convertImage.ConverFormFileTobase64(result.FileImage);
                            var ImageConvert_PNG_Bye = await convertImage.ConverFromFileToByte(result.FileImage);
                            result.ImgBase64 = ImageConvert_PNG;
                            result.ContentImage_Doc = ImageConvert_PNG_Bye;
                            break;
                        case "png":
                            var ImageConvert_png = await convertImage.ConverFormFileTobase64(result.FileImage);
                            var ImageConvert_png_Bye = await convertImage.ConverFromFileToByte(result.FileImage);
                            result.ImgBase64 = ImageConvert_png;
                            result.ContentImage_Doc = ImageConvert_png_Bye;
                            break;
                        case "GIF":
                            var ImageConvert_GIF = await convertImage.ConverFormFileTobase64(result.FileImage);
                            var ImageConvert_GIF_Bye = await convertImage.ConverFromFileToByte(result.FileImage);
                            result.ImgBase64 = ImageConvert_GIF;
                            result.ContentImage_Doc = ImageConvert_GIF_Bye;
                            break;
                        case "gif":
                            var ImageConvert_gif = await convertImage.ConverFormFileTobase64(result.FileImage);
                            var ImageConvert_gif_Bye = await convertImage.ConverFromFileToByte(result.FileImage);
                            result.ImgBase64 = ImageConvert_gif;
                            result.ContentImage_Doc = ImageConvert_gif_Bye;
                            break;
                        case "pdf":
                            ConverFile = await context_Staff.ConverDataFile(result.FileImage);
                            result.MimeType = ConverFile.MineType;
                            result.ContentImage_Doc = ConverFile.ContentFile;
                            break;
                        case "docx":
                            ConverFile = await context_Staff.ConverDataFile(result.FileImage);
                            result.MimeType = ConverFile.MineType;
                            result.ContentImage_Doc = ConverFile.ContentFile;
                            break;
                        case "xlsx":
                            ConverFile = await context_Staff.ConverDataFile(result.FileImage);
                            result.MimeType = ConverFile.MineType;
                            result.ContentImage_Doc = ConverFile.ContentFile;
                            break;
                    }
                    L_ChatImages.Add(result);
                }
                return new JsonResult(1);
            }
        }

        //close sent images and file
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public IActionResult CloseSentImageFile()
        {
            L_ChatImages = new List<GetAllChatImages_V>();
            return new JsonResult(1);
        }

        //get Image message by id 
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public async Task<IActionResult> GetImageBy_id(int Id_File)
        {
            var result = await context_Staff.GetImageBy_Id(Id_File);
            return new JsonResult(result);
        }

        //dowload file in message
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public async Task<FileResult> DowloadFileInMessage(int Id_File)
        {
            if (Id_File == 0)
            {
                return null;
            }
            else
            {
                var result = await context_Staff.DowloadFile_ById(Id_File);
                if (result.Id == 0)
                {
                    return null;
                }
                else
                {
                    return File(result.ContentImage_Doc, result.MimeType);
                }
            }
        }

        //show list slider images in message
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public IActionResult ListImagesInMessage()
        {
            var result = context_Staff.SliderListImageMessage();
            return new JsonResult(result);
        }

        //get all file in message
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public IActionResult ListFileInMessage()
        {
            var result = context_Staff.GetAllFileInMessage();
            return new JsonResult(result);
        }

        //filter file in message
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public IActionResult Fuilter_ListFile(string DateFuilter)
        {
            string[] StrDate = DateFuilter.Split(" to ");
            DateTime DateTime_1 = Convert.ToDateTime(StrDate[0]);
            DateTime DateTime_2 = Convert.ToDateTime(StrDate[1]);
            var result = context_Staff.GetAllFileInMessage();
            var l_Result = result.Where(x => x.Key_Date.Date >= DateTime_1 && x.Key_Date.Date <= DateTime_2).ToList();
            return new JsonResult(l_Result);
        }

        //---------------------------------------------------------------------

        //Update Staff
        [Authorize(Roles = RoleSetting.symbolRole_Admin)]
        [HttpGet]
        public IActionResult Page_UpdateStaff(Guid IdUser)
        {
            ViewBag.IdUser = IdUser;
            return View();
        }
        [Authorize(Roles = RoleSetting.symbolRole_Admin)]
        [HttpGet]
        public async Task<IActionResult> Get_UpdateStaff(Guid IdUser)
        {
            var result = await context_Staff.Get_UpdateStaff(IdUser);
            return new JsonResult(result);
        }
        [Authorize(Roles = RoleSetting.symbolRole_Admin)]
        [HttpPost]
        public async Task<IActionResult> Post_UpdateStaff(UpdateImageStaff request)
        {
            var result = new UpdateStaff_V();
            var return_Data = new NotificationUser_V();
            result = JsonConvert.DeserializeObject<UpdateStaff_V>(request.UpdateStaff_Json);
            //check file 
            if (request.ImgAvata != null)
            {
                var GetFileName = request.ImgAvata.FileName;
                //conver IFormFile -> bye
                result.AvataUser = await convertImage.ConverFromFileToByte(request.ImgAvata);

                //slipt string name file
                string[] StringName = GetFileName.Split('.');
                string String_1 = StringName[1];
                switch (String_1)
                {
                    case "JPG":
                        result.TypeImage = String_1;
                        result.NameImage = GetFileName;                        
                        break;
                    case "jpg":
                        result.TypeImage = String_1;
                        result.NameImage = GetFileName;
                        break;
                    case "JPEG":
                        result.TypeImage = String_1;
                        result.NameImage = GetFileName;
                        break;
                    case "jpeg":
                        result.TypeImage = String_1;
                        result.NameImage = GetFileName;
                        break;
                    case "PNG":
                        result.TypeImage = String_1;
                        result.NameImage = GetFileName;
                        break;
                    case "png":
                        result.TypeImage = String_1;
                        result.NameImage = GetFileName;
                        break;
                    case "GIF":
                        result.TypeImage = String_1;
                        result.NameImage = GetFileName;
                        break;
                    case "gif":
                        result.TypeImage = String_1;
                        result.NameImage = GetFileName;
                        break;
                    default:
                        return_Data.Status = false;
                        return_Data.IdNotification = 0; //file avata ivalite
                        return new JsonResult(return_Data);
                }
                return_Data = await context_Staff.Post_UpdateStaff(result);
            }
            else
            {
                return_Data = await context_Staff.Post_UpdateStaff(result);
            }
            return new JsonResult(return_Data);
        }

        //Detail Staff
        [Authorize(Roles = RoleSetting.symbolRole_Admin)]
        [HttpGet]
        public IActionResult Page_DetailStaff(Guid IdUser)
        {
            ViewBag.IdUser = IdUser;
            return View();
        }
        [Authorize(Roles = RoleSetting.symbolRole_Admin)]
        [HttpGet]
        public async Task<IActionResult> Get_DetailStaff(Guid IdUser)
        {
            var result = new DetailStaff_V();
            result = await context_Staff.DetailStaff(IdUser);
            return new JsonResult(result);
        }

        //block account Staff
        [Authorize(Roles = RoleSetting.symbolRole_Admin)]
        [HttpPost]
        public async Task<IActionResult> BlockAccountStaff(Guid IdUser)
        {
            var result = new NotificationUser_V();
            result = await context_Staff.BlockAccountStaff(IdUser);
            return new JsonResult(result);
        }

        //open lock account Staff
        [Authorize(Roles = RoleSetting.symbolRole_Admin)]
        [HttpPost]
        public async Task<IActionResult> OpenlockAccountStaff(Guid IdUser)
        {
            var result = new NotificationUser_V();
            result = await context_Staff.OpenLockAccount(IdUser);
            return new JsonResult(result);
        }

        //cancel hide staff
        [Authorize(Roles = RoleSetting.symbolRole_Admin)]
        [HttpPost]
        public async Task<IActionResult> CancelHideStaff(Guid IdUser)
        {
            var result = new NotificationUser_V();
            result = await context_Staff.CancelHideStaff(IdUser);
            return new JsonResult(result);
        }

        // Decentralization Role Staff
        [Authorize(Roles = RoleSetting.symbolRole_Admin)]
        [HttpGet]
        public async Task<IActionResult> GetDecenRoleSatff(Guid IdUser)
        {
            var result = await context_Staff.Get_DecenRoleSatff(IdUser);
            return new JsonResult(result);
        }

        //change role for staff
        [Authorize(Roles = RoleSetting.symbolRole_Admin)]
        [HttpPost]
        public async Task<IActionResult> ChangeRoleStaff(Guid IdUser, Guid IdRole, Guid IdRoleCurrent)
        {
            var Stream = HttpContext.Request.Cookies["Token"];
            var hander = new JwtSecurityTokenHandler();
            var jsontoken = hander.ReadToken(Stream);
            var token = jsontoken as JwtSecurityToken;
            Guid IdUserDecenRole = Guid.Parse(token.Claims.FirstOrDefault(x => x.Type == "C_IdUser").Value);
            var result = new NotificationUser_V();
            result = await context_Staff.ChangeRoleStaff(IdUser, IdRole, IdUserDecenRole, IdRoleCurrent);
            return new JsonResult(result);
        }

        //check gmail for change password staff
        [Authorize(Roles = RoleSetting.symbolRole_Admin)]
        [HttpGet]
        public async Task<IActionResult> CheckGmailChangePassword(string Gmail)
        {
            var result = await context_Staff.CheckGmailStaff(Gmail);
            return new JsonResult(result);
        }

        //change password staff
        [Authorize(Roles = RoleSetting.symbolRole_Admin)]
        [HttpPost]
        public async Task<IActionResult> ChangePasswordStaff(string Gmail, string Password)
        {
            var result = await context_Staff.ChangePasswordStaff(Gmail, Password);
            return new JsonResult(result);
        }

        //create plan staff
        [Authorize(Roles = RoleSetting.symbolRole_Admin)]
        [HttpPost]
        public async Task<IActionResult> CreatePlanStaff(PlanFileStaff request)
        {
            var Stream = HttpContext.Request.Cookies["Token"];
            var hander = new JwtSecurityTokenHandler();
            var jsontoken = hander.ReadToken(Stream);
            var token = jsontoken as JwtSecurityToken;
            var Result_Data = new NotificationUser_V();
            var result = new CreatePlan_V();
            result = JsonConvert.DeserializeObject<CreatePlan_V>(request.CreatePlan_V);
            result.IdUserRequest = Guid.Parse(token.Claims.FirstOrDefault(x => x.Type == "C_IdUser").Value);
            if (request.L_FilePlans != null)
            {
                foreach(var item in request.L_FilePlans)
                {
                    var CheckData = new CreatePlanFile_V();
                    var ConverFile = new ConverFile();
                    var NameFile = item.FileName;
                    string[] StringName = NameFile.Split('.');
                    CheckData.NameFile = NameFile;
                    switch (StringName[1])
                    {
                        case "JPG":
                            CheckData.TypeFile = "JPG";
                            CheckData.DateCreate = DateTime.UtcNow.AddHours(7);                           
                            CheckData.ContentFile = await convertImage.ConverFromFileToByte(item);
                            break;
                        case "jpg":
                            CheckData.TypeFile = "jpg";
                            CheckData.DateCreate = DateTime.UtcNow.AddHours(7);
                            CheckData.ContentFile = await convertImage.ConverFromFileToByte(item);
                            break;
                        case "JPEG":
                            CheckData.TypeFile = "JPEG";
                            CheckData.DateCreate = DateTime.UtcNow.AddHours(7);
                            CheckData.ContentFile = await convertImage.ConverFromFileToByte(item);
                            break;
                        case "jpeg":
                            CheckData.TypeFile = "jpeg";
                            CheckData.DateCreate = DateTime.UtcNow.AddHours(7);
                            CheckData.ContentFile = await convertImage.ConverFromFileToByte(item);
                            break;
                        case "PNG":
                            CheckData.TypeFile = "PNG";
                            CheckData.DateCreate = DateTime.UtcNow.AddHours(7);
                            CheckData.ContentFile = await convertImage.ConverFromFileToByte(item);
                            break;
                        case "png":
                            CheckData.TypeFile = "png";
                            CheckData.DateCreate = DateTime.UtcNow.AddHours(7);
                            CheckData.ContentFile = await convertImage.ConverFromFileToByte(item);
                            break;
                        case "GIF":
                            CheckData.TypeFile = "GIF";
                            CheckData.DateCreate = DateTime.UtcNow.AddHours(7);
                            CheckData.ContentFile = await convertImage.ConverFromFileToByte(item);
                            break;
                        case "gif":
                            CheckData.TypeFile = "gif";
                            CheckData.DateCreate = DateTime.UtcNow.AddHours(7);
                            CheckData.ContentFile = await convertImage.ConverFromFileToByte(item);
                            break;
                        case "pdf":
                            CheckData.TypeFile = "pdf";
                            CheckData.DateCreate = DateTime.UtcNow.AddHours(7);
                            ConverFile = await context_Staff.ConverDataFile(item);
                            CheckData.MimeType = ConverFile.MineType;
                            CheckData.ContentFile = ConverFile.ContentFile;
                            break;
                        case "docx":
                            CheckData.TypeFile = "docx";
                            CheckData.DateCreate = DateTime.UtcNow.AddHours(7);
                            ConverFile = await context_Staff.ConverDataFile(item);
                            CheckData.MimeType = ConverFile.MineType;
                            CheckData.ContentFile = ConverFile.ContentFile;
                            break;
                        case "xlsx":
                            CheckData.TypeFile = "xlsx";
                            CheckData.DateCreate = DateTime.UtcNow.AddHours(7);
                            ConverFile = await context_Staff.ConverDataFile(item);
                            CheckData.MimeType = ConverFile.MineType;
                            CheckData.ContentFile = ConverFile.ContentFile;
                            break;
                        default:
                            Result_Data.IdNotification = 0; //System not support this type file
                            Result_Data.Status = false;
                            return new JsonResult(Result_Data);
                    }
                    result.L_FilePlan.Add(CheckData);
                }
                Result_Data = await context_Staff.CreatePlanStaff(result);
            }
            else
            {
                Result_Data = await context_Staff.CreatePlanStaff(result);
            }
            return new JsonResult(Result_Data);
        }


        //Manager user_______________________________________________________________
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public IActionResult Page_User()
        {
            return View();
        }
        //get all user
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public async Task<IActionResult> GetAllUser(int PageIndex, int PageSize, string SeachKey)
        {
            var result = await context_User.GetAllUsers();
            var ModalsPage = new PagingUser();
            if(SeachKey != null)
            {
                var GetData = SeachNameUserPage(result, SeachKey);
                ModalsPage.L_User = GetData.Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                ModalsPage.TotalUser = GetData.Count();
            }
            else
            {
                ModalsPage.L_User = result.Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                ModalsPage.TotalUser = result.Count();
            }
            return new JsonResult(ModalsPage);
        }

        //get users birthday
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public async Task<IActionResult> GetAllUserBirthday()
        {
            var result = await context_User.GetAllUserBithday();
            return new JsonResult(result);
        }

        //get info user for sent birthday
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public async Task<IActionResult> GetInfoUserBirthday(Guid IdUser)
        {
            var result = await context_User.GetInfoUserBirthday(IdUser);
            return new JsonResult(result);
        }

        //sent birthday user
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpPost]
        public async Task<IActionResult> SentBirthday(SaveFileEmail request)
        {
            var result = new GetInfoUserBirthday_V();
            result = JsonConvert.DeserializeObject<GetInfoUserBirthday_V>(request.GetInfoUserBirthday_V);
            result.Attachments = request.file;
            var Results = await context_User.SentMessageBirthdayUser(result);
            return new JsonResult(Results);
        }

        //get all sent birthday user
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public async Task<IActionResult> GetAllSentMessageBirthday(int PageIndex, int PageSize, bool SortId, string SeachName)
        {
            var result = await context_User.GetAllSentMessageBirthday();
            var ModalPaing = new PagingSentHistoryBirthday();
            var L_UserSeachKey = new List<GetAllSentBirthdayUser_V>();
            if(SortId == true)
            {
                if(SeachName != null)
                {
                    L_UserSeachKey = SeachNameUser(result, SeachName);
                    ModalPaing.L_MessageSent = L_UserSeachKey.OrderByDescending(x => x.Id).Skip((PageIndex - 1) * PageSize)
                                                                    .Take(PageSize).ToList();
                }
                else
                {
                    ModalPaing.L_MessageSent = result.OrderByDescending(x => x.Id).Skip((PageIndex - 1) * PageSize)
                                                                    .Take(PageSize).ToList();
                }
            }
            else
            {
                if (SeachName != null)
                {
                    L_UserSeachKey = SeachNameUser(result, SeachName);
                    ModalPaing.L_MessageSent = L_UserSeachKey.OrderBy(x => x.Id).Skip((PageIndex - 1) * PageSize)
                                                                .Take(PageSize).ToList();
                }
                else
                {
                    ModalPaing.L_MessageSent = result.OrderBy(x => x.Id).Skip((PageIndex - 1) * PageSize)
                                                                .Take(PageSize).ToList();
                }
            }
            ModalPaing.TotalMessage = result.Count();
            return new JsonResult(ModalPaing);
        }

        //detail user
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public IActionResult Page_DetailUser(Guid Iduser)
        {
            ViewBag.IdUser = Iduser;
            return View();
        }
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public async Task<IActionResult> JsonDetailUser(Guid IdUser)
        {
            var result = await context_User.DetailUser(IdUser);
            return new JsonResult(result);
        }

        //Get time working by id user
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public async Task<IActionResult> JsonGetTimeWorkingUser(Guid IdUser, int Page, int Size)
        {
            var result = await context_User.GetTimeWorkingByUser(IdUser);
            var ModalPaing = new PaingTimeWorkingUser();
            ModalPaing.L_WorkingTime = result.Skip((Page - 1) * Size).Take(Size).ToList();
            ModalPaing.TotalTimeWoking = result.Count();
            return new JsonResult(ModalPaing);
        }

        //get start rating by id user
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public async Task<IActionResult> JsonGetRatingtUser(Guid IdUser, int Page, int Size)
        {
            var result = await context_User.GetAllRatingByIdUser(IdUser);
            var PagingModal = new PagingRatingByIdUser();
            PagingModal.L_Rating = result.Skip((Page - 1) * Size).Take(Size).ToList();
            PagingModal.TotalRating = result.Count();
            return new JsonResult(PagingModal);
        }

        //get all comment by id user
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public async Task<IActionResult> JsonGetCommentUser(Guid IdUser, int Page, int Size)
        {
            var result = await context_User.GetAllCommentByIdUser(IdUser);
            var PagingModal = new PagingCommentByIdUser();
            PagingModal.L_Comment = result.Skip((Page - 1) * Size).Take(Size).ToList();
            PagingModal.TotalComment = result.Count();
            return new JsonResult(PagingModal);
        }

        //get all dowload by id user
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public async Task<IActionResult> JsonGetDowloadUser(Guid IdUser, int Page, int Size)
        {
            var result = await context_User.GetAllDowloadByIdUser(IdUser);
            var PagingModal = new DowloadMusic();
            PagingModal.L_DowloadMuisc = result.Skip((Page - 1) * Size).Take(Size).ToList();
            PagingModal.TotalDowload = result.Count();
            return new JsonResult(PagingModal);
        }

        //get all request user by id user
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public async Task<IActionResult> JsonGetRequestloadUser(Guid IdUser, int Page, int Size)
        {
            var result = await context_User.GetAllDowloadByIdUser(IdUser);
            var PagingModal = new DowloadMusic();
            PagingModal.L_DowloadMuisc = result.Skip((Page - 1) * Size).Take(Size).ToList();
            PagingModal.TotalDowload = result.Count();
            return new JsonResult(PagingModal);
        }


        private List<GetAllSentBirthdayUser_V> SeachNameUser(List<GetAllSentBirthdayUser_V> L_UserBirthday, string KeySeach)
        {
            List<GetAllSentBirthdayUser_V> L_SentBirthdayUser = new List<GetAllSentBirthdayUser_V>();
            L_SentBirthdayUser = L_UserBirthday.Where(x => x.NameUser.Contains(KeySeach)).ToList();
            return L_SentBirthdayUser;
        }

        private List<GetAllUsers_V> SeachNameUserPage(List<GetAllUsers_V> L_User, string KeySeach)
        {
            var result = new List<GetAllUsers_V>();
            //seach name
            result = L_User.Where(x => x.NameUsers.Contains(KeySeach)).ToList();
            if(result.Count() == 0)
            {
                result = L_User.Where(x => x.Age == Convert.ToInt32(KeySeach)).ToList();
            }
            return result;
        }



    }
}
