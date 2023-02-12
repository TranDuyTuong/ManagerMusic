using DataViewModel.ViewModelUser.Muisc_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagerMusic.Models.Paging.Page_MusicClient
{
    public class PagingMusicClient
    {
        public List<MusicGetAll_V> L_MusicClient { get; set; }
        public int TotalMusic { get; set; }
        public int StatusCase { get; set; }
    }
}
