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
    }
}
