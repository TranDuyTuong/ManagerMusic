using DataService.ServiceUser.Address;
using DataViewModel.ViewModelUser.Address_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.ApplicationUser.ApplicationAddress.AddressUser
{
    public class UserAddress_App : IUserAddress_App
    {
        private readonly IUserAddress context;
        public UserAddress_App(IUserAddress _context)
        {
            context = _context;
        }

        //Get All City
        public List<GetAllCity_V> GetAllCity()
        {
            var result = context.GetAllCity();
            return result;
        }

        //Get All District By Id City
        public NotificationDistrict_V GetAllDistrictById(int IdCity)
        {
            var Results = context.GetAllDistrictById(IdCity);
            var Result = new NotificationDistrict_V();
            if (Results.Count() == 0)
            {
                Result.L_District = Results;
                Result.Status = false;
            }
            else
            {
                Result.L_District = Results;
                Result.Status = true;               
            }
            return Result;
        }

    }
}
