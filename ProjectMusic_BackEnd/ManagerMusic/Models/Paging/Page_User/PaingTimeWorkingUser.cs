using DataViewModel.ViewModelAdmin.Users_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagerMusic.Models.Paging.Page_User
{
    public class PaingTimeWorkingUser
    {
        public List<GetAllTimeWorking_V> L_WorkingTime { get; set; }
        public int TotalTimeWoking { get; set; }
    }
}
