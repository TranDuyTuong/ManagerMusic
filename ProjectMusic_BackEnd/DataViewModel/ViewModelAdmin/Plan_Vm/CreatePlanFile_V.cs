using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelAdmin.Plan_Vm
{
    public class CreatePlanFile_V
    {
        public int Id { get; set; }
        public int IdPlan { get; set; }
        public string TypeFile { get; set; }
        public string NameFile { get; set; }
        public string MimeType { get; set; }
        public byte[] ContentFile { get; set; }
        public DateTime DateCreate { get; set; }
        public string DateCreate_Str { get; set; }
    }
}
