using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelAdmin.Users_Vm
{
    public class GetAllRequestByIdUser
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string DateRequest { get; set; }
        public string DateHandled { get; set; }
        public string DateSuccess { get; set; }
        public int IdRecuse { get; set; }
        public string NameRecuse { get; set; }
    }
}
