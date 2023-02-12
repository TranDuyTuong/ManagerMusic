using DataViewModel.ViewModelUser.LoginAndRegiter_Vm;
using DataViewModel.ViewModelUser.ReportBugClient_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.ServiceUser.LoginAndRegiter
{
    public interface IloginUser
    {
        //login system
        Task<NotifiationLogin> Login(Login_V request);

        //Get users
        List<GetUsers> Users();

        //logout system
        bool Logout(Guid IdUser);

        //sent report bug not login user
        Task<NotificationReportBugClient> ReportBugClient(SentReportBugClient_V request);
    }
}
