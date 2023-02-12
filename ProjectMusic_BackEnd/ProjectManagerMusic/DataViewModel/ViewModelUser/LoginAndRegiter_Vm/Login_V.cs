using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelUser.LoginAndRegiter_Vm
{
    public class Login_V
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Remember { get; set; } = true;
        public string RequestPath { get; set; }
    }
}
