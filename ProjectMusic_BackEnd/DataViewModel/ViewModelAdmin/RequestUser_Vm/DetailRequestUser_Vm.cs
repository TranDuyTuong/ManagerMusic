using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelAdmin.RequestUser_Vm
{
    public class DetailRequestUser_Vm
    {
        public int IdRequest { get; set; }
        public Guid IdRole { get; set; }
        public string NameRole { get; set; }
        public Guid IdUser { get; set; }
        public string NameUser { get; set; }
        public string Gmail { get; set; }
        public string STR_DateRequest { get; set; }
        public DateTime DateRequest { get; set; }
        public string TitleRequest { get; set; }
        public string ContentRequest { get; set; }
        public bool StatusFindData { get; set; }
        public int IdRecende { get; set; }
        public string NameRecende { get; set; }
        public string Str_DateHandled { get; set; }
        public  int IdTypeSent { get; set; }
        public string NameTypeSent { get; set; }
        public string Str_DateSuccess { get; set; }

    }
}
