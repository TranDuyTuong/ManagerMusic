using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTable.Table.Staff
{
    public class T_StatusPlan
    {
        public int IdStatusPlan { get; set; }
        public string NameStauts { get; set; }
        // 1 -> Done, 2 -> Cancel, 3 -> unfinished, 4 -> Processing, 5 -> Unprocessing
    }
}
