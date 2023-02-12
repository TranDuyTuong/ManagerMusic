using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelAdmin.Plan_Vm
{
    public class CreatePlan_V
    {
        public string NamePlan { get; set; }
        public string ContentPlan { get; set; }
        public DateTime DateCreate { get; set; }
        public Guid IdUserPlan { get; set; }
        public Guid IdUserRequest { get; set; }
        public DateTime DateTimeComplete { get; set; }
        public TimeSpan TimeComplete { get; set; }
        public List<CreatePlanFile_V> L_FilePlan { get; set; } = new List<CreatePlanFile_V>();
    }
}
