using DataViewModel.ViewModelUser.Notification_Vm;
using System.Collections.Generic;

namespace ManagerMusic.Models.Paging.Page_Notification
{
    public class PagingNotification
    {
        public IEnumerable<GetNotificationByUser> L_Notification { get; set; }
        public int TotalNotification { get; set; }
    }
}
