using DataMigration.DataEF;
using DataTable.Table.Address;
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
        /// Check data citys in Database
        /// </summary>
        public List<GetAllCity_Vm> CheckDataCityDB(List<GetAllCity_Vm> request)
        {
            var query = _context.T_Cities.ToList();
            var result = new List<GetAllCity_Vm>();
            foreach (var city in request)
            {
                var checkCity = query.FirstOrDefault( x => x.AreaCode == city.AreaCode );
                if (checkCity != null)
                {
                    result.Add(new GetAllCity_Vm()
                    {
                        CityId = checkCity.IdCity,
                        CityName = checkCity.NameCity,
                        Symbol = checkCity.Symbol,
                        AreaCode = checkCity.AreaCode,
                        CreateDate = checkCity.DateCreate.Date,
                        TimeCreate = checkCity.DateCreate.ToShortTimeString()
                    });
                }
            }
            return result;
        }

        /// <summary>
        /// Create Citys
        /// </summary>
        public async Task<NotificationAddress_Vm> CreateCitys(List<GetAllCity_Vm> listCityImport, List<GetAllCity_Vm> listCitiDuplicate)
        {
            var result = new NotificationAddress_Vm();
            foreach (var city in listCityImport)
            {
                var checkCity = listCitiDuplicate.FirstOrDefault(x => x.AreaCode == city.AreaCode);
                if (checkCity == null) {
                    var cretaeCity = new T_City()
                    {
                        NameCity = city.CityName,
                        Symbol = city.Symbol,
                        AreaCode = city.AreaCode,
                        DateCreate = DateTime.UtcNow.AddHours(7)
                    };
                    await _context.T_Cities.AddAsync(cretaeCity);
                }
            }
            await _context.SaveChangesAsync();
            result.status = true;
            return result;
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
                    Symbol = city.Symbol,
                    AreaCode = city.AreaCode,
                    TimeCreate = city.DateCreate.ToShortTimeString()
                });
            }
            return result;

        }



    }
}
