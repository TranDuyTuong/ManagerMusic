using DataMigration.DataEF;
using DataViewModel.ViewModelUser.SeasonClient_Vm;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.ServiceUser.SeasonClient
{
    public class SeasonClient : IseasonClient
    {
        private readonly ContextDB context;
        public SeasonClient(ContextDB _context)
        {
            context = _context;
        }

        //get all season client
        public async Task<List<GetSeasonAll_V>> GetAllSeason()
        {
            var QuerySeason = await context.T_Seasons.OrderByDescending(x => x.NameSeason).ToListAsync();
            var result = new List<GetSeasonAll_V>();
            foreach(var item in QuerySeason)
            {
                var SetData = new GetSeasonAll_V()
                {
                    Id = item.IdSeason,
                    Name = item.NameSeason,
                    DateCreate = item.DateCreate
                };
                result.Add(SetData);
            }
            return result;
        }

    }
}
