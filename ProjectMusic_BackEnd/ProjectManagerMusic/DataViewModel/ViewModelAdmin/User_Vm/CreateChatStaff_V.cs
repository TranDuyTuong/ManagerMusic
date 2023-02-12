using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelAdmin.User_Vm
{
    public class CreateChatStaff_V
    {
        public int Id { get; set; }
        public Guid IdUser { get; set; }
        public string FullName { get; set; }
        public DateTime DateCreate { get; set; }
        public string DateCreate_C { get; set; }
        public string TimeCreate { get; set; }
        public byte[] ImageAvata { get; set; }
        public string Message { get; set; }
        public List<GetAllChatImages_V> L_Images { get; set; }
    }
}
