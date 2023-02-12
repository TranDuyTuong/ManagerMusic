using DataViewModel.ViewModelUser.Notification_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.ServiceUser.NotificatonUser
{
    public interface INotificationUser
    {
        //create Notification User
        public bool CreateNotification(CreateNotification_v request);

        //get notification user by id user
        public List<GetNotificationByUser> GetNotificationByUser(Guid IdUser, int take);

        //watched notification
        public Task<bool> WatchedNotification(int Id);

        //delete notification user
        public Task<bool> DeleteNotificationUser(List<int> Id, int IdNotification);
    }
}
