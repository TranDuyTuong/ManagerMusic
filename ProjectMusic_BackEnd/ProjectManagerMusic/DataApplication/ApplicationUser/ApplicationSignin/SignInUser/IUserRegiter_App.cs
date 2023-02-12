using DataViewModel.ViewModelUser.LoginAndRegiter_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.ApplicationUser.ApplicationSignin.SignInUser
{
    public interface IUserRegiter_App
    {
        //regiter user
        Task<NotificationRegiter_V> UserRegiter(Regiter_V request);
    }
}
