using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelAdmin.Dowload_Vm
{
    public class GetAllDowload_V
    {
        public int Id { get; set; }
        public Guid IdMusic { get; set; }
        public string NoMusic { get; set; }
        public string NameMusic { get; set; }
        public string Author { get; set; }
        public byte[] contentImage { get; set; }
        public string TypeImage { get; set; }
        public Guid? IdUser { get; set; }
        public string FullName { get; set; }
        public string IdStaff { get; set; }
        public string DateDowload { get; set; }
        public string TimeDowload { get; set; }
    }
}
