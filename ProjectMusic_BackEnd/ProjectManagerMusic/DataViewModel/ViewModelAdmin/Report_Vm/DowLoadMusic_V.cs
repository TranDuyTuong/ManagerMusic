using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelAdmin.Report_Vm
{
    public class DowLoadMusic_V
    {
        public Guid IdMusic { get; set; }
        public string CodeMusic { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime DateCreate { get; set; }
        public string Str_DateCreate { get; set; }
        public int IdSeason { get; set; }
        public string NameSeason { get; set; }
        public int IsSaint { get; set; }
        public string NameSaint { get; set; }
        public string FileName { get; set; }
        public byte[] FileContent { get; set; }
        public  string MineFile { get; set; }
        public string IdStaff { get; set; }
        public string NameStaff { get; set; }
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
    }
}
