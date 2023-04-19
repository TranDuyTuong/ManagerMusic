using DataMigration.DataEF;
using DataViewModel.ViewModelAdmin.Address_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.ServiceAdmin.Address
{
    public class Service_Citys: Iservice_Citys
    {
        private readonly ContextDB _context;
        public Service_Citys(ContextDB context)
        {
            _context = context;
        }

        /// <summary>
        /// GetAllCitys
        /// </summary>
        public List<GetAllCity_Vm> GetAllCitys()
        {
            var query = _context.T_Cities.ToList();
            var result = new List<GetAllCity_Vm>();
            foreach (var city in query)
            {
                result.Add(new GetAllCity_Vm()
                {
                    CityId = city.IdCity,
                    CityName = city.NameCity,
                    CreateDate = city.DateCreate.Date,
                    TimeCreate = city.DateCreate.ToShortTimeString()
                });
            }
            return result;

        }



    }
}
