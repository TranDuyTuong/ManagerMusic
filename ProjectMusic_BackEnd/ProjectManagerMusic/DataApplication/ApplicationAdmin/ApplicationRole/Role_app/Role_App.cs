using DataService.ServiceAdmin.Role;
using DataViewModel.ViewModelAdmin.Role_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.ApplicationAdmin.ApplicationRole.Role_app
{
    public class Role_App : Irole_App
    {
        private readonly Iservice_Role context;
        public Role_App(Iservice_Role _context)
        {
            context = _context;
        }

        //get all role
        public List<GetAllRole_V> GetAllRole()
        {
            var result = context.GetAllRole();
            return result;
        }


    }
}
