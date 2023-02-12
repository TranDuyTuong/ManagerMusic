using DataApplication.ApplicationUser.ApplicationBuildSoftware.BuildSoftwareUser;
using DataService.ServiceUser.BuildSoftwareClient;
using DataViewModel.ViewModelUser.BuildSoftware_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.ApplicationUser.ApplicationBuildSoftware.BuildSoftwareUser
{
    public class BuildSoftware_App: IbuildSoftware_App
    {
        private readonly IbuildSoftware context;
        public BuildSoftware_App(IbuildSoftware _context)
        {
            context = _context;
        }

        //sent contribute user client
        public async Task<NotificationSentContribute_V> SentContributeUser(SentContributeUser_V request)
        {
            var result = await context.SentContributeUser(request);
            return result;
        }

    }
}
