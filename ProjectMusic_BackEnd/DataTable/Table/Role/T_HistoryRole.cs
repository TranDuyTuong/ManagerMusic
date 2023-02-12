using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTable.Table.Role
{
    public class T_HistoryRole
    {
        public int Id { get; set; }
        public Guid IdRole { get; set; }
        public Guid IdUser { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Guid IdUserDecenRole { get; set; }

    }
}
