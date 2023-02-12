using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelAdmin.Plan_Vm
{
    public class UpdatePlan_V
    {
        public int IdPlan { get; set; }
        public string NamePlan { get; set; }
        public string ContentPlan { get; set; }
        public string DateCreate { get; set; }
        public List<CreatePlanFile_V> L_FilePlans { get; set; } = new List<CreatePlanFile_V>();
    }
}
