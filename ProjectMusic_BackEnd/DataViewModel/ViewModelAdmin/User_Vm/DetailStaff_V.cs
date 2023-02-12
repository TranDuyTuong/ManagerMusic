using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelAdmin.User_Vm
{
    public class DetailStaff_V
    {
        public Guid IdUser { get; set; }
        public string IdStaff { get; set; }
        public string FullName { get; set; }
        public int IdActiver { get; set; }
        public string NameActiver { get; set; }
        public int IdLever { get; set; }
        public string NameLever { get; set; }
        public string Birthday { get; set; }
        public string Gmail { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int idMariage { get; set; }
        public string NameMariage { get; set; }
        public int IdGender { get; set; }
        public string Gender { get; set; }
        public byte[] AvataImage { get; set; }
        public string TypeImage { get; set; }
        public int IdCity { get; set; }
        public string City { get; set; }
        public int IdDistrict { get; set; }
        public string District { get; set; }
        public Guid IdRole { get; set; }
        public string NameRole { get; set; }
        public int HideStaff { get; set; }
        public string NameHideStaff { get; set; }
    }
}
