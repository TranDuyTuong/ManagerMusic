using DataViewModel.ViewModelUser.LoginAndRegiter_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.ServiceUser.LoginAndRegiter
{
    public interface IregiterUser
    {
        Task<NotificationRegiter_V> UserRegiter(Regiter_V request);
    }
}
