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

    }
}
