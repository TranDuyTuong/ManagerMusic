using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelUser.ReportBugClient_Vm
{
    public class SentReportBugClient_V
    {
        public string NameSent { get; set; }
        public string EmailRegiter { get; set; }
        public string TitleReprot { get; set; }
        public string ContentReport { get; set; }
        public byte[] ImageBug { get; set; }
        public string MineType { get; set; }
        public string TypeImage { get; set; }
        public DateTime DateCreate { get; set; }
    }
}
