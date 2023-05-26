using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelAdmin.Address_Vm
{
    public class PadingDistrict_Vm
    {
        public List<GetAllDistrict_Vm> l_Districts { get; set; }
        public int totalDistricts { get; set; }
        public string seachDistrict { get; set; }
        public int totalSeach { get; set; }
        public int orderBy { get; set; }
    }
}
