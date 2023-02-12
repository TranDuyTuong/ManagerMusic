using System;

namespace DataTable.Table.Account
{
    public class T_Login
    {
        public Guid IdLogin { get; set; } //key
        public Guid IdUser { get; set; } //key
        public DateTime DateLogin { get; set; }
        public DateTime TimeLogin { get; set; }
        public DateTime TimeSignout { get; set; }
    }
}
