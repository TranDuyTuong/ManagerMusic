using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelAdmin.Role_Vm
{
    public class RoleStaff_V
    {
        public Guid IdUser { get; set; }
        public string FullName { get; set; }
        public Guid IdRoleCurrent { get; set; }
        public string NameRoleCurrent { get; set; }
        public List<GetAllRole_V> L_Role { get; set; } = new List<GetAllRole_V>();
        public List<RoleHistoryStaff_V> L_HistoryRole { get; set; } = new List<RoleHistoryStaff_V>();
    }
}
