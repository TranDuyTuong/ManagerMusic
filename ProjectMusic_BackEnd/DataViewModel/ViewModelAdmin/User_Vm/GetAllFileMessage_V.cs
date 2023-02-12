using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelAdmin.User_Vm
{
    public class GetAllFileMessage_V
    {
        public DateTime Key_Date { get; set; }
        public string Date_String { get; set; }
        public List<GetAllChatImages_V> LFile_Message { get; set; } = new List<GetAllChatImages_V>();
    }
}
