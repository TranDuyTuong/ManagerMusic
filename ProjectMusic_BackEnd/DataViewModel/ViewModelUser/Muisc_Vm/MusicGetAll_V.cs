using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelUser.Muisc_Vm
{
    public class MusicGetAll_V
    {
        public Guid IdMuisc { get; set; }
        public string NoMusic { get; set; }
        public string NameMusic { get; set; }
        public string Author { get; set; }
        public int IdSeason { get; set; }
        public string NameSeason { get; set; }
        public int IdSaint { get; set; }
        public string NameSaint { get; set; }
        public DateTime DateCreate { get; set; }
        public string Str_DateCreate { get; set; }
        public int Like { get; set; }
        public int Dowload { get; set; }
        public int UserLike { get; set; } // 1: not like, 2: were like
    }
}
