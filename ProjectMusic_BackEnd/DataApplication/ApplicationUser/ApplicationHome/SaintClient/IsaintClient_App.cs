using DataViewModel.ViewModelUser.SaintClient_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.ApplicationUser.ApplicationHome.SaintClient
{
    public interface IsaintClient_App
    {
        Task<List<GetSaintAll_V>> GetAllSaintClient();
    }
}
