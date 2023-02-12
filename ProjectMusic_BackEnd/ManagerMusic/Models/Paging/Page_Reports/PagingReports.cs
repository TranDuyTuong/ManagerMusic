using DataViewModel.ViewModelAdmin.Report_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagerMusic.Models.Paging.Page_Reports
{
    public class PagingReports
    {
        public List<DowLoadMusic_V> L_ReportMusic { get; set; }
        public int TotalMusic { get; set; }
    }
}
