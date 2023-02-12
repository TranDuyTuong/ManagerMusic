using System;
using System.Collections.Generic;

namespace DataTable.Table.RequestUser
{
    public class T_TypeSentUser
    {
        public int IdTypeSent { get; set; } //key
        public string NameType { get; set; } //sent into gmail, sent into message
        public bool Status { get; set; }
        public DateTime DateCreate { get; set; }

        public List<T_AnswerRequest> T_AnswerRequests { get; set; }

    }
}
