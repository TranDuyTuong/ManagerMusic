using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelAdmin.Plan_Vm
{
    public class GetAllPlans_V
    {
        public string NameRole { get; set; }
        public List<List_getAllPlans_V> L_Plans { get; set; } = new List<List_getAllPlans_V>();

        public List_getAllPlans_V DetailPlan { get; set; }
    }
}
