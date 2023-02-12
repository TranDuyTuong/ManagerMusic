using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelAdmin.Plan_Vm
{
    public class GetAllUserRolePlan_V
    {
        public Guid IdUser { get; set; }
        public string IdStaff { get; set; }
        public string FullName { get; set; }
        public string RoleName { get; set; }
        public byte[] Avata { get; set; }
        public string TypeImage { get; set; }
        public int TotalPlanCurrent { get; set; }
        public bool UserCurrentPlan { get; set; }
    }
}
