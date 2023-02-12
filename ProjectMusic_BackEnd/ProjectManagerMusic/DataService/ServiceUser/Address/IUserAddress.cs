using DataViewModel.ViewModelUser.Address_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.ServiceUser.Address
{
    public interface IUserAddress
    {
        //get all city
        List<GetAllCity_V> GetAllCity();

        //get all district by id city
        List<GetAllDistrictById_V> GetAllDistrictById(int IdCity);

    }
}
