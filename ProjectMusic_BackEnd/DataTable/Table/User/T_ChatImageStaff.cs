using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTable.Table.User
{
    public class T_ChatImageStaff
    {
        public int Id { get; set; }
        public string NameImage { get; set; }
        public string TypeImage { get; set; }
        public byte[] FileImage { get; set; }
        public DateTime DateCreate { get; set; }
        public string MimeType { get; set; }
        public int IdChat { get; set; }
        public string ImageBase64 { get; set; }
    }
}
