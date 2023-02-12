using DataMigration.DataEF;
using DataViewModel.ViewModelUser.Address_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.ServiceUser.Address
{
    public class UserAddress : IUserAddress
    {
        private readonly ContextDB context;
        public UserAddress(ContextDB _context)
        {
            context = _context;
        }

        //Get All City
        public List<GetAllCity_V> GetAllCity()
        {
            var Query = context.T_Cities.ToList();
            List<GetAllCity_V> L_City = new List<GetAllCity_V>();
            foreach(var item in Query)
            {
                var ItemCity = new GetAllCity_V()
                {
                    IdCity = item.IdCity,
                    NameCity = item.NameCity,
                };
                L_City.Add(ItemCity);
            }
            return L_City;
        }

        //Get All District By City
        public List<GetAllDistrictById_V> GetAllDistrictById(int IdCity)
        {
            var Query = from D in context.T_Districts
                        join C in context.T_Cities on D.IdCity equals C.IdCity
                        where D.IdCity == IdCity
                        select new { D, C };

            var Result = Query.OrderBy(x=>x.D.NameDistrict).Select(x => new GetAllDistrictById_V()
            {
                IdDistrict = x.D.IdDistrict,
                IdCity = x.D.IdCity,
                NameDistrict = x.D.NameDistrict
            }).ToList();
            return Result;
        }

    }
}
