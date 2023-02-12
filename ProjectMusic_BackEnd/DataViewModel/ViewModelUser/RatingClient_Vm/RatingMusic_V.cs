using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelUser.RatingClient_Vm
{
    public class RatingMusic_V
    {
        public int IdRating { get; set; }
        public Guid IsUser { get; set; }
        public Guid IdMuisc { get; set; }
        public int Ratings { get; set; }
        public string NameUser { get; set; }
        public string Str_DateCreate { get; set; }
        public DateTime DateCreate { get; set; }
    }
}
