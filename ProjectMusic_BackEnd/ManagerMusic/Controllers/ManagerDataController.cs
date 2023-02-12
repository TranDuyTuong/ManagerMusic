using DataApplication.ApplicationAdmin.ApplicationMusic.Music_App;
using DataViewModel.ViewModelAdmin.Music_Vm;
using ManagerMusic.Models.FileImage;
using ManagerMusic.Models.Paging.Page_Comment;
using ManagerMusic.Models.Paging.Page_HistoryUpdate;
using ManagerMusic.Models.Paging.Page_Rating;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;
using static DataUtilities.NameRoleSetting;

namespace ManagerMusic.Controllers
{
    [Authorize]
    public class ManagerDataController : BaseController
    {
        private readonly ILogger<ManagerDataController> _logger;
        private readonly ImusicApplication _Context;
        public ManagerDataController(ILogger<ManagerDataController> logger, ImusicApplication Context)
        {
            _logger = logger;
            _Context = Context;

        }

        //GetAll Music
        [Authorize(Roles = RoleSetting.symbolRole_Satff + "," + RoleSetting.symbolRole_Admin)]
        [HttpGet]
        public IActionResult IndexFile()
        {
            return View();
        }
        [Authorize(Roles = RoleSetting.symbolRole_Satff + "," + RoleSetting.symbolRole_Admin)]
        [HttpGet]
        public IActionResult Json_Music(int PageSize, int PageIndex, int IdSeason, 
                                        string SeachKey, int IdStatus, int Sort_No)
        {
            var Result = _Context.GetAllMusic(PageSize, PageIndex, IdSeason, SeachKey, IdStatus, Sort_No);
            return new JsonResult(Result);
        }

        //create Music
        [Authorize(Roles = RoleSetting.symbolRole_Satff + "," + RoleSetting.symbolRole_Admin)]
        [HttpGet]
        public IActionResult CreateMusic()
        {
            return View();
        }
        [Authorize(Roles = RoleSetting.symbolRole_Satff + "," + RoleSetting.symbolRole_Admin)]
        [HttpPost]
        public async Task<IActionResult> JsonCreateMusic(SaveFileMusic request)
        {
            var Stream = HttpContext.Request.Cookies["Token"];
            if (Stream == null)
            {
                var result_v = new NotificationMusic_V();
                result_v.IsStatus = 4;
                result_v.Status = false;
                return new JsonResult(result_v);
            }
            var hander = new JwtSecurityTokenHandler();
            var jsontoken = hander.ReadToken(Stream);
            var token = jsontoken as JwtSecurityToken;
            Guid IdUser = Guid.Parse(token.Claims.FirstOrDefault(x => x.Type == "C_IdUser").Value);
            CreateMusic_V result = JsonConvert.DeserializeObject<CreateMusic_V>(request.Music);
            //Split string name
            string[] NameImageString = request.fileImage.FileName.Split('.');
            result.DateCreate = DateTime.UtcNow.AddHours(7);
            result.TimeCreate = DateTime.UtcNow.AddHours(7);
            result.IdUser = IdUser;
            result.NoMusic = "BH" + DateTime.Now.Second + result.Year;
            result.FileMusic = request.fileDoc;
            result.FileName = request.fileDoc.FileName;
            result.TokenData = Stream;
            result.FileImage = request.fileImage;
            result.IdStaff = token.Claims.FirstOrDefault(x => x.Type == "C_IdStaff").Value;
            result.TypeImage = NameImageString[1];
            var result_Data = await _Context.CreateMusic(result);
            return new JsonResult(result_Data);
        }

        //Detail music
        [Authorize(Roles = RoleSetting.symbolRole_Satff + "," + RoleSetting.symbolRole_Admin)]
        [HttpGet]
        public IActionResult DetailMusic(Guid IdMusic)
        {
            ViewBag.IdMusic = IdMusic;
            return View();
        }
        [Authorize(Roles = RoleSetting.symbolRole_Satff + "," + RoleSetting.symbolRole_Admin)]
        [HttpPost]
        public async Task<IActionResult> JsonDetailMusic(Guid IdMusic)
        {
            var result = await _Context.DetailMusic(IdMusic);
            if(result == null)
            {
                return new JsonResult(0);
            }
            else
            {
                return new JsonResult(result);
            }
        }

        //get all comment by id music
        [Authorize(Roles = RoleSetting.symbolRole_Satff + "," + RoleSetting.symbolRole_Admin)]
        [HttpPost]
        public IActionResult JsonGetCommentByIdMusic(Guid IdMusic, int PageSize, int PageIndex)
        {
            var result =  _Context.GetAllCommentByIdMuisc(IdMusic);
            if(result.Count() == 0)
            {
                return new JsonResult(0);
            }
            else
            {
                var Result = result.Skip((PageIndex - 1) * PageSize).Take(PageSize);
                var PagingResult = new PagingComments()
                {
                    L_Comments = Result,
                    TotalComment = result.Count()
                };
                return new JsonResult(PagingResult);
            }
        }

        //get all rating by id muisc
        [Authorize(Roles = RoleSetting.symbolRole_Satff + "," + RoleSetting.symbolRole_Admin)]
        [HttpPost]
        public IActionResult JsonGetRatingByIdMusic(Guid IdMusic, int PageSize, int PageIndex)
        {
            var result = _Context.GetAllRatingByIdMuisc(IdMusic);
            if (result.Count() == 0)
            {
                return new JsonResult(0);
            }
            else
            {
                var Result = result.Skip((PageIndex - 1) * PageSize).Take(PageSize);
                var PagingResult = new PagingRatings()
                {
                    L_Ratings = Result,
                    TotalRatings = result.Count()
                };
                return new JsonResult(PagingResult);
            }
        }

        //Update Muisc
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public IActionResult UpdateMusic(Guid IdMuisc)
        {
            ViewBag.IdMuiscUpdate = IdMuisc;
            return View();
        }
        [Authorize(Roles = RoleSetting.symbolRole_Satff + "," + RoleSetting.symbolRole_Admin)]
        [HttpPost]
        public async Task<IActionResult> JsonLoadUpdateMuisc(Guid IdMuisc)
        {
            if(IdMuisc == new Guid())
            {
                return new JsonResult(1); // null IdMuisc
            }
            else
            {
                var result = await _Context.GetUpdateMusic(IdMuisc);
                if(result == null)
                {
                    return new JsonResult(0); // null data
                }
                else
                {
                    return new JsonResult(result);
                }

            }
            
        }
        [Authorize(Roles = RoleSetting.symbolRole_Satff + "," + RoleSetting.symbolRole_Admin)]
        [HttpPost]
        public async Task<IActionResult> JsonUpdateMuisc(UpdateFileMuisc request)
        {
            UpdateMuisc_V result = JsonConvert.DeserializeObject<UpdateMuisc_V>(request.UpdateMuisc_V);
            if(result.IdMuisc == new Guid())
            {
                var result_E = new NotificationMusic_V()
                {
                    IsStatus = 5, // id music null
                    Status = false
                };
                return new JsonResult(result_E);
            }
            else
            {
                var Stream = HttpContext.Request.Cookies["Token"];
                var hander = new JwtSecurityTokenHandler();
                var jsontoken = hander.ReadToken(Stream);
                var token = jsontoken as JwtSecurityToken;
                Guid IdUser = Guid.Parse(token.Claims.FirstOrDefault(x => x.Type == "C_IdUser").Value);

                result.IdUser = IdUser;
                if (request.FileImage != null && request.FileMusic != null)
                {
                    //Split string name
                    string[] NameImageString = request.FileImage.FileName.Split('.');
                    result.NameFile = request.FileMusic.FileName;
                    result.FormFile_Muisc = request.FileMusic;
                    result.FormFile_Image = request.FileImage;
                    result.TypeImage = NameImageString[1];
                }
                result.TokenData = Stream;
                result.DateUpdate = DateTime.Now.AddHours(7);
                var result_S = await _Context.UpdateMuisc(result);
                return new JsonResult(result_S);
            }

        }

        //partial menu header for manager file
        [Authorize(Roles = RoleSetting.symbolRole_Satff + "," + RoleSetting.symbolRole_Admin)]
        [HttpGet]
        public IActionResult MenuManagerFile()
        {
            return View();
        }

        //get all status music
        [Authorize(Roles = RoleSetting.symbolRole_Satff + "," + RoleSetting.symbolRole_Admin)]
        [HttpGet]
        public IActionResult GetAllStatusMusic()
        {
            var result = _Context.GetAllSatusMusic();
            if(result.Count() == 0)
            {
                return new JsonResult(0);
            }
            else
            {
                return new JsonResult(result);
            }
        }

        //change status music
        [Authorize(Roles = RoleSetting.symbolRole_Satff + "," + RoleSetting.symbolRole_Admin)]
        [HttpPost]
        public async Task<IActionResult> ChangeStatusMusic(int IdStatus, Guid IdMusic)
        {
            var Stream = HttpContext.Request.Cookies["Token"];
            var hander = new JwtSecurityTokenHandler();
            var jsontoken = hander.ReadToken(Stream);
            var token = jsontoken as JwtSecurityToken;
            Guid IdUser = Guid.Parse(token.Claims.FirstOrDefault(x => x.Type == "C_IdUser").Value);
            var result = await _Context.ChangeStatusMusic(IdStatus, IdMusic, IdUser);
            return new JsonResult(result);
        }

        //delete nusic
        [Authorize(Roles = RoleSetting.symbolRole_Satff + "," + RoleSetting.symbolRole_Admin)]
        [HttpPost]
        public async Task<IActionResult> DeleteMusic(Guid IdMusic, List<Guid> L_IdMuisc)
        {
            if (IdMusic == new Guid() && L_IdMuisc.Count() == 0)
            {
                var result = new NotificationMusic_V()
                {
                    IsStatus = 6, //id music null
                    Status = false
                };
                return new JsonResult(result);
            }
            else {
                var Stream = HttpContext.Request.Cookies["Token"];
                var hander = new JwtSecurityTokenHandler();
                var jsontoken = hander.ReadToken(Stream);
                var token = jsontoken as JwtSecurityToken;
                Guid IdUser = Guid.Parse(token.Claims.FirstOrDefault(x => x.Type == "C_IdUser").Value);
                var result = await _Context.DeleteMusic(IdMusic, IdUser, L_IdMuisc);
                return new JsonResult(result);
            }
        }

        //dowload muisc
        private static byte[] ContentDataFile;
        private static string MineTypeFile;

        [Authorize(Roles = RoleSetting.symbolRole_Satff + "," + RoleSetting.symbolRole_Admin)]
        [HttpPost]
        public async Task<IActionResult> DowloadMusicStaff(Guid IdMusic)
        {
            if(IdMusic == new Guid())
            {
                var result = new NotificationMusic_V()
                {
                    IsStatus = 6, // null id music
                    Status = false
                };
                return new JsonResult(result);
            }
            else
            {
                var Stream = HttpContext.Request.Cookies["Token"];
                var hander = new JwtSecurityTokenHandler();
                var jsontoken = hander.ReadToken(Stream);
                var token = jsontoken as JwtSecurityToken;
                Guid IdUser = Guid.Parse(token.Claims.FirstOrDefault(x => x.Type == "C_IdUser").Value);
                string IdStaff = token.Claims.FirstOrDefault(x => x.Type == "C_IdStaff").Value;
                var result = new DowloadMusic_V()
                {
                    IdMusic = IdMusic,
                    NameUser = IdStaff,
                    IdUser = IdUser,
                    DateDowload = DateTime.UtcNow.AddHours(7)
                };
                var Result = await _Context.DowloadMusicStaff(result);
                if(Result.Status == true)
                {
                    ContentDataFile = Result.ContentFile;
                    MineTypeFile = Result.MineType;
                }
                return new JsonResult(Result);             
            }
        }

        [Authorize(Roles = RoleSetting.symbolRole_Satff + "," + RoleSetting.symbolRole_Admin)]
        [HttpGet]
        public FileResult FileDowload()
        {
            if(ContentDataFile != null && MineTypeFile != null)
            {
                return File(ContentDataFile, MineTypeFile);
            }
            else
            {
                return null;
            }
        }

        //Update History
        [Authorize(Roles =RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public IActionResult UpdateHistory(Guid IdMusic)
        {
            ViewBag.IdMusic = IdMusic;
            return View();
        }
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpPost]
        public IActionResult JsonGetUpdateHistory(Guid IdMusic, int PageIndex, int PageSize)
        {
            if(IdMusic == new Guid())
            {
                return new JsonResult(0);
            }
            else
            {
                var result = _Context.GetAllHistoryUpdate(IdMusic);
                var PagingData = result.Skip((PageIndex - 1) * PageSize).Take(PageSize);
                var modals = new PageHistoryUpdate()
                {
                    L_HistoryUpdate = PagingData,
                    Total = result.Count()
                };
                return new JsonResult(modals);
            }
        }

        //activer file music
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpPost]
        public async Task<IActionResult> JsonActiverFile(List<Guid> L_IdMusic)
        {
            var Stream = HttpContext.Request.Cookies["Token"];
            var hander = new JwtSecurityTokenHandler();
            var jsontoken = hander.ReadToken(Stream);
            var token = jsontoken as JwtSecurityToken;
            string NameStaff = token.Claims.FirstOrDefault(x => x.Type == "C_FullName").Value;
            var result = await _Context.ActiverFileMusic(L_IdMusic, NameStaff);
            return new JsonResult(result);
        }

        //get all file was dowload
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public IActionResult DowloadFileMusic()
        {
            return View();
        }
        
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpPost]
        public IActionResult JsonGetAllFileDowload(int pageSize, int pageIndex, string SeachKey)
        {
            var result = _Context.GetAllFileMusicDowload(pageSize, pageIndex, SeachKey);
            return new JsonResult(result);
        }

        //delete DowloadMusic
        [Authorize(Roles = RoleSetting.symbolRole_Admin)]
        [HttpPost]
        public async Task<IActionResult> JsonDeleteDowloadMusic(List<int> L_Music, int IdDowload)
        {
            var result = await _Context.DeleteDowloadMusic(L_Music, IdDowload);
            return new JsonResult(result);
        }

        //detail dowload music
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public async Task<IActionResult> JsonDetailDowloadMusic(int IdDowload)
        {
            var result = await _Context.DetailDowloadMusic(IdDowload);
            return new JsonResult(result);
        }

        //get status for filter
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public IActionResult JsonGetAllStatusMusic()
        {
            var result = _Context.GetAllSatusMusic();
            return new JsonResult(result);
        }

        //get all music delete
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public IActionResult GetAllMusicDelete()
        {
            return View();
        }

        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public IActionResult JsonGetAllMusicDelete(int PageIndex, int PageSize, int SelectSeason, string Seach)
        {
            var result = _Context.GetAllMusicDelete(PageSize, PageIndex, SelectSeason, Seach);
            return new JsonResult(result);
        }

        //recover music delete
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpPost]
        public async Task<IActionResult> JsonRecoverMusicDelete(List<Guid> L_IdMusic, Guid idMusic, int flag) 
        {
            var result = new NotificationMusic_V();

            var Stream = HttpContext.Request.Cookies["Token"];
            var hander = new JwtSecurityTokenHandler();
            var jsontoken = hander.ReadToken(Stream);
            var token = jsontoken as JwtSecurityToken;
            Guid IdUser = Guid.Parse(token.Claims.FirstOrDefault(x => x.Type == "C_IdUser").Value);
            if(IdUser == new Guid())
            {
                result.IsStatus = 7; //user id mull
                result.Status = false;
            }
            else
            {
                //flag = 1 => list music -- flag = 2 => a music
                switch (flag)
                {
                    case 1:
                        if (L_IdMusic.Count() == 0)
                        {
                            result.IsStatus = 1; // list music null
                            result.Status = false;
                        }
                        else
                        {
                            result = await _Context.RecoverMusicDelete(L_IdMusic, idMusic, flag, IdUser);
                        }
                        break;
                    case 2:
                        if (idMusic == new Guid())
                        {
                            result.IsStatus = 2; //a music null
                            result.Status = false;
                        }
                        else
                        {
                            result = await _Context.RecoverMusicDelete(L_IdMusic, idMusic, flag, IdUser);
                        }
                        break;
                    default:
                        result.IsStatus = 6; //recover music error
                        result.Status = false;
                        break;
                }
            }
            return new JsonResult(result);
        }

        // get 10 new music
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public IActionResult IndexNewMusic()
        {
            return View();
        }

        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public IActionResult JsonGetNewMusic(int PageIndex, int PageSize)
        {
            var result = _Context.GetNewMusic(PageSize, PageIndex);
            return new JsonResult(result);
        }



    }
}
