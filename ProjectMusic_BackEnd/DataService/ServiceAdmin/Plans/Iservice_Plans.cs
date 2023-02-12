using DataViewModel.ViewModelAdmin.Plan_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.ServiceAdmin.Plans
{
    public interface Iservice_Plans
    {
        //amount plans by id user
        int AmountPlanByIdUser(Guid Iduser);

        //amount notification plans not view
        int AmountNotificationPlan(Guid IdUser);

        //get all plans by id user
        Task<GetAllPlans_V> GetAllPlansByIdUser(Guid IdUser);

        //take plans by id user
        Task<NotificationPlans_V> TakePlanByIdUser(Guid IdUser, int IdPlan);

        //detail plan by id user
        Task<GetAllPlans_V> DetailPlanByIdUser(Guid IdUser, int IdPlan);

        //cancel plan by id user
        Task<NotificationPlans_V> CancelPlanByIdUser(Guid IdUser, int IdPlan, string Content);

        //get all notification plan cancel
        Task<List<GetAllNotificationPlan_V>> GetAllNotificationPlan();

        //update plan by Admin
        Task<UpdatePlan_V> UpdatePlanByAdmin(int IdPlan, Guid IdUser);

        Task<NotificationPlans_V> UpdatePlanByAdmin_Post(UpdatePlan_V request, Guid IdUser);

        //update date and time plan by admin
        Task<NotificationPlans_V> UpdateDateTimePlanByAdmin(DateTime DateRequest, TimeSpan TimeRequest, int IdPlan, Guid IdUser);

        //Get All Staff For Role Plan
        Task<List<GetAllUserRolePlan_V>> GetAllStaffRolePlan(int IdPlan);

        //Update User plan
        Task<NotificationPlans_V> UpdateUserCurrentPlan(int IdPlan, Guid IdUser, Guid IdUserRequest);

        //Success plan by staff
        Task<NotificationPlans_V> SuccessPlanByStaff(int IdPlan, Guid IdUser);

        //call dowload file plan
        Task<CreatePlanFile_V> CallDowloadFilePlan(int IdFile, int IdPlan);

        //Get All Status by plan
        Task<List<GetAllStatusPlans_V>> GetAllStatusByPlan();

        //Remove plan
        Task<NotificationPlans_V> RemovePlan(int IdPlan);

    }
}
