using DataService.ServiceUser.NotificatonUser;
using DataViewModel.ViewModelUser.Notification_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.ApplicationUser.ApplicationNotification
{
    public class NotificationUser_App: INotificationUser_App
    {
        private readonly INotificationUser context;
        public NotificationUser_App(INotificationUser _context)
        {
            context = _context;
        }

        //get notification by id user
        public List<GetNotificationByUser> GetNotificationByUser(Guid IdUser, int take)
        {
            var result = context.GetNotificationByUser(IdUser, take);
            return result;
        }

        //watch notification
        public async Task<bool> WatchedNotification(int id)
        {
            if(id == 0)
            {
                return false;
            }
            else
            {
                var result = await context.WatchedNotification(id);
                return result;
            }
        }

        //delete notificaiton user
        public async Task<bool> DeleteNotification(List<int> Id, int IdNotification)
        {
            if(Id.Count() == 0 && IdNotification == 0)
            {
                return false;
            }
            else
            {
                var result = await context.DeleteNotificationUser(Id, IdNotification);
                return result;
            }
        }

    }
}
