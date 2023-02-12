using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelAdmin.Music_Vm
{
    public class GetAll_V
    {
        public Guid IdMusic { get; set; } //key
        public int IdSeason { get; set; } //key
        public int IdStatusMusic { get; set; } //key
        public string NoMusic { get; set; }
        public string NameSeason { get; set; }
        public string NameMusic { get; set; }
        public string NameStatusMusic { get; set; }
        public DateTime DateCreate { get; set; }   
        public string TimeCreate { get; set; }
        public string C_dateCreate { get; set; }
    }
}
