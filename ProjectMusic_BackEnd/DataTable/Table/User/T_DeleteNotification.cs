using System;
using System.Collections.Generic;

namespace DataTable.Table.User
{
    public class T_DeleteNotification
    {
        public int IdDeleteNotification { get; set; } //key
        public string Description { get; set; } // đã xóa thông báo, chưa xóa thông báo
        public DateTime DateCreate { get; set; }
        public List<T_NotificationUser> T_NotificationUsers { get; set; }
    }
}
