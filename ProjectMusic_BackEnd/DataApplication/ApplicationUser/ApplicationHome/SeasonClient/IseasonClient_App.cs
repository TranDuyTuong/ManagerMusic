using DataViewModel.ViewModelUser.SeasonClient_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.ApplicationUser.ApplicationHome.SeasonClient
{
    public interface IseasonClient_App
    {
        //get all season client
        Task<List<GetSeasonAll_V>> GetAllSeason();
    }
}
