using DataService.ServiceAdmin.User;
using DataViewModel.ViewModelAdmin.ConverFile_Vm;
using DataViewModel.ViewModelAdmin.Plan_Vm;
using DataViewModel.ViewModelAdmin.Role_Vm;
using DataViewModel.ViewModelAdmin.User_Vm;
using DataViewModel.ViewModelUser.LoginAndRegiter_Vm;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataApplication.ApplicationAdmin.ApplicationStaff.Staff_App
{
    public class Staff_app : Istaff_app
    {
        private readonly IUser context;
        public Staff_app(IUser _context)
        {
            context = _context;
        }

        //convert IFromFile -> Bye[]
        public async Task<byte[]> ConverFromFileToByte(IFormFile request)
        {
            byte[] ImageConvert;
            using (var ms = new MemoryStream())
            {
                await request.CopyToAsync(ms);
                var FileByte = ms.ToArray();
                ImageConvert = FileByte;
            }
            return ImageConvert;
        }

        //convert  IFromFile -> base64 string
        public async Task<string> ConverFormFileTobase64(IFormFile request)
        {
            string ImageBase64;
            using (var ms = new MemoryStream())
            {
                await request.CopyToAsync(ms);
                var FileConver = ms.ToArray();
                ImageBase64 = Convert.ToBase64String(FileConver);
            }
            return ImageBase64;
        }

        //create staff
        public async Task<NotificationRegiter_V> CreateStaff(CreateSatff_V request)
        {
            var Year = DateTime.Now.Year;
            var secondTime = DateTime.Now.Second;
            string NameAvata = request.ImageAvata.FileName;
            string[] StrAvata = NameAvata.Split('.');
            string StrAvata_1 = StrAvata[1];
            switch (request.IdLever)
            {
                case 2:
                    string symbol_NV = "NV";
                    string IdStaff_success = symbol_NV + secondTime + Year;
                    request.IdStaff = IdStaff_success;
                    request.IdAccountActiver = 1;
                    request.IdStaffOrUser = 2;
                    request.Age = Year - request.Birthday.Year;
                    request.StatusStaffOff = 1;
                    request.CancelHideStaff = 1;
                    //conver image from IFormFile -> bye[]
                    if (request.ImageAvata.Length > 0)
                    {
                        //choose type image
                        switch (StrAvata_1)
                        {
                            case "JPG":
                                request.TypeImage = StrAvata_1;
                                request.NameImage = NameAvata;
                                break;
                            case "jpg":
                                request.TypeImage = StrAvata_1;
                                request.NameImage = NameAvata;
                                break;
                            case "JPEG":
                                request.TypeImage = StrAvata_1;
                                request.NameImage = NameAvata;
                                break;
                            case "jpeg":
                                request.TypeImage = StrAvata_1;
                                request.NameImage = NameAvata;
                                break;
                            case "PNG":
                                request.TypeImage = StrAvata_1;
                                request.NameImage = NameAvata;
                                break;
                            case "png":
                                request.TypeImage = StrAvata_1;
                                request.NameImage = NameAvata;
                                break;
                            case "GIF":
                                request.TypeImage = StrAvata_1;
                                request.NameImage = NameAvata;
                                break;
                            case "gif":
                                request.TypeImage = StrAvata_1;
                                request.NameImage = NameAvata;
                                break;

                        }
                        var ImageConvert = await ConverFromFileToByte(request.ImageAvata);
                        request.ImageAvataConver = ImageConvert;
                    }
                    break;
                case 3:
                    string symbol_AD = "AD";
                    string IdStaffsuccess = symbol_AD + secondTime + Year;
                    request.IdStaff = IdStaffsuccess;
                    request.IdAccountActiver = 1;
                    request.IdStaffOrUser = 2;
                    request.Age = Year - request.Birthday.Year;
                    request.StatusStaffOff = 1;
                    request.CancelHideStaff = 1;
                    //conver image from IFormFile -> bye[]
                    if (request.ImageAvata.Length > 0)
                    {
                        //choose type image
                        switch (StrAvata_1)
                        {
                            case "JPG":
                                request.TypeImage = StrAvata_1;
                                request.NameImage = NameAvata;
                                break;
                            case "jpg":
                                request.TypeImage = StrAvata_1;
                                request.NameImage = NameAvata;
                                break;
                            case "JPEG":
                                request.TypeImage = StrAvata_1;
                                request.NameImage = NameAvata;
                                break;
                            case "jpeg":
                                request.TypeImage = StrAvata_1;
                                request.NameImage = NameAvata;
                                break;
                            case "PNG":
                                request.TypeImage = StrAvata_1;
                                request.NameImage = NameAvata;
                                break;
                            case "png":
                                request.TypeImage = StrAvata_1;
                                request.NameImage = NameAvata;
                                break;
                            case "GIF":
                                request.TypeImage = StrAvata_1;
                                request.NameImage = NameAvata;
                                break;
                            case "gif":
                                request.TypeImage = StrAvata_1;
                                request.NameImage = NameAvata;
                                break;

                        }
                        var ImageConvert = await ConverFromFileToByte(request.ImageAvata);
                        request.ImageAvataConver = ImageConvert;
                    }
                    break;
            }
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(request.Email);
            var result = new NotificationRegiter_V();
            if (match.Success == true)
            {
                result = await context.CreateSatff(request);
                return result;
            }
            result.Status = false;
            result.Notification = "Invalid email, please try again!";
            result.IsStatus = 4;
            return result;
        }

        //get all gender
        public List<GetAllGender_V> GetAllGender()
        {
            var result = context.GetAllGender();
            return result;
        }

        //get all marriage
        public List<GetAllMarriage_V> GetAllMarriage()
        {
            var result = context.GetAllMarriage();
            return result;
        }

        //get all status account
        public List<GetAllStatusAccount_V> GetAllStatusAccount()
        {
            var result = context.GetAllStatusAccount();
            return result;
        }

        //get lever by id role
        public GetAllLever_V GetLeverByIdRole(Guid idRole)
        {
            var result = context.GetLeverByIdRole(idRole);
            return result;
        }

        //get all staff
        public List<GetAllUser_v> GetAllStaff()
        {
            var result = context.GetAllStaff();
            return result;
        }

        //create chat staff
        public async Task<GetAllChatBy_Staff> CreateChatStaff(CreateChatStaff_V request)
        {
            var result = await context.CreateChatStaff(request);
            return result;
        }

        //loading message
        public async Task<GetAllChatBy_Staff> LoadingMessage()
        {
            var result = await context.LoadingMessage();
            return result;
        }

        //info user chat
        public async Task<GetInfoChatUser_V> InfoUserChat(int IdChat, int PageIndex, int PageSize, int Sort)
        {
            var result = new GetInfoChatUser_V();
            if (IdChat == 0)
            {
                result.TotalChat = 0;
            }
            else
            {
                result = await context.InfoUserChat(IdChat);
                List<CreateChatStaff_V> L_Paging = new List<CreateChatStaff_V>();
                switch (Sort)
                {
                    case 1:
                        L_Paging = result.L_Chat.OrderByDescending(x => x.Id)
                                .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                        break;
                    case -1:
                        L_Paging = result.L_Chat.OrderBy(x => x.Id)
                                .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                        break;
                }
                result.L_Chat = L_Paging;
            }
            return result;
        }

        //create chat like message staff
        public async Task<GetAllChatBy_Staff> CreateChatIconMessage(CreateChatStaff_V request)
        {
            var result = await context.CreateChatIconMessage(request);
            return result;
        }

        //conver Iformfile to byte
        public async Task<ConverFile> ConverDataFile(IFormFile request)
        {
            var result = new ConverFile();
            await using (var ms = new MemoryStream())
            {
                request.CopyTo(ms);
                result.MineType = request.ContentType;
                result.ContentFile = ms.ToArray();
            }
            return result;
        }

        //create images chat 
        public async Task<GetAllChatBy_Staff> CreateImagesChat(CreateChatStaff_V request)
        {
            var result = await context.CreateImagesChat(request);
            return result;
        }

        //get images chat by id images
        public async Task<GetAllChatImages_V> GetImageBy_Id(int Id_File)
        {
            var result = new GetAllChatImages_V();
            if(Id_File == 0)
            {
                result.Id = 0;
            }
            else
            {
                result = await context.GetImageBy_Id(Id_File);
            }
            return result;
        }

        //dowload fin in message staff
        public async Task<GetAllChatImages_V> DowloadFile_ById(int Id_File)
        {
            var result = await context.DowloadFile_ById(Id_File);
            return result;
        }

        //get all images show slider in message
        public List<GetAllChatImages_V> SliderListImageMessage()
        {
            var result = context.ShowImagesSliderMessage();
            return result;
        }

        //get all file in mesage
        public List<GetAllFileMessage_V> GetAllFileInMessage()
        {
            var result = context.GetAllFileInMessage();
            return result;
        }

        //get totachat by id user
        public async Task<GetAllUser_v> GetTotalChatByIdUser(Guid IdUser)
        {
            var result = new GetAllUser_v();
            result = await context.GetTotalByIdUser(IdUser);
            return result;
        }

        //was view message by id user
        public async Task<bool> WasViewMessageByIdUser(Guid IdUser)
        {
            var result = await context.WasViewMessageByIdUser(IdUser);
            return result;
        }

        //get update staff
        public async Task<UpdateStaff_V> Get_UpdateStaff(Guid IdUser)
        {
            var result = new UpdateStaff_V();
            if(IdUser == new Guid())
            {
                result.IdStaff = "1";
            }
            else
            {
                result = await context.Get_UpdateStaff(IdUser);
            }
            return result;
        }

        //post update staff
        public async Task<NotificationUser_V> Post_UpdateStaff(UpdateStaff_V request)
        {
            var result = new NotificationUser_V();
            if(request.IdUser == new Guid() || request.IdStaff == null)
            {
                result.Status = false;
                result.IdNotification = 1; // null id user or id staff
            }
            else
            {
                result = await context.Post_UpdateStaff(request);
            }
            return result;
        }

        //detail staff
        public async Task<DetailStaff_V> DetailStaff(Guid IdUser)
        {
            var result = new DetailStaff_V();
            if(IdUser == new Guid())
            {
                result.IdStaff = "1";
            }
            else
            {
                result = await context.DetailStaff(IdUser);
            }
            return result;
        }

        //block account staff
        public async Task<NotificationUser_V> BlockAccountStaff(Guid IdUser)
        {
            var result = new NotificationUser_V();
            if(IdUser == new Guid())
            {
                result.IdNotification = 2; //IdUser null
                result.Status = false;
            }
            else
            {
                result = await context.BockAccount(IdUser);
            }
            return result;
        }

        //opent lock account staff
        public async Task<NotificationUser_V> OpenLockAccount(Guid IdUser)
        {
            var result = new NotificationUser_V();
            if (IdUser == new Guid())
            {
                result.IdNotification = 2; //IdUser null
                result.Status = false;
            }
            else
            {
                result = await context.OpenLockAccount(IdUser);
            }
            return result;
        }

        //cancel hide staff
        public async Task<NotificationUser_V> CancelHideStaff(Guid IdUser)
        {
            var result = new NotificationUser_V();
            if(IdUser == new Guid())
            {
                result.IdNotification = 2; //iduser ivalite
                result.Status = false;
            }
            else
            {
                result = await context.CancelHideStaff(IdUser);
            }
            return result;
        }

        //decentralization role staff
        public async Task<RoleStaff_V> Get_DecenRoleSatff(Guid IdUser)
        {
            var result = new RoleStaff_V();
            if(IdUser == new Guid())
            {
                result.FullName = "IdUserIllegal";
            }
            else
            {
                result = await context.DecenRoleStaff(IdUser);
            }           
            return result;
        }

        //change role staff
        public async Task<NotificationUser_V> ChangeRoleStaff(Guid IdUser, Guid IdRole, Guid IdUserDecenRole, Guid IdRoleCurrent)
        {
            var result = new NotificationUser_V();
            if(IdUser == new Guid())
            {
                result.IdNotification = 4; //iduser null
                result.Status = false;
            }
            else
            {
                result = await context.ChangeRoleStaff(IdUser, IdRole, IdUserDecenRole, IdRoleCurrent);
            }
            return result;
        }


        //check gmail staff
        public async Task<NotificationUser_V> CheckGmailStaff(string Gmail)
        {
            var result = await context.CheckGmailSatff(Gmail);
            return result;
        }

        //change password staff
        public async Task<NotificationUser_V> ChangePasswordStaff(string Gmail, string Password)
        {
            var result = new NotificationUser_V();
            result = await context.ChangePasswordStaff(Gmail, Password);
            return result;
        }

        //create plan for staff
        public async Task<NotificationUser_V> CreatePlanStaff(CreatePlan_V request)
        {
            var result = new NotificationUser_V();
            if(request.IdUserPlan == new Guid() || request.IdUserRequest == new Guid())
            {
                result.IdNotification = 2; //Id user plan null or Id user request null
                result.Status = false;
            }
            else
            {
                result = await context.CreatePlanStaff(request);
            }
            return result;
        }


    }
}
