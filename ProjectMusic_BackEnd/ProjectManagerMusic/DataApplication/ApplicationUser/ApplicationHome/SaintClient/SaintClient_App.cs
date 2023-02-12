using DataService.ServiceUser.SaintClient;
using DataViewModel.ViewModelUser.SaintClient_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.ApplicationUser.ApplicationHome.SaintClient
{
    public class SaintClient_App: IsaintClient_App
    {
        private readonly IsaintClient context;
        public SaintClient_App(IsaintClient _context)
        {
            context = _context;
        }

        //get all saint client
        public async Task<List<GetSaintAll_V>> GetAllSaintClient()
        {
            var result = await context.GetAllSaintClient();
            return result;
        }


    }
}
