using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelUser.LoginAndRegiter_Vm
{
    public class NotificationRegiter_V
    {
        public bool Status { get; set; }
        public string Notification { get; set; }
        public int IsStatus { get; set; }
        // 1: email tồn tại, 2: đăng ký thành công, 3: đăng ký thất bại, 4: Email không phù hợp
    }
}
