using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelUser.LoginAndRegiter_Vm
{
    public class NotifiationLogin
    {
        public bool Status { get; set; } // 1: Email does not exist , 2: Login Fail, 3: gmail is not syntax correct
        public string LinkUrl { get; set; }
        public int Message { get; set; }
        public string TokenData { get; set; }
        public string TokenTime { get; set; }
        public Guid IdUser { get; set; }
        public Guid IdRole { get; set; }
        public string NameRole { get; set; }
        public string SymbolRole { get; set; }
        public string FullName { get; set; }
        public string Birthday { get; set; }
        public string Email { get; set; }
        public string UserNames { get; set; }
        public int IdAccountActiver { get; set; }
        public int Age { get; set; }
        public byte[] ImageAvata { get; set; }
        public string ImageBye { get; set; }
        public string Lever { get; set; }
        public int IdStaffOrUser { get; set; }
        public string NameStaffOrUser { get; set; }
        public string IdStaff { get; set; }
        public string AddressSatff { get; set; }
        public string PhoneMunerStaff { get; set; }
        public int? HireStaff { get; set; }
        public string Marriage { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string DateCreate { get; set; }
    }
}
