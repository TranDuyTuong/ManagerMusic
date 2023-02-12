using DataViewModel.ViewModelAdmin.RequestUser_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagerMusic.Models.Paging.Page_RequestUser
{
    public class PagingRequestUser
    {
        public List<GetAllRequestUser_Vm> L_RequestUser { get; set; }
        public int TotalRequestUser { get; set; }
    }
}
