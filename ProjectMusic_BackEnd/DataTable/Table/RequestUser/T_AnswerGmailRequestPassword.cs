using System;

namespace DataTable.Table.RequestUser
{
    public class T_AnswerGmailRequestPassword
    {
        public int IdAnswerGmail { get; set; } //key
        public int IdRequestPassword { get; set; } //key
        public string IdStaff { get; set; } //key
        public Guid? IdUser { get; set; } //key
        public string NameUser { get; set; }
        public string TitleAnswer { get; set; }
        public string ContentAnswer { get; set; }
        public DateTime DateAnswer { get; set; }
        
        public T_RequestPassword T_RequestPasswords { get; set; }
    }
}
