using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelAdmin.Address_Vm
{
    public class ReadDataDistrictExcel_Vm
    {
        public List<GetAllDistrict_Vm> L_Districts { get; set; }
        public int Status { get; set; }
        public int TotalDistricts { get; set; }
    }
}
