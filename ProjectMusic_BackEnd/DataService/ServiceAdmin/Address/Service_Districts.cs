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
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using DataViewModel.ViewModelUser.Notification_Vm;
using Microsoft.EntityFrameworkCore;

namespace DataService.ServiceAdmin.Address
{
    public class Service_Districts : Iservice_Districts
    {
        private readonly ContextDB _context;
        private readonly INotificationUser _notificationUser;
        private readonly IUser _user;
        private readonly IConfiguration _config;
        public Service_Districts(ContextDB context, INotificationUser notificationUser, IUser user, IConfiguration config)
        {
            _context = context;
            _notificationUser = notificationUser;
            _user = user;
            _config = config;
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
           var query = from district in _context.T_Districts
                       join city in _context.T_Cities on district.IdCity equals city.IdCity
                       select new {city, district};
            List<GetAllDistrict_Vm> l_districtDB = new List<GetAllDistrict_Vm>();
            foreach (var item in query)
            {
                var checkData = request.FirstOrDefault(x => Convert.ToInt32(x.Identifier) == Convert.ToInt32(item.district.Identifier));
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

        /// <summary>
        /// CreateDistricts
        /// </summary>
        public async Task<NotificationAddress_Vm> CreateDistricts(List<GetAllDistrict_Vm> l_District, Guid IdUser)
        {
            var result = new NotificationAddress_Vm();
            int count = 0;
            if(l_District.Any() == true)
            {
                var queryUser = await _context.T_Users.FirstOrDefaultAsync(x => x.IdUser == IdUser);
                var districtsModal = new List<T_District>();
                foreach(var item in l_District)
                {
                    count++;
                    districtsModal.Add(new T_District()
                    {
                        IdCity = item.CityId,
                        NameDistrict = item.NameDistrict,
                        DateCreate = item.DateCreate,
                        Status = item.Status,
                        Identifier = item.Identifier
                    });
                }
                await _context.T_Districts.AddRangeAsync(districtsModal);
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
                            TitleNotification = "Đã có " + count + " Quận/huyện" +
                                                " đã được tạo mới" +
                                                " ,do nhân viên " + queryUser.FullName + " cập nhật.",
                            DateCreate = DateTime.UtcNow.AddHours(7),
                            TimeCreate = DateTime.UtcNow.AddHours(7),
                            AuthorNotification = queryUser.FullName,
                        };
                        _notificationUser.CreateNotification(notification);
                    }
                }
                await _context.SaveChangesAsync();
                result.status = 1; // create district success
                result.TotalCreateSuccess = count;
                //var cmdText = @"
                //    insert into dbo.Districts(IdCity, NameDistrict, DateCreate, Status, Identifier)
                //    select IdCity, NameDistrict, DateCreate, Status, Identifier
                //    from @l_Districts
                //";
                //using (var copy = new SqlBulkCopy(connectionString))
                //{
                //    copy.DestinationTableName = "dbo.Customers";
                //    // Add mappings so that the column order doesn't matter
                //    copy.ColumnMappings.Add(nameof(Customer.Id), "Id");
                //    copy.ColumnMappings.Add(nameof(Customer.FirstName), "FirstName");
                //    copy.ColumnMappings.Add(nameof(Customer.LastName), "LastName");
                //    copy.ColumnMappings.Add(nameof(Customer.Street), "Street");
                //    copy.ColumnMappings.Add(nameof(Customer.City), "City");
                //    copy.ColumnMappings.Add(nameof(Customer.State), "State");
                //    copy.ColumnMappings.Add(nameof(Customer.PhoneNumber), "PhoneNumber");
                //    copy.ColumnMappings.Add(nameof(Customer.EmailAddress), "EmailAddress");

                //    copy.WriteToServer(ToDataTable(customers));
                //}
                //using (var connection = new SqlConnection(_config.GetConnectionString("ManagerMusicDatabase")))
                //{
                //        var command = new SqlCommand(cmdText, connection);
                //    var param = command.Parameters.AddWithValue("@l_Districts", ToDataTable(l_District));
                //        connection.Open();
                //        command.ExecuteNonQuery();
                //}
            }
            else
            {
                result.status = 0; // don't have district for create
                result.TotalCreateSuccess = count;
            }
            return result;
        }



    }
}
