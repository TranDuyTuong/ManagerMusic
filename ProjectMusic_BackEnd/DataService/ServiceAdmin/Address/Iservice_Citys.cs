using DataViewModel.ViewModelAdmin.Address_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.ServiceAdmin.Address
{
    public interface Iservice_Citys
    {
        /// <summary>
        /// GetAllCitys
        /// </summary>
        List<GetAllCity_Vm> GetAllCitys();

        /// <summary>
        /// GetAllCitys
        /// </summary>
        List<GetAllCity_Vm> CheckDataCityDB(List<GetAllCity_Vm> request);

        /// <summary>
        /// GetAllCitys
        /// </summary>
        Task<NotificationAddress_Vm> CreateCitys(List<GetAllCity_Vm> listCityImport, List<GetAllCity_Vm> listCitiDuplicate);

        /// <summary>
        /// GetAllCitys
        /// </summary>
        DetailCity_Vm DetailCity(int IdCity);

        /// <summary>
        /// GetAllCitys
        /// </summary>
        Task<NotificationAddress_Vm> EditCitys(EditCity_Vm request);

        /// <summary>
        /// Check selection District and staff
        /// </summary>
        RemoveCity_Vm GetAllDistrictOrStaffByCity(int IdCity, int Selecion);

        /// <summary>
        /// Remove City by id 
        /// </summary>
        Task<NotificationAddress_Vm> RemoveCity(int IdCity, Guid IdUser);

        /// <summary>
        /// Activer City by id 
        /// </summary>
        Task<NotificationAddress_Vm> ActiverCityRemove(int IdCity, Guid IdUser);

        /// <summary>
        /// Get All City was Remove 
        /// </summary>
        List<GetAllCity_Vm> GetAllCitysRemove();

    }
}
