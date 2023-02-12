using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelAdmin.Users_Vm
{
    public class GetAllUsers_V
    {
        public Guid IdUser { get; set; }
        public string NameUsers { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime DateCreate { get; set; }
        public int Age { get; set; }
        public int IdStatus { get; set; }
        public string NameStatus { get; set; }
        public string Str_Birthday { get; set; }
        public string Str_DateCreate { get; set; }

        //---------------------------------------
        public int WasSentBirthday { get; set; }
    }
}
