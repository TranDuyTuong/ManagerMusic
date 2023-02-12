using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelUser.LoginAndRegiter_Vm
{
    public class GetUsers
    {
        public Guid IdUser { get; set; }
        public Guid IdRole { get; set; }
        public string UserName { get; set; }
        public string SymbolRole { get; set; }
    }
}
