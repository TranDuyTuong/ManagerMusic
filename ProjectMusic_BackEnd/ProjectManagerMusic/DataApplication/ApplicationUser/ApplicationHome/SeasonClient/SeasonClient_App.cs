using DataService.ServiceUser.SeasonClient;
using DataViewModel.ViewModelUser.SeasonClient_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.ApplicationUser.ApplicationHome.SeasonClient
{
    public class SeasonClient_App : IseasonClient_App
    {
        private readonly IseasonClient context;
        public SeasonClient_App(IseasonClient _context)
        {
            context = _context;
        }

        //get all season 
        public async Task<List<GetSeasonAll_V>> GetAllSeason()
        {
            var result = await context.GetAllSeason();
            return result;
        }

    }
}
