using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelUser.Notification_Vm
{
    public class CreateNotification_v
    {
        public Guid IdUser { get; set; } //key
        public int IdViewNotification { get; set; } //key
        public int IdDeleteNotification { get; set; } //key
        public string TitleNotification { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime TimeCreate { get; set; }
        public string AuthorNotification { get; set; }
    }
}
