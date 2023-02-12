using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelAdmin.User_Vm
{
    public class UpdateStaff_V
    {
        public Guid IdUser { get; set; }
        public string IdStaff { get; set; }
        public string FullName { get; set; }
        public int IdMarriage { get; set; }
        public string NameMarrige { get; set; }
        public string AddressUser { get; set; }
        public string Gmail { get; set; }
        public string PhoneNumber { get; set; }
        public string TypeImage { get; set; }
        public string NameImage { get; set; }
        public byte[] AvataUser { get; set; }
        public List<GetAllMarriage_V> L_Marriage { get; set; }
    }
}
