using DataViewModel.ViewModelAdmin.RequestUser_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagerMusic.Models.RequestUsers
{
    public class ModalDetaiRequestUser
    {
        public DetailRequestUser_Vm DetailRequest_User { get; set; }
        public List<GetAllStatusRequest_Vm> L_StatusRequest { get; set; }
    }
}
