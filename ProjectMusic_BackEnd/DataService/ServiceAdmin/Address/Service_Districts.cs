using DataMigration.DataEF;
using DataService.ServiceAdmin.User;
using DataService.ServiceUser.NotificatonUser;
using DataTable.Table.Address;
using DataViewModel.ViewModelAdmin.Address_Vm;
using Org.BouncyCastle.Math.EC.Rfc7748;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.ServiceAdmin.Address
{
    public class Service_Districts : Iservice_Districts
    {
        private readonly ContextDB _context;
        private readonly INotificationUser _notificationUser;
        private readonly IUser _user;
        public Service_Districts(ContextDB context, INotificationUser notificationUser, IUser user)
        {
            _context = context;
            _notificationUser = notificationUser;
            _user = user;
        }


        /// <summary>
        /// GetAllDistricts
        /// </summary>
        public List<GetAllDistrict_Vm> GetAllDistricts()
        {
            var query = from city in _context.T_Cities
                        join district in _context.T_Districts on city.IdCity  equals district.IdCity
                        where district.Status == true
                        select new {city, district};

            var result = new List<GetAllDistrict_Vm>();
            foreach (var item in query)
            {
                result.Add(new GetAllDistrict_Vm()
                {
                    DistrictId = item.district.IdDistrict,
                    CityId = item.district.IdCity,
                    NameDistrict = item.district.NameDistrict,
                    NameCity = item.city.NameCity,
                    Status = item.district.Status,
                    DateCreate = item.district.DateCreate.Date,
                    TimeCreate = item.district.DateCreate.ToShortTimeString()
                });
            }
            return result;
        }

        /// <summary>
        /// CheckDistricDB
        /// </summary>
        public List<GetAllDistrict_Vm> CheckDistricDB(List<GetAllDistrict_Vm> request)
        {
           // Get all district in DB
           var query = from city in _context.T_Cities
                       join district in _context.T_Districts on city.IdCity equals district.IdDistrict
                       select new {city, district};
            List<GetAllDistrict_Vm> l_districtDB = new List<GetAllDistrict_Vm>();
            foreach (var item in query)
            {
                var checkData = request.FirstOrDefault(x => x.Identifier == item.district.Identifier);
                if(checkData != null)
                {
                    l_districtDB.Add(new GetAllDistrict_Vm
                    {
                        DistrictId = item.district.IdDistrict,
                        CityId = item.city.IdCity,
                        NameDistrict = item.district.NameDistrict,
                        DateCreate = item.district.DateCreate,
                        NameCity = item.city.NameCity,
                        TimeCreate = item.district.DateCreate.ToShortTimeString(),
                        Status = item.district.Status,
                        Identifier = item.district.Identifier
                    });
                }
            }
            return l_districtDB;
        }


    }
}
