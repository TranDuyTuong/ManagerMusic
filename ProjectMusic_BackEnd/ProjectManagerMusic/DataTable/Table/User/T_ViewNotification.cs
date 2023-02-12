using System;
using System.Collections.Generic;

namespace DataTable.Table.User
{
    public class T_ViewNotification
    {
        public int IdViewNotification { get; set; } //key
        public string Description { get; set; } // Đã xem, Chưa Xem
        public DateTime DateCreate { get; set; }
        public List<T_NotificationUser> T_NotificationUsers { get; set; }
    }
}
