using System;
using System.Collections.Generic;

namespace DataTable.Table.User
{
    public class T_LeverUser
    {
        public int IdLever { get; set; } //key
        public string Name { get; set; }
        public string DescriptionName { get; set; }
        public DateTime DateCreate { get; set; }
        public List<T_User> T_Users { get; set; }
    }
}
