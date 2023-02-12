using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelAdmin.Users_Vm
{
    public class DetailUser_V
    {
        public Guid IdUser { get; set; } //key
        public int IdAccountActiver { get; set; } //key
        public int IdLever { get; set; } //key
        public int IdGender { get; set; } //key
        public int IdCity { get; set; } //key
        public int IdDistrict { get; set; } //key
        public DateTime Birthday { get; set; }
        public string FullName { get; set; }
        public int Date { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public DateTime DateCreate { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string NameGender { get; set; }
        public string NameLever { get; set; }
        public string NameCity { get; set; }
        public string NameDistrict { get; set; }
        public string Str_Birthday { get; set; }
        public string Str_DateCreate { get; set; }
        public int TimeOnline { get; set; }
        public string Str_DateUpdate { get; set; }
    }
}
