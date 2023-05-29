using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelAdmin.Address_Vm
{
    public class GetAllDistrict_Vm
    {
        public int DistrictId { get; set; }
        public int CityId { get; set; }
        public string NameDistrict { get; set; }
        public DateTime DateCreate { get; set; }
        public string NameCity { get; set; }
        public string TimeCreate { get; set; }
        public bool Status { get; set; }
        public string Identifier { get; set; }
    }
}
