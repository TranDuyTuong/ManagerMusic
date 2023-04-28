using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelAdmin.Address_Vm
{
    public class DetailCity_Vm
    {
        public int Id { get; set; }
        public string NameCity { get; set; }
        public DateTime CreateDate { get; set; }
        public string TimeCraete { get; set; }
        public string Symbol { get; set; }
        public int AreaCode { get; set; }
        public bool Status { get; set; }
        public List<GetAllDistrict_Vm> L_District { get; set; } = new List<GetAllDistrict_Vm>();
    }
}
