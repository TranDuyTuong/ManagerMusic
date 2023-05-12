using DataViewModel.ViewModelAdmin.Address_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.ApplicationAdmin.ApplicationAddress.Address_App
{
    public interface IaddressApplication
    {
        /// <summary>
        /// GetAllCitys
        /// </summary>
        PadingCity_Vm GetAllCitys(int pageIndex, int pageSize, int orderBy, string seach);

        /// <summary>
        /// Check Data Citys in DB
        /// </summary>
        List<GetAllCity_Vm> CheckDataCityDB(List<GetAllCity_Vm> request);

        /// <summary>
        /// Create Citys
        /// </summary>
        Task<NotificationAddress_Vm> CreateCitys(List<GetAllCity_Vm> listCityImport, List<GetAllCity_Vm> listCitiDuplicate);

        /// <summary>
        /// Detail City
        /// </summary>
        DetailCity_Vm DetailCity(int IdCity);

        /// <summary>
        /// Update city
        /// </summary>
        Task<NotificationAddress_Vm> EditCitys(EditCity_Vm request);

        /// <summary>
        /// Update city
        /// </summary>
        RemoveCity_Vm GetAllDistrictOrStaffByCity(int IdCity, int Selecion);

        /// <summary>
        /// Remove city
        /// </summary>
        Task<NotificationAddress_Vm> RemoveCity(int IdCity, Guid IdUser);

        /// <summary>
        /// Activer city
        /// </summary>
        Task<NotificationAddress_Vm> ActiverCity(int IdCity, Guid IdUser);

        /// <summary>
        /// Get All City Remove
        /// </summary>
        PadingCity_Vm GetAllCitysRemove(int PageIndex, int PageSize, string seach);
    }
}
