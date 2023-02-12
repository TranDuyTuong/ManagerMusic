using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelAdmin.Dowload_Vm
{
    public class PagingDowload_V
    {
        public IEnumerable<GetAllDowload_V> L_Dowload { get; set; }
        public int Total { get; set; }
    }
}
