using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelUser.Muisc_Vm
{
    public class DowloadMuiscInMonth_V
    {
        public Guid IdMuisc { get; set; }
        public string NameMuisc { get; set; }
        public string NameAuthor { get; set; }
        public int TotalDowload { get; set; }
        public int IdSeason { get; set;}
        public string NameSeason { get; set; }
    }
}
