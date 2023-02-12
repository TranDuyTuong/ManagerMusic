using DataViewModel.ViewModelAdmin.RequestUser_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagerMusic.Models.RequestUsers
{
    public class ModalProgressRequestUser
    {
        public List<GetAllRequestUserProgress> L_Notresolved { get; set; }
        public List<GetAllRequestUserProgress> L_Solving { get; set; }
        public List<GetAllRequestUserProgress> L_Solved { get; set; }
    }
}
