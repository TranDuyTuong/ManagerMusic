using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelAdmin.Address_Vm
{
    public class PadingCity_Vm
    {
        public List<GetAllCity_Vm> l_Citys {  get; set; }
        public int totalCitys { get; set; }
        public string seachCity { get; set; }
        public int totalSeach { get; set; }
        public int orderBy { get; set; }
    }
}
