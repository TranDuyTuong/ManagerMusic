using DataTable.Table.User;
using System;
using System.Collections.Generic;

namespace DataTable.Table.Address
{
    public class T_District
    {
        public int IdDistrict { get; set; } //key
        public int IdCity { get; set; } //key
        public string NameDistrict { get; set; }
        public DateTime DateCreate { get; set; }
        public bool Status { get; set; }
        public string Identifier { get; set; }
        public T_City T_Cities { get; set; }
        public List<T_User> T_Users { get; set; }

    }
}
