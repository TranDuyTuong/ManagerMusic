using DataViewModel.ViewModelAdmin.Rating_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagerMusic.Models.Paging.Page_Rating
{
    public class PagingRatings
    {
        public IEnumerable<GetAllRating_Vm> L_Ratings { get; set; }
        public int TotalRatings { get; set; }
    }
}
