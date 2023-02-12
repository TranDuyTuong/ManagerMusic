using DataViewModel.ViewModelUser.BuildSoftware_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.ServiceUser.BuildSoftwareClient
{
    public interface IbuildSoftware
    {
        //get sent contribute user
        Task<NotificationSentContribute_V> SentContributeUser(SentContributeUser_V request);
    }
}
