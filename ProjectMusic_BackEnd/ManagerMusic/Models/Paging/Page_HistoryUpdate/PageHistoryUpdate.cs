using DataViewModel.ViewModelAdmin.Music_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagerMusic.Models.Paging.Page_HistoryUpdate
{
    public class PageHistoryUpdate
    {
        public IEnumerable<GetAllHistoryUpdate_V> L_HistoryUpdate { get; set; }
        public int Total { get; set; }
    }
}
