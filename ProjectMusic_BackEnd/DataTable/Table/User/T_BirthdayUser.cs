using System;

namespace DataTable.Table.User
{
    public class T_BirthdayUser
    {
        public int Id { get; set; } //key
        public Guid IdUser { get; set; } //key
        public string TitleSent { get; set; }
        public string ContentSent { get; set; }
        public DateTime BirthdayUser { get; set; }
        public DateTime DateSent { get; set; }
        public bool StatusSent { get; set; }
        public T_User T_Users { get; set; }
    }
}
