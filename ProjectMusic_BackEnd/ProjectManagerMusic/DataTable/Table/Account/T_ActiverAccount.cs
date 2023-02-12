using DataTable.Table.User;
using System;
using System.Collections.Generic;

namespace DataTable.Table.Account
{
    public class T_ActiverAccount
    {
        public int IdAccountActiver { get; set; } //key
        public string NameAccountActiver { set; get; }
        public DateTime DateCreate { get; set; }
        public List<T_User> T_Users { get; set; }
    }
}
