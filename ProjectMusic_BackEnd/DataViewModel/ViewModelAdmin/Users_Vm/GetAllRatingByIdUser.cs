using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelAdmin.Users_Vm
{
    public class GetAllRatingByIdUser
    {
        public int Id { get; set; }
        public Guid IdMuisc { get; set; }
        public string NameMuisc { get; set; }
        public string Str_DateCreate { get; set; }
        public DateTime DateCreate { get; set; }
        public int TotalRating { get; set; }
    }
}
