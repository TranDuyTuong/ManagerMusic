using DataViewModel.ViewModelUser.Notification_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.ApplicationUser.ApplicationNotification
{
    public interface INotificationUser_App
    {
        //get all notification by id user
        public List<GetNotificationByUser> GetNotificationByUser(Guid IdUser, int take);

        //was watched notification 
        public Task<bool> WatchedNotification(int id);

        //delete notification by id user
        public Task<bool> DeleteNotification(List<int> Id, int IdNotification);
    }
}
