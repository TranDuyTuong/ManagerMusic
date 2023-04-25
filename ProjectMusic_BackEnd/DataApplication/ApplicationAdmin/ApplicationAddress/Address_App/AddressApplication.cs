using DataService.ServiceAdmin.Address;
using DataViewModel.ViewModelAdmin.Address_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.ApplicationAdmin.ApplicationAddress.Address_App
{
    public class AddressApplication: IaddressApplication
    {
        private readonly Iservice_Citys _context;
        public AddressApplication(Iservice_Citys context)
        {
            _context = context;
        }

        /// <summary>
        /// CheckDataCityDB
        /// </summary>
        public List<GetAllCity_Vm> CheckDataCityDB(List<GetAllCity_Vm> request)
        {
            var result = _context.CheckDataCityDB(request);
            return result;
        }

        /// <summary>
        /// GetAllCitys and pading
        /// </summary>
        public PadingCity_Vm GetAllCitys(int pageIndex, int pageSize, int orderBy, string seach)
        {
            var result = _context.GetAllCitys();
            var padingResult = new PadingCity_Vm();
            if(seach == null)
            {
                // Pading city
                padingResult.l_Citys = result.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            }
            else
            {
                // ToUpper name city
                var l_CitysToUpper = new List<GetAllCity_Vm>();
                foreach(var city in result)
                {
                    l_CitysToUpper.Add(new GetAllCity_Vm()
                    {
                        CityId = city.CityId,
                        CityName = city.CityName.ToUpper(),
                    });
                }

                // Find seach data
                var resultSeach = l_CitysToUpper.Where( x => x.CityName.Contains(seach.ToUpper())).ToList();
                var l_CitysResultSeach = new List<GetAllCity_Vm>();
                foreach(var item in resultSeach)
                {
                    var findCitySeach = result.FirstOrDefault(x => x.CityId == item.CityId);
                    l_CitysResultSeach.Add(new GetAllCity_Vm()
                    {
                        CityId = findCitySeach.CityId,
                        CityName = findCitySeach.CityName,
                        CreateDate = findCitySeach.CreateDate.Date,
                        TimeCreate = findCitySeach.TimeCreate,
                        Symbol = findCitySeach.Symbol,
                        AreaCode = findCitySeach.AreaCode
                    });
                }
                
                // Pading city was seach
                padingResult.l_Citys = l_CitysResultSeach.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
                padingResult.seachCity = seach;
                padingResult.totalSeach = resultSeach.Count();

            }
            padingResult.totalCitys = result.Count();

            return padingResult;
        }


    }
}
