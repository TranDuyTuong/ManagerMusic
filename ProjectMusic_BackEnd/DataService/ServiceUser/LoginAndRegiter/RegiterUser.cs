using DataMigration.DataEF;
using DataService.ServiceAdmin.User;
using DataService.ServiceUser.NotificatonUser;
using DataTable.Table.Role;
using DataTable.Table.User;
using DataViewModel.ViewModelUser.LoginAndRegiter_Vm;
using DataViewModel.ViewModelUser.Notification_Vm;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.ServiceUser.LoginAndRegiter
{
    public class RegiterUser : IregiterUser
    {
        private readonly ContextDB context;
        private readonly UserManager<T_User> userManager;
        private readonly INotificationUser notificationUser;
        private readonly IUser users;

        public RegiterUser(ContextDB _context, 
                           UserManager<T_User> _userManager, 
                           INotificationUser _notificationUser,
                           IUser _users)
        {
            context = _context;
            userManager = _userManager;
            notificationUser = _notificationUser;
            users = _users;
        }

        //regiter user
        public async Task<NotificationRegiter_V> UserRegiter(Regiter_V request)
        {
            var NotificationUser = new NotificationRegiter_V();
            var QueryRole = context.T_Roles.FirstOrDefault(x => x.SymbolRole == "ND");
            var DataEmail = await userManager.FindByEmailAsync(request.Email);
            if(DataEmail != null)
            {
                NotificationUser.Status = false;
                NotificationUser.Notification = "Email already exists, please change Email!";
                NotificationUser.IsStatus = 1;
                return NotificationUser;
            }
            var IdGuild = new Guid();
            var Regiter = new T_User()
            {
                IdUser = IdGuild,
                Id = IdGuild,
                IdAccountActiver = 1,
                IdLever = 1,
                IdGender = request.Gender,
                IdCity = request.IdCity,
                IdDistrict = request.IdDitrict,
                IdStaffOrUser = 1,
                FullName = request.FullName,
                UserName = request.Email,
                Birthday = request.Birthday,
                Date = request.Date,
                Month = request.Month,
                Year = request.Year,
                Email = request.Email,
                DateCreate = DateTime.UtcNow.AddHours(7),
                Age = DateTime.UtcNow.Year - request.Year,
            };
            var Result = await userManager.CreateAsync(Regiter, request.Password);
            if(Result.Succeeded == true)
            {
                var AddIdUser = context.T_Users.FirstOrDefault(x => x.IdUser == Regiter.IdUser);
                AddIdUser.Id = Regiter.IdUser;
                context.T_Users.Update(AddIdUser);

                var RoleUser = new T_UserRole()
                {
                    IdRole = QueryRole.IdRole,
                    IdUser = Regiter.IdUser
                };
                context.T_UserRoles.Add(RoleUser);
                //add notification
                var L_AllUser = users.GetAllUser();
                if(L_AllUser.Count() != 0)
                {
                    foreach (var item in L_AllUser)
                    {
                        var Result_N = new CreateNotification_v()
                        {
                            IdUser = item.IdUser,
                            IdViewNotification = 2,
                            IdDeleteNotification = 1,
                            TitleNotification = "Có một thành viên đã đăng ký tài khoản là: " + AddIdUser.FullName,
                            DateCreate = DateTime.UtcNow.AddHours(7),
                            TimeCreate = DateTime.UtcNow.AddHours(7),
                            AuthorNotification = AddIdUser.FullName,
                        };
                        notificationUser.CreateNotification(Result_N);
                    }
                }
                context.SaveChanges();

                NotificationUser.Status = true;
                NotificationUser.Notification = "Regiter account success, you can go to login";
                NotificationUser.IsStatus = 2;
                return NotificationUser;
            }
            NotificationUser.Status = false;
            NotificationUser.Notification = "Regiter error, please try again!";
            NotificationUser.IsStatus = 4;
            return NotificationUser;
        }


    }
}
