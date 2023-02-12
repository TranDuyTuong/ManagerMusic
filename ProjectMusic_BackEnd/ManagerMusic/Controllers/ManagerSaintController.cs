using DataApplication.ApplicationAdmin.ApplicationSaints.Saint_App;
using DataViewModel.ViewModelAdmin.Saint_Vm;
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
    public class ManagerSaintController : Controller
    {
        private readonly ISaint_App _Context;
        public ManagerSaintController(ISaint_App Context)
        {
            _Context = Context;
        }

        //get all saint
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public IActionResult IndexSaint()
        {
            return View();
        }

        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public IActionResult JsonGetAllSaint(int PageIndex, int PageSize, int sort, string Seach)
        {
            var result = _Context.GetAllSaint(PageIndex, PageSize, sort, Seach);
            return new JsonResult(result);
        }


        //get all saint json activer
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public IActionResult JsonGetAllSaintActiver()
        {
            var result = _Context.GetAllSaintActiver();
            if (result.Count() == 0)
            {
                return new JsonResult(0);
            }
            else
            {
                return new JsonResult(result);
            }
        }

        //create saint
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpPost]
        public async Task<IActionResult> JsonCreateSaint(CreateSaint_V request)
        {
            var Stream = HttpContext.Request.Cookies["Token"];
            var hander = new JwtSecurityTokenHandler();
            var jsontoken = hander.ReadToken(Stream);
            var token = jsontoken as JwtSecurityToken;
            request.FullName = token.Claims.FirstOrDefault(x => x.Type == "C_FullName").Value;
            request.IdUser = Guid.Parse(token.Claims.FirstOrDefault(x => x.Type == "C_IdUser").Value);
            request.IdStaff = token.Claims.FirstOrDefault(x => x.Type == "C_IdStaff").Value;
            request.TokenData = Stream;
            var result = await _Context.CreateNewSaint(request);
            return new JsonResult(result);
        }

        //get data update saint
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public async Task<IActionResult> JsonGetUpdateSaint(int IdSaint)
        {
            var result = await _Context.GetDataUpdateSaint(IdSaint);
            return new JsonResult(result);
        }

        // update saint
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpPost]
        public async Task<IActionResult> JsonUpdateSaint(string NameSaint, int IdSaint)
        {
            var result = new GetAllSaint_V();
            var Stream = HttpContext.Request.Cookies["Token"];
            var hander = new JwtSecurityTokenHandler();
            var jsontoken = hander.ReadToken(Stream);
            var token = jsontoken as JwtSecurityToken;
            string NameSatff = token.Claims.FirstOrDefault(x => x.Type == "C_FullName").Value;
            result.NameSaint = NameSaint;
            result.IdSaint = IdSaint;
            var results = await _Context.UpdateSaint(result, NameSatff);
            return new JsonResult(results);
        }

        //get all status saint
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public IActionResult JsonGetAllSatusSaint(int IdSaint)
        {
            var result = _Context.GetAllStatusSaint(IdSaint);
            return new JsonResult(result);
        }

        //Change Status saint
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpPost]
        public async Task<IActionResult> JsonChangeSatusSaint(int IdSaint, int IdStatus)
        {
            var result = new GetAllSaint_V();
            var Stream = HttpContext.Request.Cookies["Token"];
            var hander = new JwtSecurityTokenHandler();
            var jsontoken = hander.ReadToken(Stream);
            var token = jsontoken as JwtSecurityToken;
            string NameSatff = token.Claims.FirstOrDefault(x => x.Type == "C_FullName").Value;
            result.IdSaint = IdSaint;
            result.IdStatuSaint = IdStatus;
            var results = await _Context.ChangeStatusSaint(result, NameSatff);
            return new JsonResult(results);
        }

        //get all music by id saint
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public IActionResult JsonGetAllMusicByIdSaint(int IdSaint, int PageIndex, int PageSize, int sort)
        {
            var results = _Context.ListMusicById_Saint(IdSaint, PageIndex, PageSize, sort);
            return new JsonResult(results);
        }


    }
}
