using DataApplication.ApplicationUser.ApplicationBuildSoftware.BuildSoftwareUser;
using DataViewModel.ViewModelUser.BuildSoftware_Vm;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

namespace ManagerMusic.Controllers
{
    public class BuildSoftwareController : Controller
    {
        private readonly IbuildSoftware_App context;
        public BuildSoftwareController(IbuildSoftware_App _context)
        {
            context = _context;
        }

        //page buildSoftware
        [HttpGet]
        public IActionResult PageBuildSoftware()
        {
            return View();
        }

        [HttpGet]
        public IActionResult JsonBuildSoftware()
        {
            var Stream = HttpContext.Request.Cookies["Token"];
            if (Stream != null)
            {
                var hander = new JwtSecurityTokenHandler();
                var jsontoken = hander.ReadToken(Stream);
                var token = jsontoken as JwtSecurityToken;
                // IdUser = Guid.Parse(token.Claims.FirstOrDefault(x => x.Type == "C_IdUser").Value);
                return new JsonResult(0);
            }
            else
            {
                return new JsonResult(1);
            }
        }

        //sent contribute user
        [HttpPost]
        public async Task<IActionResult> SentContributeUser(string Content)
        {
            var Stream = HttpContext.Request.Cookies["Token"];
            var hander = new JwtSecurityTokenHandler();
            var jsontoken = hander.ReadToken(Stream);
            var token = jsontoken as JwtSecurityToken;
            Guid IdUser = Guid.Parse(token.Claims.FirstOrDefault(x => x.Type == "C_IdUser").Value);

            var request = new SentContributeUser_V()
            {
                IdUser = IdUser,
                Content = Content,
                DateCreate = DateTime.UtcNow.AddHours(7)
            };
            var result = await context.SentContributeUser(request);
            return new JsonResult(result);
        }
    }
}
