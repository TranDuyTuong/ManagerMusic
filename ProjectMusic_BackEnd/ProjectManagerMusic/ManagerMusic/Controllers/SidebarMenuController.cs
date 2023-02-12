using DataApplication.ApplicationAdmin.ApplicationPlans.Plan_app;
using DataApplication.ApplicationAdmin.ApplicationStaff.Staff_App;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

namespace ManagerMusic.Controllers
{
    public class SidebarMenuController : Controller
    {
        private readonly Istaff_app context_Staff;
        private readonly Iplan_App context_Plans;
        public SidebarMenuController(Istaff_app _context_Staff, Iplan_App _context_Plans)
        {
            context_Staff = _context_Staff;
            context_Plans = _context_Plans;
        }

        //Sidebar Menu
        [HttpGet]
        public IActionResult Index()
        {
            return PartialView();
        }

        //load total chat by id user login
        [HttpGet]
        public async Task<IActionResult> LoadTotalChatByIdUser()
        {
            var Stream = HttpContext.Request.Cookies["Token"];
            var hander = new JwtSecurityTokenHandler();
            var jsontoken = hander.ReadToken(Stream);
            var token = jsontoken as JwtSecurityToken;
            var result = await context_Staff.GetTotalChatByIdUser(Guid.Parse(token.Claims.FirstOrDefault(x => x.Type == "C_IdUser").Value));
            return new JsonResult(result);
        }

        //get amount plans by id User
        [HttpGet]
        public IActionResult AmountPlansByIdUser()
        {
            var Stream = HttpContext.Request.Cookies["Token"];
            var hander = new JwtSecurityTokenHandler();
            var jsontoken = hander.ReadToken(Stream);
            var token = jsontoken as JwtSecurityToken;
            Guid IdUser = Guid.Parse(token.Claims.FirstOrDefault(x => x.Type == "C_IdUser").Value);
            var result = context_Plans.AmountPlanByIdUser(IdUser);
            return new JsonResult(result);
        }

    }
}
