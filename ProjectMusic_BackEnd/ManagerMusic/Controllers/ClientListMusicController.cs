using DataApplication.ApplicationUser.ApplicationHome.MusicClient;
using DataApplication.ApplicationUser.ApplicationHome.SaintClient;
using DataApplication.ApplicationUser.ApplicationHome.SeasonClient;
using DataViewModel.ViewModelUser.Muisc_Vm;
using DataViewModel.ViewModelUser.SaintClient_Vm;
using ManagerMusic.Models.CommentMuisc;
using ManagerMusic.Models.Paging.Page_MusicClient;
using ManagerMusic.Models.RatingMuisc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ManagerMusic.Controllers
{
    public class ClientListMusicController : Controller
    {
        private readonly ImusicClient_App context;
        private readonly IConfiguration confi;
        private readonly IseasonClient_App context_Season;
        private readonly IsaintClient_App context_Saint;
        public ClientListMusicController(ImusicClient_App _context, IConfiguration _confi, 
                                         IseasonClient_App _context_Season, IsaintClient_App _context_Saint)
        {
            context = _context;
            confi = _confi;
            context_Season = _context_Season;
            context_Saint = _context_Saint;
        }

        //page get music client
        public IActionResult IndexListMusic()
        {
            return View();
        }

        //get all music client
        [HttpGet]
        public async Task<IActionResult> JsonGetListMusic(int PageSize, int PageIndex, int S_Viewer, 
                                                                int S_Season, int S_Saint, string S_Seach)
        {
            var Stream = HttpContext.Request.Cookies["Token"];
            Guid IdUser = new Guid();
            var PagingModel = new PagingMusicClient();
            List<MusicGetAll_V> L_MusicSeach = new List<MusicGetAll_V>();
            if (Stream != null)
            {
                var hander = new JwtSecurityTokenHandler();
                var jsontoken = hander.ReadToken(Stream);
                var token = jsontoken as JwtSecurityToken;
                IdUser = Guid.Parse(token.Claims.FirstOrDefault(x => x.Type == "C_IdUser").Value);
                PagingModel.StatusCase = 1;
            }
            else
            {
                PagingModel.StatusCase = 2;
            }
            var result = await context.GetMusicClient(IdUser);
            switch (S_Viewer)
            {
                case 1:
                    if(S_Seach != null)
                    {
                        L_MusicSeach = result.Where(x => x.NameMusic.Contains(S_Seach)).ToList();
                        //seach name muisc
                        PagingModel.L_MusicClient = L_MusicSeach.OrderBy(x => x.NameMusic).Skip((PageIndex - 1) * PageSize)
                                                                                .Take(PageSize).ToList();
                        //Seach Author muisc
                        if(PagingModel.L_MusicClient.Count() == 0)
                        {
                            L_MusicSeach = result.Where(x => x.Author.Contains(S_Seach)).ToList();
                            PagingModel.L_MusicClient = L_MusicSeach.OrderBy(x => x.NameMusic).Skip((PageIndex - 1) * PageSize)
                                                                                .Take(PageSize).ToList();
                            PagingModel.TotalMusic = L_MusicSeach.Count();
                        }
                        else
                        {
                            PagingModel.TotalMusic = L_MusicSeach.Count();
                        }
                    }
                    else
                    {
                        if (S_Season == 0)
                        {
                            PagingModel.L_MusicClient = result.OrderBy(x => x.NameMusic).Skip((PageIndex - 1) * PageSize)
                                                                                                    .Take(PageSize).ToList();
                            PagingModel.TotalMusic = result.Where(x => x.IdSeason == S_Season).Count();
                        }
                        else
                        {
                            if (S_Saint != 0)
                            {
                                PagingModel.L_MusicClient = result.OrderBy(x => x.NameMusic).Where(x => x.IdSeason == S_Season
                                                                                                            && x.IdSaint == S_Saint)
                                               .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                                PagingModel.TotalMusic = result.Where(x => x.IdSeason == S_Season && x.IdSaint == S_Saint).Count();
                            }
                            else
                            {
                                PagingModel.L_MusicClient = result.OrderBy(x => x.NameMusic).Where(x => x.IdSeason == S_Season)
                                                .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                                PagingModel.TotalMusic = result.Where(x => x.IdSeason == S_Season).Count();
                            }
                        }
                    }                  
                    break;
                case 2:
                    if(S_Seach != null)
                    {
                        L_MusicSeach = result.Where(x => x.NameMusic.Contains(S_Seach)).ToList();
                        //seach name muisc
                        PagingModel.L_MusicClient = L_MusicSeach.OrderByDescending(x => x.NameMusic).Skip((PageIndex - 1) * PageSize)
                                                                                     .Take(PageSize).ToList();
                        //seach author muisc
                        if(PagingModel.L_MusicClient.Count() == 0)
                        {
                            L_MusicSeach = result.Where(x => x.Author.Contains(S_Seach)).ToList();
                            PagingModel.L_MusicClient = L_MusicSeach.OrderByDescending(x => x.NameMusic).Skip((PageIndex - 1) * PageSize)
                                                                                     .Take(PageSize).ToList();
                            PagingModel.TotalMusic = L_MusicSeach.Count();
                        }
                        else
                        {
                            PagingModel.TotalMusic = L_MusicSeach.Count();
                        }                        
                    }
                    else
                    {
                        if (S_Season == 0)
                        {
                            PagingModel.L_MusicClient = result.OrderByDescending(x => x.NameMusic).Skip((PageIndex - 1) * PageSize)
                                                                                                            .Take(PageSize).ToList();
                            PagingModel.TotalMusic = result.Where(x => x.IdSeason == S_Season).Count();
                        }
                        else
                        {
                            if (S_Saint != 0)
                            {
                                PagingModel.L_MusicClient = result.OrderByDescending(x => x.NameMusic).Where(x => x.IdSeason == S_Season
                                                                                                            && x.IdSaint == S_Saint)
                                               .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                                PagingModel.TotalMusic = result.Where(x => x.IdSeason == S_Season && x.IdSaint == S_Saint).Count();
                            }
                            else
                            {
                                PagingModel.L_MusicClient = result.OrderByDescending(x => x.NameMusic).Where(x => x.IdSeason == S_Season)
                                                .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                                PagingModel.TotalMusic = result.Where(x => x.IdSeason == S_Season).Count();
                            }
                        }
                    }
                    break;
                default:
                    if(S_Seach != null)
                    {
                        L_MusicSeach = result.Where(x => x.NameMusic.Contains(S_Seach)).ToList();
                        //seach name muisc
                        PagingModel.L_MusicClient = L_MusicSeach.Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                        //seach author music
                        if(PagingModel.L_MusicClient.Count() == 0)
                        {
                            L_MusicSeach = result.Where(x => x.Author.Contains(S_Seach)).ToList();
                            PagingModel.L_MusicClient = L_MusicSeach.Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                            PagingModel.TotalMusic = L_MusicSeach.Count();
                        }
                        else
                        {
                            PagingModel.TotalMusic = L_MusicSeach.Count();
                        }
                    }
                    else
                    {
                        if (S_Season == 0)
                        {
                            PagingModel.L_MusicClient = result.Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                            PagingModel.TotalMusic = result.Count();
                        }
                        else
                        {
                            if (S_Saint != 0)
                            {
                                PagingModel.L_MusicClient = result.Where(x => x.IdSeason == S_Season && x.IdSaint == S_Saint)
                                               .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                                PagingModel.TotalMusic = result.Where(x => x.IdSeason == S_Season && x.IdSaint == S_Saint).Count();
                            }
                            else
                            {
                                PagingModel.L_MusicClient = result.Where(x => x.IdSeason == S_Season)
                                                .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                                PagingModel.TotalMusic = result.Where(x => x.IdSeason == S_Season).Count();
                            }
                        }
                    }                
                    break;
            }
            return new JsonResult(PagingModel);
        }

        //plus like for music by id user
        [HttpPost]
        public async Task<IActionResult> PlusLikeMusic(Guid IdMuisc)
        {
            var Stream = HttpContext.Request.Cookies["Token"];
            var hander = new JwtSecurityTokenHandler();
            var jsontoken = hander.ReadToken(Stream);
            var token = jsontoken as JwtSecurityToken;
            Guid IdUser = Guid.Parse(token.Claims.FirstOrDefault(x => x.Type == "C_IdUser").Value);
            var result = await context.PlusLikeMuiscIdUser(IdMuisc, IdUser);
            return new JsonResult(result);
        }

        //detail muisc
        [HttpGet]
        public IActionResult PageDetailMuisc(Guid IdMusic)
        {
            ViewBag.IdMuisc = IdMusic;
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> DetailMuiscClient(Guid IdMuisc)
        {
            var result = await context.DetailMuiscClient(IdMuisc);
            return new JsonResult(result);
        }

        [HttpGet]
        public async Task<FileResult> DisplayPDFMusic(Guid IdMuisc_PDF)
        {
            var result = await context.DisplayPDF(IdMuisc_PDF);
            return File(result, "application/pdf");
        }

        //dowload file pdf
        [HttpGet]
        public async Task<FileResult> DowloadPdfClient(Guid IdMuisc)
        {
            var Stream = HttpContext.Request.Cookies["Token"];
            Guid IdUser = new Guid();
            if (Stream != null)
            {
                var hander = new JwtSecurityTokenHandler();
                var jsontoken = hander.ReadToken(Stream);
                var token = jsontoken as JwtSecurityToken;
                IdUser = Guid.Parse(token.Claims.FirstOrDefault(x => x.Type == "C_IdUser").Value);
            }
            var result = await context.DowloadMusicPDFfile(IdMuisc, IdUser);
            return File(result.DataContent, result.MineType);
        }

        //load comment muisc by id muisc
        public static string GetTokenLogin;
        [HttpGet]
        public async Task<IActionResult> GetCommentByIdMuisc(Guid IdMuisc)
        {
            var Stream = HttpContext.Request.Cookies["Token"];
            var resultS = new CommentMuisc();
            if (Stream != null)
            {
                var hander = new JwtSecurityTokenHandler();
                var jsontoken = hander.ReadToken(Stream);
                var token = jsontoken as JwtSecurityToken;
                Guid IdUser = Guid.Parse(token.Claims.FirstOrDefault(x => x.Type == "C_IdUser").Value);
                resultS.UserStatus = 1; //was login user
                GetTokenLogin = Stream;
            }
            else
            {
                resultS.UserStatus = 0; //not login user
            }
            var result = await context.GetCommentMuiscByIdMuisc(IdMuisc);
            resultS.L_CommentMuisc = result;
            resultS.TotalComment = result.Count();
            return new JsonResult(resultS);
        }

        //load rating muisc by id
        [HttpGet]
        public async Task<IActionResult> GetRatingByIdMuisc(Guid IdMuisc)
        {
            var Stream = HttpContext.Request.Cookies["Token"];
            var resultS = new RatingMuisc();
            if (Stream != null)
            {
                var hander = new JwtSecurityTokenHandler();
                var jsontoken = hander.ReadToken(Stream);
                var token = jsontoken as JwtSecurityToken;
                Guid IdUser = Guid.Parse(token.Claims.FirstOrDefault(x => x.Type == "C_IdUser").Value);
                resultS.StatusUser = 1; //was login user
                GetTokenLogin = Stream;
            }
            else
            {
                resultS.StatusUser = 0; //not login user
            }
            resultS.L_Rating = await context.GetRatingMuiscByIdMuisc(IdMuisc);
            resultS.TotalRating = resultS.L_Rating.Count();
            return new JsonResult(resultS);
        }

        // view all rating muisc by id music
        [HttpGet]
        public async Task<IActionResult> ViewAllRatingMuiscById(Guid IdMuisc)
        {
            var result = await context.ViewRatingMuiscById(IdMuisc);
            return new JsonResult(result);
        }

        // Create QRcore for muisc detail by id
        [HttpGet]
        public IActionResult CreateQRcoreMuisc(Guid IdMuisc)
        {
            var GetUrl = confi["UrlDetailMusicClient"];
            var QRcodeText = GetUrl + IdMuisc;
            QRCodeGenerator QrGenerator = new QRCodeGenerator();
            QRCodeData QrCodeInfo = QrGenerator.CreateQrCode(QRcodeText, QRCodeGenerator.ECCLevel.Q);
            QRCode QrCode = new QRCode(QrCodeInfo);
            Bitmap QrBitmap = QrCode.GetGraphic(60);
            byte[] BitmapArray = QrBitmap.BitmapToByteArray();
            string QrUri = string.Format("data:image/png;base64,{0}", Convert.ToBase64String(BitmapArray));
            return new JsonResult(QrUri);
        }

        //get all season client music
        [HttpGet]
        public async Task<IActionResult> GetAllSeasonMusic()
        {
            var result = await context_Season.GetAllSeason();
            return new JsonResult(result);
        }
        
        //get all saint client muisc
        [HttpGet]
        public async Task<IActionResult> GetAllSaintMuisc(int TypeValue)
        {
            var result = await context_Saint.GetAllSaintClient();
            List<GetSaintAll_V> L_Saint = new List<GetSaintAll_V>();
            if(TypeValue == 6)
            {
                L_Saint = result.Where(x => x.Id != 8).OrderByDescending(x => x.Name).ToList();
            }
            else
            {
                L_Saint = result.Where(x => x.Id == 8).OrderByDescending(x => x.Name).ToList();
            }
            return new JsonResult(L_Saint);
        }

        //get total muisc yesterday
        [HttpGet]
        public IActionResult TotalMuiscYesterday()
        {
            var resutl = context.TotalMuiscYesterday();
            return new JsonResult(resutl);
        }
    }

    //Extension method to convert Bitmap to Byte Array_______________________________________________________________
    public static class BitmapExtension
    {
        public static byte[] BitmapToByteArray(this Bitmap bitmap)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                bitmap.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }
    }
}
