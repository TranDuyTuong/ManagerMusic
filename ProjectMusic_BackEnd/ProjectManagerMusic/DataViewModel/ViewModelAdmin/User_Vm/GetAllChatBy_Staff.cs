using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelAdmin.User_Vm
{
    public class GetAllChatBy_Staff
    {
        public List<CreateChatStaff_V> L_Chat { get; set; }
        public Guid IdUser { get; set; }
        public int TotalUser { get; set; }
        public bool Status { get; set; }
        public string Fuilter_Date { get; set; }
    }
}
