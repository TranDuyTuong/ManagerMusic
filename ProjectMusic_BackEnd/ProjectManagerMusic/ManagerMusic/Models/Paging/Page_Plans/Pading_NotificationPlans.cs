using DataViewModel.ViewModelAdmin.Plan_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagerMusic.Models.Paging.Page_Plans
{
    public class Pading_NotificationPlans
    {
        public IEnumerable<GetAllNotificationPlan_V> L_NotificationPlan { get; set; }
        public int TotalNotification { get; set; }
    }
}
