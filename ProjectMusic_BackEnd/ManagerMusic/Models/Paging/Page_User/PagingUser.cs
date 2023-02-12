using DataViewModel.ViewModelAdmin.Users_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagerMusic.Models.Paging.Page_User
{
    public class PagingUser
    {
        public List<GetAllUsers_V> L_User { get; set; }
        public int TotalUser { get; set; }
    }
}
