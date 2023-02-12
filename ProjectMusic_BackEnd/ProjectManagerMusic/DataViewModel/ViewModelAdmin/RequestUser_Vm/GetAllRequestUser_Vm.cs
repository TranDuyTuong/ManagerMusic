using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelAdmin.RequestUser_Vm
{
    public class GetAllRequestUser_Vm
    {
        public int Id { get; set; }
        public Guid IdUser { get; set; }
        public string NameUser { get; set; }
        public string Title { get; set; }
        public string Str_DateRequest { get; set; }
        public DateTime DateRequest { get; set; }
        public string NameReceive { get; set; }
        public int IdReceive { get; set; }

    }
}
