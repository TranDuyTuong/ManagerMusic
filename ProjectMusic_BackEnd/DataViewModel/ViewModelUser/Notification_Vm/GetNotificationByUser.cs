using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelUser.Notification_Vm
{
    public class GetNotificationByUser
    {
        public int IdNotification { get; set; } //key
        public Guid IdUser { get; set; } //key
        public int IdViewNotification { get; set; } //key
        public string NameViewNotification { get; set; }
        public string TitleNotification { get; set; }
        public string DateCreate { get; set; }
        public string TimeCreate { get; set; }
        public string AuthorNotification { get; set; }
    }
}
