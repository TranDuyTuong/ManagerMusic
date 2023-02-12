using DataService.ServiceAdmin.Plans;
using DataViewModel.ViewModelAdmin.Plan_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.ApplicationAdmin.ApplicationPlans.Plan_app
{
    public class Plan_App : Iplan_App
    {
        private readonly Iservice_Plans context;
        public Plan_App(Iservice_Plans _context)
        {
            context = _context;
        }

        //get amount plans by id user
        public int AmountPlanByIdUser(Guid IdUser)
        {
            var reuslt = context.AmountPlanByIdUser(IdUser);
            return reuslt;
        }

        //get all plans by id user
        public async Task<GetAllPlans_V> GetAllPlanByIdUser(Guid IdUser)
        {
            var L_Plans = new GetAllPlans_V();
            if(IdUser != new Guid())
            {
                L_Plans = await context.GetAllPlansByIdUser(IdUser);
            }
            return L_Plans;
        }

        //take plan by id user
        public async Task<NotificationPlans_V> TakePlanByIdUser(Guid IdUser, int IdPlan)
        {
            var result = new NotificationPlans_V();
            if(IdUser == new Guid())
            {
                result.IdNotification = 3; //Id user null
                result.Status = false;
            }
            else
            {
                result = await context.TakePlanByIdUser(IdUser, IdPlan);
            }
            return result;
        }

        //detail plan by id plan
        public async Task<GetAllPlans_V> DetailPlanById(Guid IdUser, int IdPlan)
        {
            var result = await context.DetailPlanByIdUser(IdUser, IdPlan);
            return result;
        }

        //cancel plan by id user
        public async Task<NotificationPlans_V> CancelPlanByIdUser(Guid IdUser, int IdPlan, string Content)
        {
            var result = new NotificationPlans_V();
            if(IdUser == new Guid())
            {
                result.IdNotification = 3; //IdUser ivalidate
                result.Status = false;
            }
            else
            {
                result = await context.CancelPlanByIdUser(IdUser, IdPlan, Content);
            }
            return result;
        }

        //get amount notification plans
        public int AmountNotificationPlans(Guid IdUser)
        {
            var result = context.AmountNotificationPlan(IdUser);
            return result;
        }

        //update plan by admin
        public async Task<UpdatePlan_V> UpdatePlanByAdmin_Get(int IdPlan, Guid IdUser)
        {
            var result = new UpdatePlan_V();
            if(IdPlan == 0 || IdUser == new Guid())
            {
                return result;
            }
            else
            {
                result = await context.UpdatePlanByAdmin(IdPlan, IdUser);
            }
            return result;
        }

        public async Task<NotificationPlans_V> UpdatePlanByAdmin_Post(UpdatePlan_V request, Guid IdUser)
        {
            var result = new NotificationPlans_V();
            if(request.IdPlan == 0 || IdUser == new Guid())
            {
                result.IdNotification = 2; //id plan ivaliate 
                result.Status = false;
            }
            else
            {
                result = await context.UpdatePlanByAdmin_Post(request, IdUser);
            }
            return result;
        }

        //update date and time plan by admin
        public async Task<NotificationPlans_V> UpdateDateTimePlanByAdmin(DateTime DateRequest, TimeSpan TimeRequest, int Idplan, Guid IdUser)
        {
            var result = new NotificationPlans_V();
            if(Idplan == 0 || IdUser == new Guid())
            {
                result.IdNotification = 4; // id plan null and iduser is vaidate
                result.Status = false;
            }
            else
            {
                result = await context.UpdateDateTimePlanByAdmin(DateRequest, TimeRequest, Idplan, IdUser);
            }
            return result;
        }


        //get all staff for role plan
        public async Task<List<GetAllUserRolePlan_V>> GetAllStaffRolePlan(int IdPlan)
        {
            var result = await context.GetAllStaffRolePlan(IdPlan);
            return result;
        }

        //update plan current for new staff
        public async Task<NotificationPlans_V> UpdatePlanCurrentNewStaff(int IdPlan, Guid IdUser, Guid IdUserRequest)
        {
            var result = new NotificationPlans_V();
            if(IdPlan == 0)
            {
                result.IdNotification = 5; // Id Plan not ivalidate
                result.Status = false;
            }else if(IdUser == new Guid())
            {
                result.IdNotification = 6; // Id User not ivalidate
                result.Status = false;
            }else if(IdUserRequest == new Guid())
            {
                result.IdNotification = 7; //Id User request not ivalidate
                result.Status = false;
            }
            else
            {
                result = await context.UpdateUserCurrentPlan(IdPlan, IdUser, IdUserRequest);
            }
            return result;
        }

        //success plan by staff
        public async Task<NotificationPlans_V> SuccessPlanByStaff(int IdPlan, Guid IdUser)
        {
            var result = new NotificationPlans_V();
            if(IdPlan == 0)
            {
                result.IdNotification = 2; // id plan ivalidate
                result.Status = false;
            }
            else
            {
                result = await context.SuccessPlanByStaff(IdPlan, IdUser);
            }
            return result;
        }

        //call dowload file plan
        public async Task<CreatePlanFile_V> CallDowloadFilePlan(int IdFile, int IdPlan)
        {
            var result = await context.CallDowloadFilePlan(IdFile, IdPlan);
            return result;
        }

        //get all notification plan cancel
        public async Task<List<GetAllNotificationPlan_V>> GetAllNotificationPlanCancel()
        {
            var result = await context.GetAllNotificationPlan();
            return result;
        }

        //Get All Status Plans
        public async Task<List<GetAllStatusPlans_V>> GetAllStatusPlans()
        {
            var result = await context.GetAllStatusByPlan();
            return result;
        }

        //remove plans
        public async Task<NotificationPlans_V> ReomvePlans(int IdPlan)
        {
            var result = new NotificationPlans_V();
            if(IdPlan == 0)
            {
                result.IdNotification = 2; //idplan ivaliate
                result.Status = false;
            }
            else
            {
                result = await context.RemovePlan(IdPlan);
            }
            return result;
        }

    }
}
