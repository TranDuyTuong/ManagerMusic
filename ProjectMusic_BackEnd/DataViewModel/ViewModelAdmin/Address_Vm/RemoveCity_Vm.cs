using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelAdmin.Address_Vm
{
    public class RemoveCity_Vm
    {
        public int Status { get; set; }
        public int OptionSelect { get; set; }
        public List<District_Selection> SelectedDistricts { get; set;} = new List<District_Selection>();
        public List<Staff_Selection> SelectedStaffs { get; set; } = new List<Staff_Selection>();
    }
    public class District_Selection
    {
        public int IdDistrict { get; set; }
        public string NameDistrict { get; set; }
        public string NameCity { get; set; }
    }
    public class Staff_Selection
    {
        public string NameStaff { get;set; }
        public string NameCity { get; set; }
    }
}
