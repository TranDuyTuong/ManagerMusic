using DataViewModel.ViewModelAdmin.Role_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.ServiceAdmin.Role
{
    public interface Iservice_Role
    {
        //get all role 
        List<GetAllRole_V> GetAllRole();
    }
}
