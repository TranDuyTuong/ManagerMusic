using DataViewModel.ViewModelAdmin.Address_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.ServiceAdmin.Address
{
    public interface Iservice_Districts
    {
        /// <summary>
        /// GetAllDistricts
        /// </summary>
        List<GetAllDistrict_Vm> GetAllDistricts();
    }
}
