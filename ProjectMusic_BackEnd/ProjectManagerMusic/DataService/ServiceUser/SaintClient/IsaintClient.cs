using DataViewModel.ViewModelUser.SaintClient_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.ServiceUser.SaintClient
{
    public interface IsaintClient
    {
        //get all saint client
        Task<List<GetSaintAll_V>> GetAllSaintClient();
    }
}
