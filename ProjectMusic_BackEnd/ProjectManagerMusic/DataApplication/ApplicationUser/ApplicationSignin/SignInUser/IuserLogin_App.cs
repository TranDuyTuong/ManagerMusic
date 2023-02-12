using DataViewModel.ViewModelUser.LoginAndRegiter_Vm;
using DataViewModel.ViewModelUser.ReportBugClient_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.ApplicationUser.ApplicationSignin.SignInUser
{
    public interface IuserLogin_App
    {
        //login
        Task<NotifiationLogin> Login(Login_V request);

        //get Users
        List<GetUsers> Users();

        //logout
       bool Logout(Guid IdUser);

        //sent report bug not login user
        Task<NotificationReportBugClient> ReportBugClient(SentReportBugClient_V request);
    }
}
