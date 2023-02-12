using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTable.Table.Staff
{
    public class T_NotificationPlan
    {
        public int Id { get; set; }
        public int IdPlan { get; set; }
        public Guid IdUser { get; set; }
        public DateTime DateCreate { get; set; }
        public string Content { get; set; }
        public bool StatusView { get; set; }
    }
}
