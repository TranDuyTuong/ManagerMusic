using System;
using System.Collections.Generic;

namespace DataTable.Table.RequestUser
{
    public class T_RequestPassword
    {
        public int IdRequestPassword { get; set; } //key
        public int IdReceiveRequest { get; set; } //key
        public Guid? IdUser { get; set; } //key
        public string NameUser { get; set; }
        public string TitleRequest { get; set; }
        public string ContentRequest { get; set; }
        public string GmailRequest { get; set; }
        public byte[] ImageRequest { get; set; }
        public string MineType { get; set; }
        public string TypeImg { get; set; }
        public DateTime DateRequest { get; set; }
        public DateTime? DateHandled { get; set; }
        public DateTime? DateSuccess { get; set; }

        public T_ReceiveRequest T_ReceiveRequests { get; set; }

        public List<T_AnswerGmailRequestPassword> T_AnswerGmailRequestPasswords { get; set; }

    }
}
