using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelAdmin.User_Vm
{
    public class GetInfoChatUser_V
    {
        public int IdChat { get; set; }
        public Guid IdUser { get; set; }
        public string NameUser { get; set; }
        public Guid IdRole { get; set; }
        public string NameRole { get; set; }
        public int TotalChat { get; set; }
        public byte[] Avata { get; set; }
        public List<CreateChatStaff_V> L_Chat { get; set; }
    }
}
