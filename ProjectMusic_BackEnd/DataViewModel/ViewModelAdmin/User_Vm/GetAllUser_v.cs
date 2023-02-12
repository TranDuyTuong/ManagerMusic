using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelAdmin.User_Vm
{
    public class GetAllUser_v
    {
        public Guid IdUser { get; set; } //key
        public string IdStaff { get; set; }
        public Guid IdRole { get; set; } //key
        public string NameRole { get; set; }
        public int IdAccountActiver { get; set; }
        public string AccountActiver { get; set; } //key
        public string Lever { get; set; } //key
        public int IdStaffOrUser { get; set; } //key
        public string Gender { get; set; } //key
        public string City { get; set; } //key
        public string District { get; set; } //key
        public DateTime? DateAccountBlock { get; set; }
        public string Birthday { get; set; }
        public DateTime Birthday_TypeDate { get; set; }
        public string FullName { get; set; }
        public int Date { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public string DateCreate { get; set; }
        public int Age { get; set; }
        public DateTime? DateUpdate { get; set; } //date edit infomation
        public string Email { get; set; }
        public byte[] ImageStaff { get; set; }
        public string TypeImage { get; set; }
        public string NameFile { get; set; }
        public int TotalChat { get; set; }
        public bool WasWiew { get; set; }
    }
}
