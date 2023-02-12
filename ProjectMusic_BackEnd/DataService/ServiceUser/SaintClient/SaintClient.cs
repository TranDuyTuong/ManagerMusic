using DataMigration.DataEF;
using DataViewModel.ViewModelUser.SaintClient_Vm;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.ServiceUser.SaintClient
{
    public class SaintClient : IsaintClient
    {
        private readonly ContextDB context;
        public SaintClient(ContextDB _context)
        {
            context = _context;
        }

        //get all saint muisc client
        public async Task<List<GetSaintAll_V>> GetAllSaintClient()
        {
            var QuerySaint = await context.T_Saints.OrderByDescending(x => x.NameSaints).Where(x=>x.IdStatusSaints == 1).ToListAsync();
            var result = new List<GetSaintAll_V>();
            foreach(var item in QuerySaint)
            {
                var setdata = new GetSaintAll_V()
                {
                    Id = item.IdSaints,
                    Name = item.NameSaints,
                    DateCreate = item.DateCreate
                };
                result.Add(setdata);
            }
            return result;
        }
    }
}
