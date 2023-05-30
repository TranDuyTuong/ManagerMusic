using DataService.ServiceAdmin.Address;
using DataTable.Table.Address;
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
        private readonly Iservice_Districts _contextDistricts;
        public AddressApplication(Iservice_Citys context, Iservice_Districts contextDistricts)
        {
            _context = context;
            _contextDistricts = contextDistricts;
        }

        /// <summary>
        /// Activer City
        /// </summary>
        public async Task<NotificationAddress_Vm> ActiverCity(int IdCity, Guid IdUser)
        {
            var result = await _context.ActiverCityRemove(IdCity, IdUser);
            return result;
        }

        /// <summary>
        /// Activer Citys Remove
        /// </summary>
        public NotificationAddress_Vm ActiverCitysRemove(string[] ListIdCity, Guid IdUser)
        {
            List<GetAllCity_Vm> listIdCitysActiver = new List<GetAllCity_Vm>();
            // Conver Arry Id City to list Id City
            for(int i = 0; i < ListIdCity.Length; i++)
            {
                listIdCitysActiver.Add(new GetAllCity_Vm()
                {
                    CityId = Convert.ToInt32(ListIdCity[i])
                });
            }
            var result = _context.ActiverCitysRemove(listIdCitysActiver, IdUser);
            return result;
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
        /// Create Citys
        /// </summary>
        public async Task<NotificationAddress_Vm> CreateCitys(List<GetAllCity_Vm> listCityImport, List<GetAllCity_Vm> listCitiDuplicate)
        {
            var result = await _context.CreateCitys(listCityImport, listCitiDuplicate);
            return result;
        }

        /// <summary>
        /// Detail City
        /// </summary>
        public DetailCity_Vm DetailCity(int IdCity)
        {
            var result = _context.DetailCity(IdCity);
            return result;
        }

        /// <summary>
        /// Update City
        /// </summary>
        public async Task<NotificationAddress_Vm> EditCitys(EditCity_Vm request)
        {
            var result = await _context.EditCitys(request);
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

        /// <summary>
        /// GetAll City was remove
        /// </summary>
        public PadingCity_Vm GetAllCitysRemove(int PageIndex, int PageSize, int seach)
        {
            var padingCity = new PadingCity_Vm();
            var result = _context.GetAllCitysRemove();
            if(seach == 0)
            {
                // pading not seach city
                padingCity.l_Citys = result.Skip((PageIndex - 1)*PageSize).Take(PageSize).ToList();
            }
            else
            {
                // pading have seach city
                var seachCitys = result.Where(x => x.AreaCode == seach).ToList();
                padingCity.l_Citys = seachCitys.Skip((PageIndex-1) * PageSize).Take(PageSize).ToList();
                padingCity.seachCity = seach.ToString();
                padingCity.totalSeach = seachCitys.Count();
            }
            padingCity.totalCitys = result.Count();
            return padingCity;
        }

        /// <summary>
        /// GetAll District or staff by city
        /// </summary>
        public RemoveCity_Vm GetAllDistrictOrStaffByCity(int IdCity, int Selecion)
        {

            var result = _context.GetAllDistrictOrStaffByCity(IdCity, Selecion);
            return result;
        }

        /// <summary>
        /// GetAll District or staff by city
        /// </summary>
        public async Task<NotificationAddress_Vm> RemoveCity(int IdCity, Guid IdUser)
        {
            var result = await _context.RemoveCity(IdCity, IdUser);
            return result;
        }


        /// <summary>
        /// GetAllDistricts
        /// </summary>
        public PadingDistrict_Vm GetAllDistricts(int pageIndex, int pageSize, int orderBy, string seach)
        {
            var result = _contextDistricts.GetAllDistricts();
            var padingResult = new PadingDistrict_Vm();
            if (seach == null)
            {
                // Pading district
                padingResult.l_Districts = result.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            }
            else
            {
                // ToUpper name disitrict
                var l_DistrictsToUpper = new List<GetAllDistrict_Vm>();
                foreach (var district in result)
                {
                    l_DistrictsToUpper.Add(new GetAllDistrict_Vm()
                    {
                        DistrictId = district.CityId,
                        NameDistrict = district.NameDistrict.ToUpper(),
                    });
                }

                // Find seach data
                var resultSeach = l_DistrictsToUpper.Where(x => x.NameDistrict.Contains(seach.ToUpper())).ToList();
                var l_DistrictsResultSeach = new List<GetAllDistrict_Vm>();
                foreach (var item in resultSeach)
                {
                    var findCitySeach = result.FirstOrDefault(x => x.DistrictId == item.DistrictId);
                    l_DistrictsResultSeach.Add(new GetAllDistrict_Vm()
                    {
                        DistrictId = findCitySeach.DistrictId,
                        CityId = findCitySeach.CityId,
                        NameDistrict = findCitySeach.NameDistrict,
                        NameCity = findCitySeach.NameCity,
                        Status = findCitySeach.Status,
                        DateCreate = findCitySeach.DateCreate.Date,
                        TimeCreate = findCitySeach.DateCreate.ToShortTimeString()
                    });
                }

                // Pading city was seach
                padingResult.l_Districts = l_DistrictsResultSeach.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
                padingResult.seachDistrict = seach;
                padingResult.totalSeach = resultSeach.Count();

            }
            padingResult.totalDistricts = result.Count();

            return padingResult;
        }

        /// <summary>
        /// Get All Citys By District
        /// </summary>
        public List<GetAllCity_Vm> GetAllCitysByDistrict()
        {
            var result = _context.GetAllCitysByDistrict();
            return result;
        }

        /// <summary>
        /// Check Distric DB
        /// </summary>
        public List<GetAllDistrict_Vm> CheckDistricDB(List<GetAllDistrict_Vm> request)
        {
            var result = _contextDistricts.CheckDistricDB(request);
            return result;
        }

        /// <summary>
        /// CreateDistricts
        /// </summary>
        public async Task<NotificationAddress_Vm> CreateDistricts(List<GetAllDistrict_Vm> listDistrict, List<GetAllDistrict_Vm> listDistrictDuplicate)
        {
            List<GetAllDistrict_Vm> ListResult = new List<GetAllDistrict_Vm>();
            string list_StrDistrict = String.Join(",", listDistrictDuplicate);
            // Get district create not in DB
            for(int ditrict = 0; listDistrict.Count() > ditrict; ditrict++)
            {
                int checkDistrict = list_StrDistrict.IndexOf(listDistrict[ditrict].Identifier);

                // Not find district request in listDistrict
                if (checkDistrict == -1)
                {
                    ListResult.Add(new GetAllDistrict_Vm()
                    {
                        CityId = listDistrict[ditrict].CityId,
                        NameDistrict = listDistrict[ditrict].NameDistrict,
                        DateCreate = DateTime.Now.AddHours(7),
                        Status = true,
                        Identifier = listDistrict[ditrict].Identifier,
                    });
                }
            }
            var result = await _contextDistricts.CreateDistricts(ListResult);
            return result;
        }



    }
}
