using DataViewModel.ViewModelAdmin.Plan_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.ApplicationAdmin.ApplicationPlans.Plan_app
{
    public interface Iplan_App
    {
        //get amount by id user
        int AmountPlanByIdUser(Guid IdUser);

        //get amount plan by id user
        int AmountNotificationPlans(Guid IdUser);

        //get all plan by id user
        Task<GetAllPlans_V> GetAllPlanByIdUser(Guid IdUser);

        //take plan by id user
        Task<NotificationPlans_V> TakePlanByIdUser(Guid IdUser, int IdPlan);

        //detail plan by id plan
        Task<GetAllPlans_V> DetailPlanById(Guid IdUser, int IdPlan);

        //cancel plan by id user
        Task<NotificationPlans_V> CancelPlanByIdUser(Guid IdUser, int IdPlan, string Content);

        //update plan by admin
        Task<UpdatePlan_V> UpdatePlanByAdmin_Get(int IdPlan, Guid IdUser);

        Task<NotificationPlans_V> UpdatePlanByAdmin_Post(UpdatePlan_V request, Guid IdUser);

        //update date and time plan by admin
        Task<NotificationPlans_V> UpdateDateTimePlanByAdmin(DateTime DateRequest, TimeSpan TimeRequest, int Idplan, Guid IdUser);

        //Get all staff for role plan
        Task<List<GetAllUserRolePlan_V>> GetAllStaffRolePlan(int IdPlan);

        //update Plan current for new staff
        Task<NotificationPlans_V> UpdatePlanCurrentNewStaff(int IdPlan, Guid IdUser, Guid IdUserRequest);

        //success plan by staff
        Task<NotificationPlans_V> SuccessPlanByStaff(int IdPlan, Guid IdUser);

        //call dowload file plan
        Task<CreatePlanFile_V> CallDowloadFilePlan(int IdFile, int IdPlan);

        //get all notification plan cancel
        Task<List<GetAllNotificationPlan_V>> GetAllNotificationPlanCancel();

        //Get All Status Plan
        Task<List<GetAllStatusPlans_V>> GetAllStatusPlans();

        //remove plans
        Task<NotificationPlans_V> ReomvePlans(int IdPlan);
    }
}
