using DataViewModel.ViewModelUser.SeasonClient_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.ServiceUser.SeasonClient
{
    public interface IseasonClient
    {
        //get all season
        Task<List<GetSeasonAll_V>> GetAllSeason();
    }
}
