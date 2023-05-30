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

        /// <summary>
        /// Get All City was Remove 
        /// </summary>
        List<GetAllDistrict_Vm> CheckDistricDB(List<GetAllDistrict_Vm> request);

        /// <summary>
        /// Get All City was Remove 
        /// </summary>
       Task<NotificationAddress_Vm> CreateDistricts(List<GetAllDistrict_Vm> l_District);
    }
}
