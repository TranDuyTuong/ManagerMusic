using DataApplication.ApplicationAdmin.ApplicationPlans.Plan_app;
using DataApplication.ApplicationAdmin.ApplicationStaff.Staff_App;
using DataViewModel.ViewModelAdmin.Plan_Vm;
using ManagerMusic.Models.Paging.Page_Plans;
using ManagerMusic.Models.Plans;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;
using static DataUtilities.NameRoleSetting;
using DataViewModel.ViewModelAdmin.ConverFile_Vm;
using Newtonsoft.Json;

namespace ManagerMusic.Controllers
{
    [Authorize]
    public class ManagerPlansController : Controller
    {
        private readonly Iplan_App Context;
        private readonly Istaff_app context_Staff;
        public ManagerPlansController(Iplan_App _Context, Istaff_app _context_Staff)
        {
            Context = _Context;
            context_Staff = _context_Staff;
        }

        //get all plans by Role 
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public IActionResult Page_Plans()
        {
            L_PlanFileUpdate = new List<CreatePlanFile_V>();
            ViewBag.IdUser = GetGuidCurrentUserLogin();
            return View();
        }

        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public async Task<IActionResult> GetAllPlansByIdUser(Guid IdUser, int PageIndex, 
                                                             int PageSize, string DateCreate, 
                                                             string DateCompelete, int IdStatus)
        {
            var result_Data = new GetAllPlans_V();
            result_Data = await Context.GetAllPlanByIdUser(IdUser);
            List<List_getAllPlans_V> L_PlanPading = new List<List_getAllPlans_V>();
            if(IdStatus != 0)
            {
                var L_PlanStatus = result_Data.L_Plans.Where(x => x.IdStatus == IdStatus).ToList();
                L_PlanPading = L_PlanStatus.OrderByDescending(x => x.IdPlan)
                                    .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
            }
            else
            {
                if (DateCreate != null)
                {
                    string[] StrDate = DateCreate.Split(" to ");
                    DateTime DateTime_1 = Convert.ToDateTime(StrDate[0]);
                    DateTime DateTime_2 = Convert.ToDateTime(StrDate[1]);
                    var L_DateCreate = result_Data.L_Plans.Where(x => x.DateCreatePlan.Date >= DateTime_1 && x.DateCreatePlan.Date <= DateTime_2).ToList();
                    L_PlanPading = L_DateCreate.OrderByDescending(x => x.IdPlan)
                                    .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                }
                else if (DateCompelete != null)
                {
                    string[] StrDate = DateCompelete.Split(" to ");
                    DateTime DateTime_1 = Convert.ToDateTime(StrDate[0]);
                    DateTime DateTime_2 = Convert.ToDateTime(StrDate[1]);
                    var L_DateCompelete = result_Data.L_Plans.Where(x => x.DateComplete.Date >= DateTime_1 && x.DateComplete.Date <= DateTime_2).ToList();
                    L_PlanPading = L_DateCompelete.OrderByDescending(x => x.IdPlan)
                                    .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                }
                else
                {
                    L_PlanPading = result_Data.L_Plans.OrderByDescending(x => x.IdPlan)
                                    .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                }
            }
            
            var Result = new Pading_Plan()
            {
                TotalPlan = result_Data.L_Plans.Count(),
                L_Plans = L_PlanPading,
                NameRole = result_Data.NameRole
            };
            return new JsonResult(Result);
        }

        //take plan by id user
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpPost]
        public async Task<IActionResult> TakePlansByIdUser(int IdPlan)
        {
            var result = new NotificationPlans_V();
            Guid IdUser = GetGuidCurrentUserLogin();
            result = await Context.TakePlanByIdUser(IdUser, IdPlan);
            return new JsonResult(result);
        }

        //page detail plan by id user
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public IActionResult Page_DetailPlan(int IdPlan)
        {
            ViewBag.IdPlan = IdPlan;
            return View();
        }

        //detail plan by id user
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public async Task<IActionResult> DetailPlanByIdUser(int IdPlan)
        {
            var result = new GetAllPlans_V();         
            Guid IdUser = GetGuidCurrentUserLogin();
            result = await Context.DetailPlanById(IdUser, IdPlan);
            return new JsonResult(result);
        }

        //cancel plan by id user
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpPost]
        public async Task<IActionResult> CancelPLanByIdUser(int IdPlan, string Content)
        {
            var result = new NotificationPlans_V();
            Guid IdUser = GetGuidCurrentUserLogin();
            result = await Context.CancelPlanByIdUser(IdUser, IdPlan, Content);
            return new JsonResult(result);
        }

        //get amount notification plans
        [Authorize(Roles = RoleSetting.symbolRole_Admin)]
        [HttpGet]
        public IActionResult AmountNotificationPlans()
        {
            Guid IdUser = GetGuidCurrentUserLogin();
            var result = Context.AmountNotificationPlans(IdUser);
            return new JsonResult(result);
        }

        //Update Plan by Admin
        [Authorize(Roles = RoleSetting.symbolRole_Admin)]
        [HttpGet]
        public async Task<IActionResult> UpdatePlanAdmin_Get(int IdPlan)
        {
            Guid IdUser = GetGuidCurrentUserLogin();
            var result = await Context.UpdatePlanByAdmin_Get(IdPlan, IdUser);
            return new JsonResult(result);
        }

        [Authorize(Roles = RoleSetting.symbolRole_Admin)]
        [HttpPost]
        public async Task<IActionResult> UpdatePlanAdmin_Post(int IdPlan, string TitlePlan, string ContentPlan)
        {
            var Result_Json = new NotificationPlans_V();
            Guid IdUser = GetGuidCurrentUserLogin();

            var result = new UpdatePlan_V();
            result.IdPlan = IdPlan;
            result.NamePlan = TitlePlan;
            result.ContentPlan = ContentPlan;
            if(L_PlanFileUpdate.Count() != 0)
            {
                result.L_FilePlans = L_PlanFileUpdate;
            }
            Result_Json = await Context.UpdatePlanByAdmin_Post(result, IdUser);
            return new JsonResult(Result_Json);
        }


        //Update File Plan by Admin
        private static List<CreatePlanFile_V> L_PlanFileUpdate = new List<CreatePlanFile_V>();
        [Authorize(Roles = RoleSetting.symbolRole_Admin)]
        [HttpPost]
        public async Task<IActionResult> UpdateFile_Plan(UpdateFile_Plan request)
        {
            var IpFile = JsonConvert.DeserializeObject<IdPlan>(request.IdPlan_Json);
            var FileName = request.FileUpdate.FileName;
            string[] StrSlip = FileName.Split('.');
            var ConverFile = new ConverFile();
            var result = new CreatePlanFile_V();
            result.NameFile = FileName;
            result.TypeFile = StrSlip[1];
            result.Id = IpFile.Id;
            result.DateCreate = DateTime.UtcNow.AddHours(7);
            result.DateCreate_Str = result.DateCreate.ToString("dd/MM/yyyy");
            switch (StrSlip[1])
            {
                case "pdf":
                    ConverFile = await context_Staff.ConverDataFile(request.FileUpdate);                  
                    result.MimeType = ConverFile.MineType;
                    result.ContentFile = ConverFile.ContentFile;
                    break;
                case "docx":
                    ConverFile = await context_Staff.ConverDataFile(request.FileUpdate);
                    result.MimeType = ConverFile.MineType;
                    result.ContentFile = ConverFile.ContentFile;
                    break;
                case "xlsx":
                    ConverFile = await context_Staff.ConverDataFile(request.FileUpdate);
                    result.MimeType = ConverFile.MineType;
                    result.ContentFile = ConverFile.ContentFile;
                    break;
                default:
                    return new JsonResult(result.Id = 0);
            }
            L_PlanFileUpdate.Add(result);
            return new JsonResult(result);
        }

        [Authorize(Roles = RoleSetting.symbolRole_Admin)]
        [HttpPost]
        public IActionResult CloseUpdateFile_Plan()
        {
            L_PlanFileUpdate = new List<CreatePlanFile_V>();
            return new JsonResult(true);
        }

        //Update Date and Time plan by Admin
        [Authorize(Roles = RoleSetting.symbolRole_Admin)]
        [HttpPost]
        public async Task<IActionResult> UpdateDateTimePlan(DateTime DateRequest, TimeSpan TimeRequest, int IdPlan)
        {
            var Result_Json = new NotificationPlans_V();
            Guid IdUser = GetGuidCurrentUserLogin();
            Result_Json = await Context.UpdateDateTimePlanByAdmin(DateRequest, TimeRequest, IdPlan, IdUser);
            return new JsonResult(Result_Json);
        }

        //get all staff for role plan
        [Authorize(Roles = RoleSetting.symbolRole_Admin)]
        [HttpGet]
        public async Task<IActionResult> GetAllStaffRolePlan(int PageIndex, int PageSize, string KeySeach, int IdPlan)
        {
            var modalPading = new Pading_UserRolePlan();
            var result = await Context.GetAllStaffRolePlan(IdPlan);
            if (KeySeach != null)
            {
                var GetZipCode_Staff = result.Where(x => x.IdStaff.Contains(KeySeach)).ToList();
                if(GetZipCode_Staff.Count() != 0)
                {
                    //seach zip code staff
                    modalPading.L_UserRolePlan = GetZipCode_Staff.OrderBy(x => x.FullName)
                                                        .Skip((PageIndex - 1) * PageSize).Take(PageSize);
                }
                else
                {
                    var GetName_Staff = result.Where(x => x.FullName.Contains(KeySeach)).ToList();
                    //seach zip code staff
                    modalPading.L_UserRolePlan = GetName_Staff.OrderBy(x => x.FullName)
                                                        .Skip((PageIndex - 1) * PageSize).Take(PageSize);
                }
            }
            else
            {
                modalPading.L_UserRolePlan = result.OrderBy(x => x.FullName).Skip((PageIndex - 1) * PageSize).Take(PageSize);
            }
            modalPading.TotalUser = result.Count();
            return new JsonResult(modalPading);
        }

        //get all staff for role plan
        [Authorize(Roles = RoleSetting.symbolRole_Admin)]
        [HttpPost]
        public async Task<IActionResult> UpdateRolePlanUser(int IdPlan, Guid Iduser)
        {
            var Result_Json = new NotificationPlans_V();
            Guid IdUserRequest = GetGuidCurrentUserLogin();
            Result_Json = await Context.UpdatePlanCurrentNewStaff(IdPlan, Iduser, IdUserRequest);
            return new JsonResult(Result_Json);
        }

        //was success plan by staff
        [Authorize(Roles = RoleSetting.symbolRole_Satff)]
        [HttpPost]
        public async Task<IActionResult> SuccessPlanByStaff(int IdPlan)
        {
            var result = new NotificationPlans_V();
            Guid IdUser = GetGuidCurrentUserLogin();
            result = await Context.SuccessPlanByStaff(IdPlan, IdUser);
            return new JsonResult(result);
        }

        //call Dowload file plan 
        private static CreatePlanFile_V FileDowloadPlan = new CreatePlanFile_V();
        [Authorize(Roles = RoleSetting.symbolRole_Satff + "," + RoleSetting.symbolRole_Admin)]
        [HttpGet]
        public async Task<IActionResult> CallDowloadFilePlan(int IdFile, int IdPlan)
        {
            var result = await Context.CallDowloadFilePlan(IdFile, IdPlan);
            if(result.Id != 0)
            {
                FileDowloadPlan = result;
                return new JsonResult(true);
            }
            else
            {
                return new JsonResult(false);
            }
        }

        //Dowload file plan
        [Authorize(Roles = RoleSetting.symbolRole_Satff + "," + RoleSetting.symbolRole_Admin)]
        [HttpGet]
        public FileResult DowloadFilePlan(int IdFile)
        {
            if(FileDowloadPlan.Id == IdFile)
            {
                var SaveName = FileDowloadPlan.NameFile;
                var SaveContent = FileDowloadPlan.ContentFile;
                var SaveMiniType = FileDowloadPlan.MimeType;
                FileDowloadPlan = new CreatePlanFile_V();
                return File(SaveContent, SaveMiniType, SaveName);
            }
            else
            {
                return null;
            }
        }

        //load get all plan was cancel
        [Authorize(Roles = RoleSetting.symbolRole_Admin)]
        [HttpGet]
        public IActionResult Page_PlansCancel()
        {
            return View();
        }

        [Authorize(Roles = RoleSetting.symbolRole_Admin)]
        [HttpGet]
        public async Task<IActionResult> GetAllNotificationPlanCancel(int PageIndex, int PageSize)
        {
            var result = new Pading_NotificationPlans();
            var GetL_Noti = await Context.GetAllNotificationPlanCancel();
            result.TotalNotification = GetL_Noti.Count();
            result.L_NotificationPlan = GetL_Noti.OrderByDescending(x=>x.Id).Skip((PageIndex - 1) * PageSize).Take(PageSize);
            return new JsonResult(result);
        }

        //Get All Status Plan
        [Authorize(Roles = RoleSetting.symbolRole_Admin)]
        [HttpGet]
        public async Task<IActionResult> GetAllStatusPlan()
        {
            var result = await Context.GetAllStatusPlans();
            return new JsonResult(result);
        }

        //Remove Plans
        [Authorize(Roles = RoleSetting.symbolRole_Admin)]
        [HttpPost]
        public async Task<IActionResult> ReomvePlan(int IdPlan)
        {
            var result = await Context.ReomvePlans(IdPlan);
            return new JsonResult(result);
        }

        //----------------------------------------------------
        private Guid GetGuidCurrentUserLogin()
        {
            var Stream = HttpContext.Request.Cookies["Token"];
            var hander = new JwtSecurityTokenHandler();
            var jsontoken = hander.ReadToken(Stream);
            var token = jsontoken as JwtSecurityToken;
            Guid IdUser = Guid.Parse(token.Claims.FirstOrDefault(x => x.Type == "C_IdUser").Value);
            return IdUser;
        }


    }
}
