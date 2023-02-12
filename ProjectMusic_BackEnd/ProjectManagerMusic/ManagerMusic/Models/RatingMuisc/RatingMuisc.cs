using DataViewModel.ViewModelUser.RatingClient_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagerMusic.Models.RatingMuisc
{
    public class RatingMuisc
    {
        public List<RatingMusic_V> L_Rating { get; set; }
        public int TotalRating { get; set; }
        public int StatusUser { get; set; }
    }
}
