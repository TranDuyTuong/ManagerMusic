using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelAdmin.Comment_Vm
{
    public class GetAllComment_Vm
    {
        public int Id { get; set; }
        public Guid IdMusic { get; set; }
        public Guid IdUser { get; set; }
        public string NameUser { get; set; }
        public string NameRole { get; set; }
        public string Comment { get; set; }
        public string DateCreate { get; set; }
        public string TimeCreate { get; set; }
        public List<GetAllAnswer_Vm> L_Answer { get; set; }
    }
}
