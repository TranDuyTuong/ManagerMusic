using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTable.Table.Staff
{
    public class T_PlanStaff
    {
        public int IdPlan { get; set; }
        public string NamePlan { get; set; }
        public string ContentPlan { get; set; }
        public DateTime DateCreate { get; set; }
        public Guid IdUserPlan { get; set; }
        public Guid IdUserRequest { get; set; }
        public DateTime DateComplete { get; set; }
        public TimeSpan TimeComplete { get; set; }
        public int IdStatusPlan { get; set; }
        public int AcceptPlan { get; set; } // 1 -> accept, 2 -> not accept, 0 -> chưa nhận
        public bool TimeUp { get; set; }
    }
}
