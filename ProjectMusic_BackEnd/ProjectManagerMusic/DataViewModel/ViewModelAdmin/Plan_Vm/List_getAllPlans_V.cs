using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelAdmin.Plan_Vm
{
    public class List_getAllPlans_V
    {
        public int IdPlan { get; set; }
        public Guid IdUserPlan { get; set; }
        public Guid idUserRequest { get; set; }
        public string NameUserPlan { get; set; }
        public string NameUserRequest { get; set; }
        public DateTime DateCreatePlan { get; set; }
        public string DateCreate_Str { get; set; }
        public DateTime DateComplete { get; set; }
        public string DateComplete_Str { get; set; }
        public TimeSpan TimeCompele { get; set; }
        public string TitlePlan { get; set; }
        public int IdStatus { get; set; }
        public string NameStatus { get; set; }
        public int IdAcceptPlan { get; set; }
        public bool TimeUp { get; set; }
        public string ContentPlan { get; set; }
        public List<CreatePlanFile_V> L_FilePlans { get; set; } = new List<CreatePlanFile_V>();
    }
}
