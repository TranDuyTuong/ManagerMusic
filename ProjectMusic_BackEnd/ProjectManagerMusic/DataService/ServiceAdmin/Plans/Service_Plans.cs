using DataMigration.DataEF;
using DataTable.Table.Staff;
using DataViewModel.ViewModelAdmin.Plan_Vm;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.ServiceAdmin.Plans
{
    public class Service_Plans : Iservice_Plans
    {
        private readonly ContextDB context;
        public Service_Plans(ContextDB _context)
        {
            context = _context;
        }

        //get amount by id user
        public int AmountPlanByIdUser(Guid Iduser)
        {
            int NumberPlan = 0;
            var QueryUser = context.T_Users.FirstOrDefault(x => x.IdUser == Iduser 
                                                        && x.IdStaff != null && x.IdAccountActiver == 1);
            if (QueryUser != null)
            {
                var QueryPlans = context.T_PlanStaffs.Where(x => x.IdUserPlan == QueryUser.IdUser
                                                                && x.IdStatusPlan == 0
                                                                && x.AcceptPlan == 0
                                                                && x.TimeUp == false).ToList();
                NumberPlan = QueryPlans.Count();
            }
            else
            {
                NumberPlan = 0;
            }
            return NumberPlan;
        }

        //get amount notification plans 
        public int AmountNotificationPlan(Guid IdUser)
        {
            int NumberPlan = 0;
            var QueryUser = context.T_Users.FirstOrDefault(x => x.IdUser == IdUser 
                                                        && x.IdStaff != null && x.IdAccountActiver == 1);
            if (QueryUser != null)
            {
                var QueryPlans = context.T_NotificationPlans.Where(x=>x.StatusView == false).ToList();
                NumberPlan = QueryPlans.Count();
            }
            else
            {
                NumberPlan = 0;
            }
            return NumberPlan;
        }

        //Get all plans by id user
        public async Task<GetAllPlans_V> GetAllPlansByIdUser(Guid IdUser)
        {
            var QueryAllUser = await context.T_Users.Where(x => x.IdStaff != null 
                                                    && x.IdAccountActiver == 1).ToListAsync();
            var Queryuser = QueryAllUser.FirstOrDefault(x => x.IdUser == IdUser && x.IdStaff != null);
            List<List_getAllPlans_V> L_Plans = new List<List_getAllPlans_V>();
            var result = new GetAllPlans_V();
            if (Queryuser != null)
            {
                CheckTimeUp();
                var QueryStatusPlan = await context.T_StatusPlans.ToListAsync();
                var QueryUserRole = await context.T_UserRoles.FirstOrDefaultAsync(x => x.IdUser == Queryuser.IdUser);
                var QueryRole = await context.T_Roles.FirstOrDefaultAsync(x => x.IdRole == QueryUserRole.IdRole);
                var QueryPlans = await context.T_PlanStaffs.ToListAsync();
                result.NameRole = QueryRole.SymbolRole;
                switch (QueryRole.SymbolRole)
                {
                    case "AD":
                        foreach (var item in QueryPlans.OrderByDescending(x => x.IdPlan))
                        {
                            var SetData = new List_getAllPlans_V()
                            {
                                IdPlan = item.IdPlan,
                                IdUserPlan = Queryuser.IdUser,
                                idUserRequest = item.IdUserRequest,
                                NameUserPlan = QueryAllUser.FirstOrDefault(x => x.IdUser == item.IdUserPlan).FullName,
                                NameUserRequest = QueryAllUser.FirstOrDefault(x => x.IdUser == item.IdUserRequest).FullName,
                                DateCreatePlan = item.DateCreate,
                                DateCreate_Str = item.DateCreate.ToString("dd/MM/yyyy"),
                                DateComplete = item.DateComplete,
                                DateComplete_Str = item.DateComplete.ToString("dd/MM/yyyy"),
                                TimeCompele = item.TimeComplete,
                                TitlePlan = item.NamePlan,
                                IdStatus = item.IdStatusPlan,
                                NameStatus = (item.IdStatusPlan != 0) ? QueryStatusPlan
                                                        .FirstOrDefault(x => x.IdStatusPlan == item.IdStatusPlan)
                                                            .NameStauts : "Null",
                                IdAcceptPlan = item.AcceptPlan,
                                TimeUp = item.TimeUp
                            };
                            L_Plans.Add(SetData);
                        }
                        break;
                    case "NV":
                        foreach (var item in QueryPlans.OrderByDescending(x => x.IdPlan)
                                                                .Where(X => X.IdUserPlan == Queryuser.IdUser 
                                                                            && X.TimeUp == false
                                                                            && X.AcceptPlan != 2))
                        {
                            var SetData = new List_getAllPlans_V()
                            {
                                IdPlan = item.IdPlan,
                                IdUserPlan = Queryuser.IdUser,
                                idUserRequest = item.IdUserRequest,
                                NameUserPlan = QueryAllUser.FirstOrDefault(x => x.IdUser == item.IdUserPlan).FullName,
                                NameUserRequest = QueryAllUser.FirstOrDefault(x => x.IdUser == item.IdUserRequest).FullName,
                                DateCreatePlan = item.DateCreate,
                                DateCreate_Str = item.DateCreate.ToString("dd/MM/yyyy"),
                                DateComplete = item.DateComplete,
                                DateComplete_Str = item.DateComplete.ToString("dd/MM/yyyy"),
                                TimeCompele = item.TimeComplete,
                                TitlePlan = item.NamePlan,
                                IdStatus = item.IdStatusPlan,
                                NameStatus = (item.IdStatusPlan != 0) ? QueryStatusPlan
                                                        .FirstOrDefault(x => x.IdStatusPlan == item.IdStatusPlan).NameStauts : "Null",
                                IdAcceptPlan = item.AcceptPlan,
                                TimeUp = item.TimeUp
                            };
                            L_Plans.Add(SetData);
                        }
                        break;
                    default:
                        return result;
                }
                result.L_Plans = L_Plans;
            }
            return result;
        }

        //take plan by id user
        public async Task<NotificationPlans_V> TakePlanByIdUser(Guid IdUser, int IdPlan)
        {
            var QueryUser = await context.T_Users.FirstOrDefaultAsync(x => x.IdUser == IdUser 
                                                                            && x.IdStaff != null 
                                                                                    && x.IdAccountActiver ==1);
            var result = new NotificationPlans_V();
            if (QueryUser != null)
            {
                var QueryPlan = await context.T_PlanStaffs
                                                .FirstOrDefaultAsync(x => x.IdPlan == IdPlan
                                                                    && x.IdUserPlan == IdUser
                                                                    && x.IdStatusPlan == 0
                                                                    && x.AcceptPlan == 0);
                if (QueryPlan != null)
                {
                    QueryPlan.AcceptPlan = 1;
                    QueryPlan.IdStatusPlan = 4;
                    context.T_PlanStaffs.Update(QueryPlan);
                    await context.SaveChangesAsync();
                    result.IdNotification = 2; // Take plan success
                    result.Status = true;
                }
                else
                {
                    result.IdNotification = 1; // not find plan by id 
                    result.Status = false;
                }
            }
            else
            {
                result.IdNotification = 0; // not find user
                result.Status = false;
            }
            return result;
        }

        //detail plan by id user
        public async Task<GetAllPlans_V> DetailPlanByIdUser(Guid IdUser, int IdPlan)
        {
            var QueryAllUser = await context.T_Users.Where(x => x.IdStaff != null && x.IdAccountActiver == 1).ToListAsync();
            var Queryuser = QueryAllUser.FirstOrDefault(x => x.IdUser == IdUser && x.IdStaff != null);
            var result = new GetAllPlans_V();
            if (Queryuser != null)
            {
                var QueryStatusPlan = await context.T_StatusPlans.ToListAsync();
                var QueryUserRole = await context.T_UserRoles.FirstOrDefaultAsync(x => x.IdUser == Queryuser.IdUser);
                var QueryRole = await context.T_Roles.FirstOrDefaultAsync(x => x.IdRole == QueryUserRole.IdRole);
                var QueryPlans = await context.T_PlanStaffs.ToListAsync();
                var QueryFilePlans = await context.T_FilePlans.ToListAsync();
                result.NameRole = QueryRole.SymbolRole;
                var GetData_Plan = QueryPlans.FirstOrDefault(x => x.IdPlan == IdPlan);
                if (GetData_Plan != null)
                {
                    //info plan by id plan
                    var SetData = new List_getAllPlans_V()
                    {
                        IdPlan = GetData_Plan.IdPlan,
                        IdUserPlan = Queryuser.IdUser,
                        idUserRequest = GetData_Plan.IdUserRequest,
                        NameUserPlan = QueryAllUser.FirstOrDefault(x => x.IdUser == GetData_Plan.IdUserPlan).FullName,
                        NameUserRequest = QueryAllUser.FirstOrDefault(x => x.IdUser == GetData_Plan.IdUserRequest).FullName,
                        DateCreatePlan = GetData_Plan.DateCreate,
                        DateCreate_Str = GetData_Plan.DateCreate.ToString("dd/MM/yyyy"),
                        DateComplete = GetData_Plan.DateComplete,
                        DateComplete_Str = GetData_Plan.DateComplete.ToString("dd/MM/yyyy"),
                        TimeCompele = GetData_Plan.TimeComplete,
                        TitlePlan = GetData_Plan.NamePlan,
                        IdStatus = GetData_Plan.IdStatusPlan,
                        NameStatus = (GetData_Plan.IdStatusPlan != 0) ? QueryStatusPlan
                            .FirstOrDefault(x => x.IdStatusPlan == GetData_Plan.IdStatusPlan).NameStauts : "Null",
                        IdAcceptPlan = GetData_Plan.AcceptPlan,
                        TimeUp = GetData_Plan.TimeUp,
                        ContentPlan = GetData_Plan.ContentPlan
                    };
                    result.DetailPlan = SetData;

                    //list file plan by id user
                    var L_FilePlans = QueryFilePlans.Where(x => x.IdPlan == GetData_Plan.IdPlan).ToList();
                    List<CreatePlanFile_V> L_FilePlan = new List<CreatePlanFile_V>();
                    foreach (var item in L_FilePlans)
                    {
                        var SetFile_Plan = new CreatePlanFile_V()
                        {
                            Id = item.IdFile,
                            IdPlan = item.IdPlan,
                            NameFile = item.NameFile,
                            TypeFile = item.TypeFile,
                            MimeType = item.MimeType,
                            ContentFile = item.ContentFile,
                            DateCreate = item.DateCreate,
                            DateCreate_Str = item.DateCreate.ToString("dd/MM/yyyy")
                        };
                        L_FilePlan.Add(SetFile_Plan);
                    }
                    result.DetailPlan.L_FilePlans = L_FilePlan;
                }
            }
            return result;
        }

        //cancel plan by id user
        public async Task<NotificationPlans_V> CancelPlanByIdUser(Guid IdUser, int IdPlan, string Content)
        {
            var result = new NotificationPlans_V();
            var QueryUser = await context.T_Users.FirstOrDefaultAsync(x => x.IdUser == IdUser && x.IdStaff != null);
            if(QueryUser != null)
            {
                var QueryPlan = await context.T_PlanStaffs.FirstOrDefaultAsync(x => x.IdPlan == IdPlan 
                                                                                    && x.AcceptPlan != 1 
                                                                                        && x.TimeUp == false);
                
                if(QueryPlan != null)
                {
                    QueryPlan.AcceptPlan = 2;
                    context.T_PlanStaffs.Update(QueryPlan);
                    //add notification
                    var Create_Notifi = new T_NotificationPlan()
                    {
                        IdPlan = QueryPlan.IdPlan,
                        IdUser = QueryUser.IdUser,
                        DateCreate = DateTime.UtcNow.AddHours(7),
                        Content = Content,
                        StatusView = false
                    };
                    await context.AddAsync(Create_Notifi);

                    await context.SaveChangesAsync();
                    result.IdNotification = 2; //cancel success plan
                    result.Status = true;
                }
                else
                {
                    result.IdNotification = 1; //Not find plan
                    result.Status = false;
                }
            }
            else
            {
                result.IdNotification = 0; //not find user
                result.Status = false;
            }
            return result;
        }
    
        //update plan by admin get
        public async Task<UpdatePlan_V> UpdatePlanByAdmin(int IdPlan, Guid IdUser)
        {
            var QueryPlan = await context.T_PlanStaffs.FirstOrDefaultAsync(x => x.IdPlan == IdPlan);
            var QueryUser = await context.T_Users.FirstOrDefaultAsync(x => x.IdUser == IdUser 
                                                                                && x.IdStaff != null 
                                                                                        && x.IdAccountActiver == 1);
            var QueryPlanFile = await context.T_FilePlans.Where(x => x.IdPlan == QueryPlan.IdPlan).ToListAsync();
            var result = new UpdatePlan_V();
            if(QueryPlan == null || QueryUser == null)
            {
                return result;
            }
            else
            {
                List<CreatePlanFile_V> L_FilePlans = new List<CreatePlanFile_V>();
                foreach(var item in QueryPlanFile)
                {
                    var Setfile = new CreatePlanFile_V()
                    {
                        Id = item.IdFile,
                        IdPlan = item.IdPlan,
                        TypeFile = item.TypeFile,
                        NameFile = item.NameFile,
                        MimeType = item.MimeType,
                        ContentFile = item.ContentFile,
                        DateCreate = item.DateCreate,
                        DateCreate_Str = item.DateCreate.ToString("dd/MM/yyyy")
                    };
                    L_FilePlans.Add(Setfile);
                }
                result.IdPlan = QueryPlan.IdPlan;
                result.NamePlan = QueryPlan.NamePlan;
                result.ContentPlan = QueryPlan.ContentPlan;
                result.DateCreate = QueryPlan.DateCreate.ToString("dd/MM/yyyy");
                result.L_FilePlans = L_FilePlans;
            }
            return result;
        }

        //update plan by admin post
        public async Task<NotificationPlans_V> UpdatePlanByAdmin_Post(UpdatePlan_V request, Guid IdUser)
        {
            var result = new NotificationPlans_V();
            var QueryUser = await context.T_Users.FirstOrDefaultAsync(x => x.IdUser == IdUser 
                                                                            && x.IdStaff != null 
                                                                                    && x.IdAccountActiver == 1);
            if(QueryUser == null)
            {
                result.IdNotification = 3; //not find user
                result.Status = false;
            }
            else
            {
                var QueryUserRole = await context.T_UserRoles.FirstOrDefaultAsync(x => x.IdUser == QueryUser.IdUser);
                var QueryRole = await context.T_Roles.FirstOrDefaultAsync(x => x.IdRole == QueryUserRole.IdRole 
                                                                                && x.SymbolRole == "AD");
                if(QueryRole == null)
                {
                    result.IdNotification = 4; //Role user ivalite
                    result.Status = false;
                }
                else
                {
                    var QueryPlan = await context.T_PlanStaffs.FirstOrDefaultAsync(x => x.IdPlan == request.IdPlan);
                    var QueryFilePlan = await context.T_FilePlans.ToListAsync();
                    if (QueryPlan != null)
                    {
                        QueryPlan.NamePlan = request.NamePlan;
                        QueryPlan.ContentPlan = request.ContentPlan;
                        QueryPlan.DateCreate = DateTime.UtcNow.AddHours(7);
                        context.T_PlanStaffs.Update(QueryPlan);
                        if (request.L_FilePlans.Count() != 0)
                        {
                            foreach (var item in request.L_FilePlans)
                            {
                                var CheckFile = QueryFilePlan.FirstOrDefault(x => x.IdFile == item.Id);
                                if (CheckFile != null)
                                {
                                    CheckFile.NameFile = item.NameFile;
                                    CheckFile.ContentFile = item.ContentFile;
                                    CheckFile.TypeFile = item.TypeFile;
                                    CheckFile.MimeType = item.MimeType;
                                    CheckFile.DateCreate = item.DateCreate;
                                    context.T_FilePlans.Update(CheckFile);
                                }
                            }
                        }
                        context.SaveChanges();
                        result.IdNotification = 1; //update plan success;
                        result.Status = true;
                    }
                    else
                    {
                        result.IdNotification = 0; //not find plan by this id
                        result.Status = false;
                    }
                }
            }
            return result;
        }

        //Update Date and Time by Admin
        public async Task<NotificationPlans_V> UpdateDateTimePlanByAdmin(DateTime DateRequest, TimeSpan TimeRequest, 
                                                                                            int IdPlan, Guid IdUser)
        {
            var result = new NotificationPlans_V();
            var QueryPlan = await context.T_PlanStaffs.FirstOrDefaultAsync(x => x.IdPlan == IdPlan);
            if(QueryPlan == null)
            {
                result.IdNotification = 0; // not find plan
                result.Status = false;
            }
            else
            {
                var QueryUser = await context.T_Users.FirstOrDefaultAsync(x => x.IdUser == IdUser 
                                                                            && x.IdStaff != null 
                                                                                && x.IdAccountActiver ==1);
                if(QueryUser == null)
                {
                    result.IdNotification = 1; //not find user
                    result.Status = false;
                }
                else
                {
                    if(DateRequest <= DateTime.UtcNow.AddHours(7).Date)
                    {
                        result.IdNotification = 2; //date request small current date
                        result.Status = false;
                    }
                    else
                    {
                        //update plan time and date
                        QueryPlan.TimeComplete = TimeRequest;
                        QueryPlan.DateComplete = DateRequest;
                        QueryPlan.TimeUp = false;
                        QueryPlan.IdStatusPlan = 0;
                        QueryPlan.AcceptPlan = 0;
                        context.T_PlanStaffs.Update(QueryPlan);
                        await context.SaveChangesAsync();

                        result.IdNotification = 3; //update date and time success
                        result.Status = true;
                    }
                }
            }
            return result;
        }

        //get all staff for role plan
        public async Task<List<GetAllUserRolePlan_V>> GetAllStaffRolePlan(int IdPlan)
        {
            var QueryUser = await context.T_Users.Where(x => x.IdStaff != null && x.IdAccountActiver == 1).ToListAsync();
            var QueryUserRole = await context.T_UserRoles.ToListAsync();
            var QueryRole = await context.T_Roles.ToListAsync();
            var QueryPlan = await context.T_PlanStaffs.ToListAsync();
            List<GetAllUserRolePlan_V> L_User = new List<GetAllUserRolePlan_V>();
            foreach(var item_User in QueryUser)
            {
                var CheckUserRole = QueryUserRole.FirstOrDefault(x => x.IdUser == item_User.IdUser);
                var CheckRole = QueryRole.FirstOrDefault(x => x.IdRole == CheckUserRole.IdRole);
                var CheckL_Plan = QueryPlan.Where(x => x.IdUserPlan == item_User.IdUser && x.IdStatusPlan == 4).ToList();
                var CheckUser_Plan = QueryPlan.FirstOrDefault(x => x.IdPlan == IdPlan && x.IdUserPlan == item_User.IdUser);
                if(CheckRole.SymbolRole == "NV")
                {
                    var result = new GetAllUserRolePlan_V()
                    {
                        IdUser = item_User.IdUser,
                        IdStaff = item_User.IdStaff,
                        FullName = item_User.FullName,
                        RoleName = CheckRole.Name,
                        Avata = item_User.ImageAvata,
                        TypeImage = item_User.TypeImage,
                        TotalPlanCurrent = CheckL_Plan.Count(),
                        UserCurrentPlan = (CheckUser_Plan != null)? true : false
                    };
                    L_User.Add(result);
                }
            }
            return L_User;
        }

        //update user plan current by admin
        public async Task<NotificationPlans_V> UpdateUserCurrentPlan(int IdPlan, Guid IdUser, Guid IdUserRequest)
        {
            var result = new NotificationPlans_V();
            var QueryPlan = await context.T_PlanStaffs.FirstOrDefaultAsync(x => x.IdPlan == IdPlan);
            var QueryUser_L = await context.T_Users.Where(x => x.IdStaff != null && x.IdAccountActiver == 1).ToListAsync();
            var QueryUserRole_L = await context.T_UserRoles.ToListAsync();
            var QueryRole_L = await context.T_Roles.ToListAsync();
            var QueryNotificationPlanCancel = await context.T_NotificationPlans
                                .Where(x => x.IdPlan == QueryPlan.IdPlan).ToListAsync();

            if (QueryPlan == null)
            {
                result.IdNotification = 0; //Not find plan
                result.Status = false;
            }
            else
            {
                var QueryUser = QueryUser_L.FirstOrDefault(x => x.IdUser == IdUser && x.IdStaff != null);
                var QueryAdmin = QueryUser_L.FirstOrDefault(x => x.IdUser == IdUserRequest && x.IdStaff != null);
                if (QueryUser == null || QueryAdmin == null)
                {
                    result.IdNotification = 1; //Not find User
                    result.Status = false;
                }
                else
                {
                    var CheckRoleAdmin = QueryUserRole_L.FirstOrDefault(x => x.IdUser == QueryAdmin.IdUser);
                    var CheckRole = QueryRole_L.FirstOrDefault(x => x.IdRole == CheckRoleAdmin.IdRole && x.SymbolRole == "AD");
                    if(CheckRole == null)
                    {
                        result.IdNotification = 2; //User request not role admin
                        result.Status = false;
                    }
                    else
                    {
                        if (QueryPlan.TimeUp == true)
                        {
                            result.IdNotification = 3; // plan was time up not role plan for user
                            result.Status = false;
                        }
                        else
                        {
                            //remove notification plan cancel
                            foreach (var item in QueryNotificationPlanCancel)
                            {
                                context.T_NotificationPlans.Remove(item);
                            }
                            QueryPlan.IdUserPlan = QueryUser.IdUser;
                            QueryPlan.IdUserRequest = QueryAdmin.IdUser;
                            context.T_PlanStaffs.Update(QueryPlan);
                            await context.SaveChangesAsync();

                            result.IdNotification = 4; // Update plan current for new staff success
                            result.Status = true;
                        }
                    }
                }
            }
            return result;
        }

        //success plan by staff
        public async Task<NotificationPlans_V> SuccessPlanByStaff(int IdPlan, Guid IdUser)
        {
            var result = new NotificationPlans_V();
            var QueryPlan = await context.T_PlanStaffs.FirstOrDefaultAsync(x => x.IdPlan == IdPlan && x.IdUserPlan == IdUser
                                                                && x.TimeUp == false && x.AcceptPlan == 1);
            if(QueryPlan == null)
            {
                result.IdNotification = 0; //not find plan by this id
                result.Status = false;
            }
            else
            {
                QueryPlan.IdStatusPlan = 1;
                context.T_PlanStaffs.Update(QueryPlan);
                await context.SaveChangesAsync();

                result.IdNotification = 1; // success plan success
                result.Status = true;
            }
            return result;
        }

        //call dowload file plan
        public async Task<CreatePlanFile_V> CallDowloadFilePlan(int IdFile, int IdPlan)
        {
            var QueryFile = await context.T_FilePlans.FirstOrDefaultAsync(x => x.IdFile == IdFile && x.IdPlan == IdPlan);
            var result = new CreatePlanFile_V();
            result.Id = QueryFile.IdFile;
            result.IdPlan = QueryFile.IdPlan;
            result.TypeFile = QueryFile.TypeFile;
            result.NameFile = QueryFile.NameFile;
            result.MimeType = QueryFile.MimeType;
            result.ContentFile = QueryFile.ContentFile;
            return result;
        }

        //get all notification plan cancel
        public async Task<List<GetAllNotificationPlan_V>> GetAllNotificationPlan()
        {
            var QueryAllUser = await context.T_Users.Where(x => x.IdAccountActiver == 1).ToListAsync();
            var QueryPlan = await context.T_PlanStaffs.ToListAsync();
            var QueryNotificationPlan = GetAllNotificationPlanCancel();
            //update
            foreach (var item in QueryNotificationPlan)
            {
                if (item.StatusView == false)
                {
                    item.StatusView = true;
                    context.T_NotificationPlans.Update(item);
                }
            }
            await context.SaveChangesAsync();

            // add list
            QueryNotificationPlan = GetAllNotificationPlanCancel();
            List<GetAllNotificationPlan_V> L_NotificationPlan = new List<GetAllNotificationPlan_V>();
            foreach (var item in QueryNotificationPlan)
            {
                var CheckPlan = QueryPlan.FirstOrDefault(x => x.IdPlan == item.IdPlan);
                var CheckUserPlan = QueryAllUser.FirstOrDefault(x => x.IdUser == CheckPlan.IdUserPlan && x.IdStaff != null);
                var CheckUserRequest = QueryAllUser.FirstOrDefault(x => x.IdUser == CheckPlan.IdUserRequest && x.IdStaff != null);
                var result = new GetAllNotificationPlan_V()
                {
                    Id = item.Id,
                    IdPlan = item.IdPlan,
                    IdUserPlan = CheckUserPlan.IdUser,
                    NameUserPlan = CheckUserPlan.FullName,
                    IdUserRequest = CheckUserRequest.IdUser,
                    NameUserRequest = CheckUserRequest.FullName,
                    ContentCancel = item.Content,
                    DateCreate = item.DateCreate,
                    DateCreate_Str = item.DateCreate.ToString("dd/MM/yyyy")
                };
                L_NotificationPlan.Add(result);
            }
            return L_NotificationPlan;
        }



        //Check Time Up plan ---------------------------------------
        private bool CheckTimeUp()
        {
            var QueryPlans = context.T_PlanStaffs.Where(x => x.TimeUp == false).ToList();
            foreach (var item in QueryPlans)
            {
                DateTime SetTimeCheck = item.DateComplete + item.TimeComplete;
                if (SetTimeCheck < DateTime.UtcNow.AddHours(7))
                {
                    item.TimeUp = true;
                    if(item.IdStatusPlan == 4)
                    {
                        item.IdStatusPlan = 5;
                    }
                    context.T_PlanStaffs.Update(item);
                }
            }
            context.SaveChanges();
            return true;
        }

        //Get All Status plan
        public async Task<List<GetAllStatusPlans_V>> GetAllStatusByPlan()
        {
            List<GetAllStatusPlans_V> L_Status = new List<GetAllStatusPlans_V>();
            var QueryStatus = await context.T_StatusPlans.ToListAsync();
            foreach(var item in QueryStatus)
            {
                var result = new GetAllStatusPlans_V()
                {
                    Id = item.IdStatusPlan,
                    NameStatus = item.NameStauts
                };
                L_Status.Add(result);
            }
            return L_Status;
        }

        //remove plan
        public async Task<NotificationPlans_V> RemovePlan(int IdPlan)
        {
            var result = new NotificationPlans_V();
            var QueryPlans = await context.T_PlanStaffs.FirstOrDefaultAsync(x => x.IdPlan == IdPlan);
            if(QueryPlans == null)
            {
                result.IdNotification = 0; //not find plans this is
                result.Status = false;
            }
            else
            {
                var QueryNotificationPlan = await context.T_NotificationPlans.Where(x => x.IdPlan == IdPlan).ToListAsync();
                var QueryFilePlan = await context.T_FilePlans.Where(x => x.IdPlan == IdPlan).ToListAsync();
                if(QueryNotificationPlan.Count() != 0)
                {
                    foreach(var item in QueryNotificationPlan)
                    {
                        context.T_NotificationPlans.Remove(item);
                    }
                }
                if(QueryFilePlan.Count() != 0)
                {
                    foreach(var item in QueryFilePlan)
                    {
                        context.T_FilePlans.Remove(item);
                    }
                }
                context.T_PlanStaffs.Remove(QueryPlans);
                await context.SaveChangesAsync();
                result.IdNotification = 1; //reomve success
                result.Status = true;
            }
            return result;
        }


        //Get All Notification Plan Cancel -------------------------------------
        private List<T_NotificationPlan> GetAllNotificationPlanCancel()
        {
            var QueryNotificationPlan = context.T_NotificationPlans.ToList();
            return QueryNotificationPlan;
        }

    }
}
