using DataTable.Table.User;
using System;
using System.Collections.Generic;

namespace DataTable.Table.Gender
{
    public class T_Gender
    {
        public int IdGender { get; set; } //key
        public string NameGender { get; set; }
        public DateTime DateCreate { get; set; }
        public List<T_User> T_Users { get; set; }
    }
}
