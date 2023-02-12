using System;

namespace DataTable.Table.User
{
    public class T_NotificationUser
    {
        public int IdNotification { get; set; } //key
        public Guid IdUser { get; set; } //key
        public int IdViewNotification { get; set; } //key
        public int IdDeleteNotification { get; set; } //key
        public string TitleNotification { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime TimeCreate { get; set; }
        public string AuthorNotification { get; set; }

        public T_User T_Users { get; set; }
        public T_ViewNotification T_ViewNotifications { get; set; }
        public T_DeleteNotification T_DeleteNotifications { get; set; }



    }
}
