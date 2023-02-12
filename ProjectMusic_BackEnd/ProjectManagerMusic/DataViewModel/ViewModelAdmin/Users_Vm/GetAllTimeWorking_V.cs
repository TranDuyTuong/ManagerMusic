using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelAdmin.Users_Vm
{
    public class GetAllTimeWorking_V
    {
        public Guid Iduser { get; set; }
        public string DateLogin { get; set; }
        public DateTime TimeLogin { get; set; }
        public DateTime TimeLogOut { get; set; }
        public string Str_TimeLogin { get; set; }
        public string Str_TimeOut { get; set; }
        public string TotalWork { get; set; }
    }
}
