using System;
using System.Collections.Generic;

namespace DataTable.Table.RequestUser
{
    public class T_ReceiveRequest
    {
        public int IdReceiveRequest { get; set; } //key
        public string Description { get; set; } // chưa giải quyết, đang giải quyết, đã giải quyết
        public DateTime DateCreate { get; set; }

        public List<T_RequestPassword> T_RequestPasswords { get; set; }
        public List<T_RequestUser> T_RequestUsers { get; set; }

    }
}
