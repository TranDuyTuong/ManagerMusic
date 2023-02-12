using System;
using System.Collections.Generic;

namespace DataTable.Table.User
{
    public class T_StaffOrUser
    {
        public int IdStaffOrUser { get; set; } //key
        public string symbol { get; set; } // ND -> người dùng, NV -> nhân viên
        public string Description { get; set; } // người dùng, nhân viên
        public DateTime DateCreate { get; set; }
        public bool Status { get; set; }
        public List<T_User> T_Users { get; set; }
    }
}
