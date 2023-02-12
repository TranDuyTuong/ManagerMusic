using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelAdmin.Rating_Vm
{
    public class GetAllRating_Vm
    {
        public int Id { get; set; }
        public Guid IdMusic { get; set; }
        public Guid IdUser { get; set; }
        public string NameUser { get; set; }
        public string NameRole { get; set; }
        public int Rating { get; set; }
        public string DateCreate { get; set; }
        public string TimeCreate { get; set; }
    }
}
