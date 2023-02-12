using DataViewModel.ViewModelAdmin.User_Vm;
using System.Collections.Generic;

namespace ManagerMusic.Models.Paging.Page_Notification
{
    public class PagingStaff
    {
        public IEnumerable<GetAllUser_v> L_Staff { get; set; }
        public int TotalStaff { get; set; }
    }
}
