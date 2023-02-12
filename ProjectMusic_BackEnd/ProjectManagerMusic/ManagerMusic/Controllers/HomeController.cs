using DataApplication.ApplicationUser.ApplicationHome.HomeClient;
using DataApplication.ApplicationUser.ApplicationSignin.SignInUser;
using DataViewModel.ViewModelUser.LoginAndRegiter_Vm;
using DataViewModel.ViewModelUser.Muisc_Vm;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagerMusic.Controllers
{
    public class HomeController : Controller
    {
        private readonly IuserLogin_App ServiceLogin;
        private readonly IhomeClient_App context;
        public HomeController(IuserLogin_App _ServiceLogin, IhomeClient_App _context)
        {
            ServiceLogin = _ServiceLogin;
            context = _context;
        }

        //public users
        public static List<GetUsers> L_User = new List<GetUsers>();
        //home page
        public IActionResult Index()
        {
            var GetUsers = ServiceLogin.Users();
            L_User = GetUsers;
            return View();
        }

        //get data for chart 
        [HttpGet]
        public async Task<IActionResult> GetDataForChart(int Year)
        {
            var result = await context.GetDataChartClient(Year);
            return new JsonResult(result);
        }

        //get total music in month
        [HttpGet]
        public IActionResult GetTotalMusicInMonth()
        {
            var result = context.GetTotalMuiscInMonth();
            return new JsonResult(result);
        }

        //get total music in month
        [HttpGet]
        public IActionResult GetTotalMusicLastMonth()
        {
            var result = context.GetTotalMuiscLastMonth();
            return new JsonResult(result);
        }

        //total dowload and up muisc
        [HttpGet]
        public IActionResult TotalDowloadAndUpMuisc()
        {
            var result = context.TotalUpandDownMusic();
            return new JsonResult(result);
        }

        //load music were download
        [HttpGet]
        public async Task<IActionResult> GetAllMusicDowload(int IdSeason, string SeachKey, int Flap)
        {
            var result = await context.GetAllMusicWereDowload();
            List<DowloadMusic_V> L_DowloadMusic = new List<DowloadMusic_V>();
            switch (Flap)
            {
                case 1:
                    L_DowloadMusic = result.Where(x => x.NameMuisc.Contains(SeachKey)).ToList();
                    break;
                case 2:
                    L_DowloadMusic = result.Where(x => x.IdSeason == IdSeason).ToList();
                    break;
                default:
                    L_DowloadMusic = result;
                    break;
            }
            return new JsonResult(L_DowloadMusic);
        }

        //detail muisc dowload by id muisc
        [HttpGet]
        public async Task<IActionResult> DetailMuiscDowload(Guid IdMuisc)
        {
            var result = await context.GetListMuiscById(IdMuisc);
            return new JsonResult(result);
        }

        //get total muisc by season
        [HttpGet]
        public async Task<IActionResult> GetTotalMusicBySeason()
        {
            var result = await context.GetTotalMusicBySeason();
            return new JsonResult(result);
        }

        //get music dowload more in month
        [HttpGet]
        public async Task<IActionResult> GetMuiscDowloadMoreMonth()
        {
            var result = await context.GetMusicDowloadMoreMonth();
            return new JsonResult(result);
        }

        //total user have account
        [HttpGet]
        public IActionResult GetTotalUserAccount()
        {
            var result = context.TotalUserHaveAccount();
            return new JsonResult(result);
        }

        //total rating and comment
        [HttpGet]
        public IActionResult TotalRatingAndComment()
        {
            var resutl = context.TotalRatingAndComment();
            return new JsonResult(resutl);
        }

        //Translation Language
        public IActionResult ChangeLanguage(string culture)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName,
                                    CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                                    new CookieOptions() { Expires = DateTimeOffset.UtcNow.AddHours(7).AddYears(1) });
            return Redirect(Request.Headers["Referer"].ToString());
        }



    }
}
