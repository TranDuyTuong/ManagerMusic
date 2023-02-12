using System;
using System.Collections.Generic;

namespace DataTable.Table.RequestUser
{
    public class T_ReadUser
    {
        public int IdRead { get; set; } //key
        public string ReadContent { get; set; }
        public DateTime DateCreate { get; set; }

        public List<T_AnswerRequest> T_AnswerRequests { get; set; }
    }
}
