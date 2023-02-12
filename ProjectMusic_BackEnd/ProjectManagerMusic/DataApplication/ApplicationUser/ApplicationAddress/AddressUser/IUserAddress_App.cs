using DataViewModel.ViewModelUser.Address_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.ApplicationUser.ApplicationAddress.AddressUser
{
    public interface IUserAddress_App
    {
        //get all city
        List<GetAllCity_V> GetAllCity();

        //get all district by id city
        NotificationDistrict_V GetAllDistrictById(int IdCity);
    }
}
