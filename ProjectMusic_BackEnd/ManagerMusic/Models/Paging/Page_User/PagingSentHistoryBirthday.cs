using DataViewModel.ViewModelAdmin.Users_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagerMusic.Models.Paging.Page_User
{
    public class PagingSentHistoryBirthday
    {
        public List<GetAllSentBirthdayUser_V> L_MessageSent { get; set; }
        public int TotalMessage { get; set; }
    }
}
