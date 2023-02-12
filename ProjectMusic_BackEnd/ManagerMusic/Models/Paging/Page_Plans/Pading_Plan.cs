using DataViewModel.ViewModelAdmin.Plan_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagerMusic.Models.Paging.Page_Plans
{
    public class Pading_Plan
    {
        public int TotalPlan { get; set; }
        public string NameRole { get; set; }
        public List<List_getAllPlans_V> L_Plans { get; set; } = new List<List_getAllPlans_V>();
    }
}
