using DataMigration.DataEF;
using DataViewModel.ViewModelAdmin.Role_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.ServiceAdmin.Role
{
    public class Service_Role : Iservice_Role
    {
        private readonly ContextDB context;
        public Service_Role(ContextDB _context)
        {
            context = _context;
        }

        //get all role
        public List<GetAllRole_V> GetAllRole()
        {
            var Query = from r in context.T_Roles
                        where r.SymbolRole != "ND"
                        select new { r };
            var resut = Query.OrderBy(x => x.r.Name).Select(x => new GetAllRole_V
            {
                IdRole = x.r.Id,
                RoleName = x.r.Name,
            }).ToList();
            return resut;
        }


    }
}
