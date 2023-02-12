using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTable.Table.User
{
    public class T_ChatStaff
    {
        public int Id { get; set; }
        public Guid IdUser { get; set; }
        public string FullName { get; set; }
        public DateTime DateCreate { get; set; }
        public string Message { get; set; }
    }
}
