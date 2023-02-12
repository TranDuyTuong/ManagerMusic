using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel.ViewModelAdmin.Role_Vm
{
    public class RoleHistoryStaff_V
    {
        public int Id { get; set; }
        public Guid IdRole { get; set; }
        public string NameRole { get; set; }
        public DateTime StartDate { get; set; }
        public string TimeSart { get; set; }
        public string StartDate_Str { get; set; }
        public DateTime EndDate { get; set; }
        public string NullEndDate { get; set; }
        public string TimeEnd { get; set; }
        public string EndDate_Str { get; set; }
        public string NameStaff_DecenRole { get; set; }
    }
}
