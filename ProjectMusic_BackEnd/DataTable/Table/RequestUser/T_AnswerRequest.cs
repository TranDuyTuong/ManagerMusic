using DataTable.Table.User;
using System;

namespace DataTable.Table.RequestUser
{
    public class T_AnswerRequest
    {
        public int IdAnswer { get; set; } //key
        public int IdTypeSent { get; set; } //key
        public Guid IdUser { get; set; } //key
        public int IdRequest { get; set; } //key
        public string IdStaff { get; set; } //key
        public int IdRead { get; set; } //key
        public string TitleSent { get; set; }
        public string ContentSent { get; set; }
        public DateTime DateSent { get; set; }

        public T_TypeSentUser T_TypeSentUsers { get; set; }
        public T_User T_Users { get; set; }
        public T_RequestUser T_RequestUsers { get; set; }
        public T_ReadUser T_ReadUsers { get; set; }





    }
}
