using DataApplication.ApplicationAdmin.ApplicationRequestUser.RequestUser_app;
using DataApplication.ApplicationAdmin.ApplicationStaff.Staff_App;
using DataViewModel.ViewModelAdmin.RequestUser_Vm;
using ManagerMusic.Models.EmailFile;
using ManagerMusic.Models.Paging.Page_RequestUser;
using ManagerMusic.Models.RequestUsers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
    public class ManagerRequestUserController : Controller
    {
        private readonly IrequestUser_App context;
        private readonly Istaff_app ConverFile;
        public ManagerRequestUserController(IrequestUser_App _context, Istaff_app _ConverFile)
        {
            context = _context;
            ConverFile = _ConverFile;
        }

        //page manager request user
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public IActionResult Page_ManagerRequestUser()
        {
            return View();
        }

        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public async Task<IActionResult> JsonManagerRequestUser(int Page, int Size, int Selecter)
        {
            var result = await context.GetAllRequestUser_Notresolved(Selecter);
            var PagingModel = new PagingRequestUser();
            PagingModel.L_RequestUser = result.Skip((Page - 1) * Size).Take(Size).ToList();
            PagingModel.TotalRequestUser = result.Count();
            return new JsonResult(PagingModel);
        }

        //get all recevice user
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public async Task<IActionResult> JsonGetAllRevice()
        {
            var result = await context.GetAllReceiveUser();
            return new JsonResult(result);
        }

        //page detail request User
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public IActionResult Page_DetailRequestUser(int IdRequest)
        {
            ViewBag.IdRequest = IdRequest;
            return View();
        }

        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public async Task<IActionResult> JsonDetailRequestUser(int IdRequest)
        {
            var Result_Detail = await context.DetailRequestUser(IdRequest);
            var Result_Status = await context.GetAllStatusRequest();
            var ModalData = new ModalDetaiRequestUser()
            {
                DetailRequest_User = Result_Detail,
                L_StatusRequest = Result_Status
            };
            return new JsonResult(ModalData);
        }

        //accept request user
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpPost]
        public async Task<IActionResult> JsonAcceptRequestUser(int IdRequest, Guid IdUser, int TypeSent)
        {
            var result = await context.CacceptRequestUser(IdRequest, IdUser, TypeSent);
            return new JsonResult(result);
        }

        //Check Type Sent request user
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public async Task<IActionResult> JsonCheckTypeSentUser(int IdTypeSent)
        {
            var result = await context.CheckTypeSentRequestUser(IdTypeSent);
            return new JsonResult(result);
        }

        //Sent Gmail Request User
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpPost]
        public async Task<IActionResult> JsonSentGmailRequestUser(SaveFileEmailRequest request)
        {
            ContentAnswerSentRequestUser GetData = JsonConvert.DeserializeObject<ContentAnswerSentRequestUser>
                                                                            (request.ContentAnswerSentRequestUser);
            var Stream = HttpContext.Request.Cookies["Token"];
            var hander = new JwtSecurityTokenHandler();
            var jsontoken = hander.ReadToken(Stream);
            var token = jsontoken as JwtSecurityToken;
            GetData.IdStaff = token.Claims.FirstOrDefault(x => x.Type == "C_IdStaff").Value;
            GetData.DateSent = DateTime.UtcNow.AddHours(7);
            if (request.L_File.Count != 0)
            {
                foreach (var item in request.L_File)
                {
                    GetData.L_Files.Add(item);
                }
            }
            var result = await context.SentEmailRequestUser(GetData);
            return new JsonResult(result);
        }

        //Total request users
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public IActionResult JsonTotalRequestUser()
        {
            var result = context.TotalRequestUser();
            return new JsonResult(result);
        }

        //page manager progress request user
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public IActionResult Page_ProgressRequestUser()
        {
            return View();
        }

        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public async Task<IActionResult> JsonProgressRequestUser()
        {
            var result = await context.GetAllProgressRequestUser();
            var ModalData = new ModalProgressRequestUser();
            ModalData.L_Notresolved = result.OrderByDescending(x=>x.DateRequest).Where(x => x.IdRecener == 1).ToList();
            ModalData.L_Solving = result.OrderByDescending(x => x.DateHandled).Where(x => x.IdRecener == 2).ToList();
            ModalData.L_Solved = result.OrderByDescending(x => x.DateSuccessFull).Where(x => x.IdRecener == 3).ToList();
            return new JsonResult(ModalData);
        }

    }
}
