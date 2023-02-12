using DataTable.Table.User;
using System;
using System.Collections.Generic;

namespace DataTable.Table.Address
{
    public class T_City
    {
        public int IdCity { get; set; } //key
        public string NameCity { get; set; }
        public DateTime DateCreate { get; set; }
        public List<T_District> T_Districts { get; set; }
        public List<T_User> T_Users { get; set; }
    }
}
