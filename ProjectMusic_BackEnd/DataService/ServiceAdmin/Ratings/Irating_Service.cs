using DataViewModel.ViewModelAdmin.Rating_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.ServiceAdmin.Ratings
{
    public interface Irating_Service
    {
        //get ratings by id music
        List<GetAllRating_Vm> GetRatingByMusic(Guid IdMusic);
    }
}
