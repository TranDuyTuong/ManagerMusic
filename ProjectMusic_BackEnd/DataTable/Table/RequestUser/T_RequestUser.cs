using DataTable.Table.User;
using System;
using System.Collections.Generic;

namespace DataTable.Table.RequestUser
{
    public class T_RequestUser
    {
        public int IdRequest { get; set; } //key
        public Guid IdUser { get; set; } //key
        public string TitleRequest { get; set; }
        public string ContentRequest { get; set; }
        public DateTime DateRequest { get; set; }
        public DateTime? DateHandled { get; set; }
        public DateTime? DateSuccess { get; set; }
        public int IdReceiveRequest { get; set; } //key
        public int? IdTypeSent { get; set; }

        public T_ReceiveRequest T_ReceiveRequests { get; set; }
        public T_User T_Users { get; set; }

        public List<T_AnswerRequest> T_AnswerRequests { get; set; }
    }
}
