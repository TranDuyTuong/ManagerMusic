using DataService.ServiceUser.LoginAndRegiter;
using DataViewModel.ViewModelUser.LoginAndRegiter_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataApplication.ApplicationUser.ApplicationSignin.SignInUser
{
    public class UserRegiter_App : IUserRegiter_App
    {
        private readonly IregiterUser context;
        public UserRegiter_App(IregiterUser _context)
        {
            context = _context;
        }

        //user regiter
        public async Task<NotificationRegiter_V> UserRegiter(Regiter_V request)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(request.Email);
            var result = new NotificationRegiter_V();
            if (match.Success == true)
            {
                result = await context.UserRegiter(request);
                return result;
            }
            result.Status = false;
            result.Notification = "Invalid email, please try again!";
            result.IsStatus = 4;
            return result;
        }


    }
}
