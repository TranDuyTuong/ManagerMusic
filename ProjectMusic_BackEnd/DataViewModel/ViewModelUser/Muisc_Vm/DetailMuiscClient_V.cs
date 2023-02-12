using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelUser.Muisc_Vm
{
    public class DetailMuiscClient_V
    {
        public Guid IdMuisc { get; set; }
        public string NoMuisc { get; set; }
        public string NameMusic { get; set; }
        public string Author { get; set; }
        public DateTime DateCreate { get; set; }
        public string Str_DateCreate { get; set; }
        public string FileName { get; set; }
        public byte[] ContetnFile { get; set; }
        public string MineFile { get; set; }
        public string TypeFile { get; set; }
        public int IdSeason { get; set; }
        public string NameSeason { get; set; }
        public int IdSaint { get; set; }
        public string NameSaint { get; set; }
        public int TotalLike { get; set; }
        public int TotalDowload { get; set; }
        public int TotalComment { get; set; }
    }
}
