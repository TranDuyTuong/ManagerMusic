using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelUser.Muisc_Vm
{
    public class DowloadMusic_V
    {
        public Guid IdMusic { get; set; }
        public string NameMuisc { get; set; }
        public int IdSeason { get; set; }
        public string NameSeason { get; set; }
        public int TotalDowload { get; set; }
        public string DateDowload { get; set; }
        public string TimeDowload { get; set; }
    }
}
