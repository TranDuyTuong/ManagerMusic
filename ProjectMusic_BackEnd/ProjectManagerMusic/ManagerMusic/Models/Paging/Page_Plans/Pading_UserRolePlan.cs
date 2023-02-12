using DataViewModel.ViewModelAdmin.Plan_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagerMusic.Models.Paging.Page_Plans
{
    public class Pading_UserRolePlan
    {
        public IEnumerable<GetAllUserRolePlan_V> L_UserRolePlan { get; set; }
        public int TotalUser { get; set; }
    }
}
