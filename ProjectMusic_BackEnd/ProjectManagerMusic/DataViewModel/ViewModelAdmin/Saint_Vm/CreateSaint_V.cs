using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelAdmin.Saint_Vm
{
    public class CreateSaint_V
    {
        public string NameSaint { get; set; }
        public DateTime DateCreate { get; set; }
        public Guid IdUser { get; set; }
        public string FullName { get; set; }
        public string TokenData { get; set; }
        public string IdStaff { get; set; }
        public int IdStatusSaint { get; set; }
    }
}
