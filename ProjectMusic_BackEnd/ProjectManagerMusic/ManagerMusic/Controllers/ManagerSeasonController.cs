using DataApplication.ApplicationAdmin.ApplicationSeason.Season_App;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;
using static DataUtilities.NameRoleSetting;

namespace ManagerMusic.Controllers
{
    [Authorize]
    public class ManagerSeasonController : Controller
    {
        private readonly ISeason_App _Context;
        public ManagerSeasonController(ISeason_App Context)
        {
            _Context = Context;
        }

        //get all season
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public IActionResult IndexSeason()
        {
            return View();
        }

        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public IActionResult JsonGetAllSeason(int PageIndex, int PageSize, int Sort_Id)
        {
            var result = _Context.GetAllSeason(PageSize, PageIndex, Sort_Id);
            return new JsonResult(result);
        }

        //get all status season
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public IActionResult JsonGetAllStatusSeason()
        {
            var result = _Context.GetAllStatusSeason();
            return new JsonResult(result);
        }

        //change Status season
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpPost]
        public async Task<IActionResult> JsonChangeStatusSeason(int IdSeason, int IdStatus)
        {
            var Stream = HttpContext.Request.Cookies["Token"];
            var hander = new JwtSecurityTokenHandler();
            var jsontoken = hander.ReadToken(Stream);
            var token = jsontoken as JwtSecurityToken;
            var NameUser = token.Claims.FirstOrDefault(x => x.Type == "C_FullName").Value;
            var result = await _Context.ChangeStatusSeason(IdSeason, IdStatus, NameUser);
            return new JsonResult(result);
        }

        //view list music by id season
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpPost]
        public IActionResult JsonListMusicByIdSeason(int PageSize, int PageIndex, int IdSeason, int Sort)
        {
            var result = _Context.ListMusicByIdSeason(PageIndex, PageSize, IdSeason, Sort);
            return new JsonResult(result);
        }

        //Get All Season Not paing
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public IActionResult JsonGetAllSeasonNotPaing()
        {
            var result = _Context.GetAllSeasonNotPaing();
            return new JsonResult(result);
        }
    }
}
