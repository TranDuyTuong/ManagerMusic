using DataTable.Table.User;
using System;
using System.Collections.Generic;

namespace DataTable.Table.Staff
{
    public class T_StatusStaffOff
    {
        public int StatusStaffOff { get; set; } //key
        public string Description { get; set; }
        public DateTime DateCreate { get; set; }
        public List<T_User> T_Users { get; set; }   
    }
}
