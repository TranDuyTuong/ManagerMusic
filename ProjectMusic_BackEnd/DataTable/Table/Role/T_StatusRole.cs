using System;
using System.Collections.Generic;

namespace DataTable.Table.Role
{
    public class T_StatusRole
    {
        public int IdStatusRole { get; set; } //key
        public string NameStatus { get; set; }
        public DateTime DateCreate { get; set; }

        public List<T_Role> T_Roles { get; set; }
    }
}
