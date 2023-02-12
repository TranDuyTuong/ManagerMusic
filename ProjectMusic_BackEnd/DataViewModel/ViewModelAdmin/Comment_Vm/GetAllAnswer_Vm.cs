using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelAdmin.Comment_Vm
{
    public class GetAllAnswer_Vm
    {
        public int Id { get; set; }
        public int IdComment { get; set; }
        public Guid IsUser { get; set; }
        public string NameUser { get; set; }
        public string NameRole { get; set; }
        public string Answer { get; set; }
        public string DateCreate { get; set; }
        public string TimeCreate { get; set; }
    }
}
