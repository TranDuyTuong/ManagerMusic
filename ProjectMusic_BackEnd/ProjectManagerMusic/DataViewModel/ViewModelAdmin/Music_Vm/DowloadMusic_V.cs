using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelAdmin.Music_Vm
{
    public class DowloadMusic_V
    {
        public Guid IdMusic { get; set; }
        public string NameUser { get; set; }
        public Guid IdUser { get; set; }
        public DateTime DateDowload { get; set; }
    }
}
