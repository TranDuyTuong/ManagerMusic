using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelAdmin.Plan_Vm
{
    public class GetAllNotificationPlan_V
    {
        public int Id { get; set; }
        public int IdPlan { get; set; }
        public Guid IdUserPlan { get; set; }
        public string NameUserPlan { get; set; }
        public Guid IdUserRequest { get; set; }
        public string NameUserRequest { get; set; }
        public string ContentCancel { get; set; }
        public DateTime DateCreate { get; set; }
        public string DateCreate_Str { get; set; }
    }
}
