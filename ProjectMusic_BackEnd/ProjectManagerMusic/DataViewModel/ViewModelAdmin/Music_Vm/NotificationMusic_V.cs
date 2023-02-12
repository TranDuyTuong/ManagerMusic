using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelAdmin.Music_Vm
{
    public class NotificationMusic_V
    {
        public int IsStatus { get; set; } // 1: create success, 2: create fail, 3: music was exit, 4: not iduser
        public bool Status { get; set; }
        public byte[] ContentFile { get; set; }
        public string MineType { get; set; }
    }
}
