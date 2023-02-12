using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelAdmin.RequestUser_Vm
{
    public class GetAllRequestUserProgress
    {
        public int Id { get; set; }
        public int IdRecener { get; set; }
        public Guid IdUser { get; set; }
        public string FullName { get; set; }
        public string TitleRequest { get; set; }
        public DateTime DateRequest { get; set; }
        public string Str_DateRequest { get; set; }
        public DateTime DateHandled { get; set; }
        public string Str_DateHandled { get; set; }
        public DateTime DateSuccessFull { get; set; }
        public string Str_DateSuccessFull { get; set; }
    }
}
