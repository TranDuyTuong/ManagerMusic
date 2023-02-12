using DataApplication.ApplicationAdmin.ApplicationStaff.Staff_App;
using DataApplication.ApplicationUser.ApplicationSignin.SignInUser;
using DataViewModel.ViewModelUser.ReportBugClient_Vm;
using ManagerMusic.Models.ReportBugUser;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataViewModel.ViewModelAdmin.ConverFile_Vm;

namespace ManagerMusic.Controllers
{
    public class ReportBugClientController : Controller
    {
        private readonly IuserLogin_App context;
        private readonly Istaff_app ConverImge;
        public ReportBugClientController(IuserLogin_App _context, Istaff_app _ConverImge)
        {
            context = _context;
            ConverImge = _ConverImge;
        }

        //sent report bug login client user
        [HttpPost]
        public async Task<IActionResult> SentReportBugClient(ReportBugLoginClient request)
        {
            var RequestBug = JsonConvert.DeserializeObject<SentReportBugClient_V>(request.SentReportBugClient_V);
            var ConverFile = new ConverFile();
            ConverFile = await ConverImge.ConverDataFile(request.ImageBug);
            string[] SlipImage = request.ImageBug.FileName.Split('.');
            RequestBug.MineType = ConverFile.MineType;
            RequestBug.ImageBug = ConverFile.ContentFile;
            RequestBug.TypeImage = SlipImage[1];
            RequestBug.DateCreate = DateTime.UtcNow.AddHours(7);
            var result = await context.ReportBugClient(RequestBug);
            return new JsonResult(result);
        }

    }
}
