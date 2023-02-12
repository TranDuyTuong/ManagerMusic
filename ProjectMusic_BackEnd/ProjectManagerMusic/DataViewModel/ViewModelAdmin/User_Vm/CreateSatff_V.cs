using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelAdmin.User_Vm
{
    public class CreateSatff_V
    {
        public string IdStaff { get; set; } //key
        public int IdAccountActiver { get; set; } //key
        public int IdLever { get; set; } //key
        public int IdStaffOrUser { get; set; } //key
        public int? StatusStaffOff { get; set; } //key
        public int? IdMarriage { get; set; } //key
        public int IdGender { get; set; } //key
        public int IdCity { get; set; } //key
        public Guid IdRole { get; set; } //key
        public int IdDistrict { get; set; } //key
        public DateTime Birthday { get; set; }
        public string FullName { get; set; }
        public int Date { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public DateTime DateCreate { get; set; }
        public int Age { get; set; }
        public IFormFile ImageAvata { get; set; }
        public byte[] ImageAvataConver { get; set; }
        public string AddressSatff { get; set; } //staff
        public string PhoneStaff { get; set; } //staff
        public int? CancelHideStaff { get; set; } //staff, 1 -> thuê, 2 -> hủy thuê
        public string Email { get; set; }
        public string Password { get; set; }
        public string TokenData { get; set; }
        public string TypeImage { get; set; }
        public string NameImage { get; set; }
    }
}
