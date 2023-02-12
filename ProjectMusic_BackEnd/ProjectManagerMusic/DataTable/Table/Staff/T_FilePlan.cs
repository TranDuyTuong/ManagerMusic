using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTable.Table.Staff
{
    public class T_FilePlan
    {
        public int IdFile { get; set; }
        public int IdPlan { get; set; }
        public string NameFile { get; set; }
        public string TypeFile { get; set; }
        public string MimeType { get; set; }
        public byte[] ContentFile { get; set; }
        public DateTime DateCreate { get; set; }

    }
}
