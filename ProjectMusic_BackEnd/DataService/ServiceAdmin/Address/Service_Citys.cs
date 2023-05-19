using DataMigration.DataEF;
using DataService.ServiceAdmin.User;
using DataService.ServiceUser.NotificatonUser;
using DataTable.Table.Address;
using DataViewModel.ViewModelAdmin.Address_Vm;
using DataViewModel.ViewModelUser.Notification_Vm;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace DataService.ServiceAdmin.Address
{
    public class Service_Citys: Iservice_Citys
    {
        private readonly ContextDB _context;
        private readonly INotificationUser _notificationUser;
        private readonly IUser _user;
        public Service_Citys(ContextDB context, INotificationUser notificationUser, IUser user)
        {
            _context = context;
            _notificationUser = notificationUser;
            _user = user;
        }

        /// <summary>
        /// Activer City was remove
        /// </summary>
        public async Task<NotificationAddress_Vm> ActiverCityRemove(int IdCity, Guid IdUser)
        {
            var result = new NotificationAddress_Vm();
            var queryCity = await _context.T_Cities.FirstOrDefaultAsync(x => x.IdCity == IdCity && x.Status == false);
            if(queryCity != null)
            {
                var queryUser = _context.T_Users.FirstOrDefault(x => x.Id == IdUser);
                var queryDistrict = _context.T_Districts.Where(x => x.IdCity == queryCity.IdCity && x.Status == false).ToList();
                // if district have data
                if(queryDistrict.Any())
                {
                    List<T_District> L_DistrictUpdate = new List<T_District>();
                    foreach(var district in queryDistrict)
                    {
                        L_DistrictUpdate.Add(new T_District
                        {
                            IdDistrict = district.IdDistrict,
                            Status = true
                        });
                    }
                    _context.T_Districts.UpdateRange(L_DistrictUpdate);
                }
                //Update City 
                queryCity.Status = true;
                _context.T_Cities.Update(queryCity);
                //add notification
                var L_AllUser = _user.GetAllUser();
                if (L_AllUser.Any() == true)
                {
                    foreach (var item in L_AllUser)
                    {
                        var notification = new CreateNotification_v()
                        {
                            IdUser = item.IdUser,
                            IdViewNotification = 2, // Not view notification
                            IdDeleteNotification = 1, // Not delete notification
                            TitleNotification = "Tỉnh/Tp " + queryCity.NameCity +
                                                " đã được kích hoạt lại, sẻ có " + queryDistrict.Count() + " Quận/huyện được hoạt động trở lại" +
                                                " ,do nhân viên " + queryUser.FullName + " cập nhật.",
                            DateCreate = DateTime.UtcNow.AddHours(7),
                            TimeCreate = DateTime.UtcNow.AddHours(7),
                            AuthorNotification = queryUser.FullName,
                        };
                        _notificationUser.CreateNotification(notification);
                    }
                }
                await _context.SaveChangesAsync();
                result.status = 2; //Activer city success
            }
            else
            {
                result.status = 1; // Not found City request
            }
            return result;
        }


        /// <summary>
        /// Activer Citys Remove
        /// </summary>
        public NotificationAddress_Vm ActiverCitysRemove(List<GetAllCity_Vm> request, Guid IdUser)
        {
            throw new NotImplementedException();
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
                        Status = checkCity.Status,
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
            int count = 0;
            foreach (var city in listCityImport)
            {
                var checkCity = listCitiDuplicate.FirstOrDefault(x => x.AreaCode == city.AreaCode);
                if (checkCity == null) {
                    var cretaeCity = new T_City()
                    {
                        NameCity = city.CityName,
                        Symbol = city.Symbol,
                        AreaCode = city.AreaCode,
                        DateCreate = DateTime.UtcNow.AddHours(7),
                        Status = true
                    };
                    await _context.T_Cities.AddAsync(cretaeCity);
                    count++;
                }
            }
            await _context.SaveChangesAsync();
            result.status = 1; // create citys success
            result.TotalCreateSuccess = count;
            return result;
        }

        /// <summary>
        /// DetailCity
        /// </summary>
        public DetailCity_Vm DetailCity(int IdCity)
        {
           var result = new DetailCity_Vm();
            var queryCity = _context.T_Cities.FirstOrDefault( x => x.IdCity == IdCity);
            if (queryCity != null) {
                var queryDistrict = _context.T_Districts.Where( x => x.IdCity == queryCity.IdCity ).ToList();
                result.Id = queryCity.IdCity;
                result.NameCity = queryCity.NameCity;
                result.Symbol = queryCity.Symbol;
                result.AreaCode = queryCity.AreaCode;
                result.CreateDate = queryCity.DateCreate.Date;
                result.TimeCraete = queryCity.DateCreate.ToShortTimeString();
                result.Status = queryCity.Status;
                foreach(var district in queryDistrict)
                {
                    var AddDistrict = new GetAllDistrict_Vm()
                    {
                        CityId = district.IdCity,
                        DistrictId = district.IdDistrict,
                        NameDistrict = district.NameDistrict,
                        DateCreate = district.DateCreate.Date,
                    };
                    result.L_District.Add(AddDistrict);
                }
            }
            return result;
        }

        /// <summary>
        /// Update City
        /// </summary>
        public async Task<NotificationAddress_Vm> EditCitys(EditCity_Vm request)
        {
            var result = new NotificationAddress_Vm();
            // check id city in DB
            var query = await _context.T_Cities.ToListAsync();
            if(query.Any() == true)
            {
                result.status = 1; //Don't have list city in DB
            }
            else
            {
                var checkCityRequest = query.FirstOrDefault( x => x.IdCity == request.IdCity);
                if(checkCityRequest == null) {
                    result.status = 2; // Don't have city request in DB
                }
                else
                {
                    //check AreaCode
                    if(checkCityRequest.AreaCode == request.AreaCode == true) {
                        result.status = 3; // Have exist a AreaCode in DB
                    }
                    else
                    {
                        //Update Citys in DB
                        checkCityRequest.NameCity = request.Name;
                        checkCityRequest.Symbol = request.Symbol;
                        checkCityRequest.AreaCode = request.AreaCode;
                        _context.T_Cities.Update(checkCityRequest);
                        result.status = 4; // Update citys success
                    }
                }
                await _context.SaveChangesAsync();
            }

            return result;
        }

        /// <summary>
        /// GetAllCitys
        /// </summary>
        public List<GetAllCity_Vm> GetAllCitys()
        {
            var query = _context.T_Cities.Where( x => x.Status == true).ToList();
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

        /// <summary>
        /// GetAll District or staff by city
        /// </summary>
        public List<GetAllCity_Vm> GetAllCitysRemove()
        {
            List<GetAllCity_Vm> l_GetAllCitys = new List<GetAllCity_Vm>();
            var queryCity = _context.T_Cities.Where(x => x.Status == false).ToList();
            if(queryCity.Any() == true)
            {
                foreach (var city in queryCity)
                {
                    l_GetAllCitys.Add(new GetAllCity_Vm()
                    {
                        CityId = city.IdCity,
                        CityName = city.NameCity,
                        CreateDate = city.DateCreate.Date,
                        Symbol = city.Symbol,
                        AreaCode = city.AreaCode,
                        TimeCreate = city.DateCreate.ToShortTimeString(),
                        CityNameUpper = city.NameCity.ToUpper()
                    });
                }
            }
            return l_GetAllCitys.OrderBy( x => x.CityNameUpper).ToList();
        }

        /// <summary>
        /// GetAll District or staff by city
        /// </summary>
        public RemoveCity_Vm GetAllDistrictOrStaffByCity(int IdCity, int Selecion)
        {
            var result = new RemoveCity_Vm();
            var queryCity = _context.T_Cities.FirstOrDefault( x => x.IdCity == IdCity);
            if(queryCity != null)
            {
                switch(Selecion)
                {
                    case 1: // Query District
                        var queryDistrict = _context.T_Districts.Where(x => x.IdCity == IdCity && x.Status == true).ToList();
                        foreach (var itemDistrict in queryDistrict)
                        {
                            result.SelectedDistricts.Add(new District_Selection()
                            {
                                IdDistrict = itemDistrict.IdDistrict,
                                NameDistrict = itemDistrict.NameDistrict,
                                NameCity = itemDistrict.T_Cities.NameCity
                            });
                        }
                        result.Status = 2; 
                        break;
                    case 2: // Query Staff
                        var queryUserStaff = _context.T_Users.Where(x => x.IdCity == IdCity && x.IdStaff != null).ToList();
                        foreach (var itemUserStaff in queryUserStaff)
                        {
                            result.SelectedStaffs.Add(new Staff_Selection()
                            {
                                IdUser = itemUserStaff.IdUser,
                                NameCity = itemUserStaff.T_Citys.NameCity,
                                NameStaff = itemUserStaff.FullName
                            });
                        }
                        result.Status = 3;
                        break;
                    default: // Not Query Selection = 0
                        result.Status = 4;
                        break;
                }
            }
            else
            {
                result.Status = 1; // Not find city
            }
            return result;
        }

        /// <summary>
        /// Remove city by id
        /// </summary>
        public async Task<NotificationAddress_Vm> RemoveCity(int IdCity, Guid IdUser)
        {
            var result = new NotificationAddress_Vm();
            var queryCity = await _context.T_Cities.FirstOrDefaultAsync( x => x.IdCity == IdCity);
            if (queryCity != null)
            {
                //Remove District
                var queryDistrict = await _context.T_Districts.Where(x => x.IdCity == queryCity.IdCity).ToListAsync();
                var queryUser = await _context.T_Users.FirstOrDefaultAsync(x => x.IdUser == IdUser);
                if(queryDistrict.Any() == true)
                {
                    foreach(var itemDistrict in queryDistrict)
                    {
                        itemDistrict.Status = false;
                        _context.T_Districts.Update(itemDistrict);
                    }
                }
                //Remove City
                queryCity.Status = false;
                _context.T_Cities.Update(queryCity);

                //add notification
                var L_AllUser = _user.GetAllUser();
                if (L_AllUser.Any() == true)
                {
                    foreach (var item in L_AllUser)
                    {
                        var notification = new CreateNotification_v()
                        {
                            IdUser = item.IdUser,
                            IdViewNotification = 2, // Not view notification
                            IdDeleteNotification = 1, // Not delete notification
                            TitleNotification = "Tỉnh/Tp " + queryCity.NameCity +
                                                " đã bị ngưng hoạt động vì vậy sẻ có " + queryDistrict.Count() + " Quận/huyện không dùng được" +
                                                " ,do nhân viên " + queryUser.FullName + " cập nhật.",
                            DateCreate = DateTime.UtcNow.AddHours(7),
                            TimeCreate = DateTime.UtcNow.AddHours(7),
                            AuthorNotification = queryUser.FullName,
                        };
                        _notificationUser.CreateNotification(notification);
                    }
                }
                result.status = 2; // remove city success
                await _context.SaveChangesAsync();
            }
            else
            {
                result.status = 1; // Not find id city
            }
            return result;
        }


    }
}
