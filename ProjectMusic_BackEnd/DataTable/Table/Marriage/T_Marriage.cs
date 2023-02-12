using DataTable.Table.User;
using System;
using System.Collections.Generic;

namespace DataTable.Table.Marriage
{
    public class T_Marriage
    {
        public int IdMarriage { get; set; } //key
        public string NameMarriage { get; set; }
        public DateTime DateCreate { get; set; }
        public List<T_User> T_Users { get; set; }
    }
}
