using DataViewModel.ViewModelAdmin.Users_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagerMusic.Models.Paging.Page_Rating
{
    public class PagingRatingByIdUser
    {
        public List<GetAllRatingByIdUser> L_Rating { get; set; }
        public int TotalRating { get; set; }
    }
}
