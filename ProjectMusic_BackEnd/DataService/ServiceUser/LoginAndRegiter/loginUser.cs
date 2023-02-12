using DataMigration.DataEF;
using DataTable.Table.Account;
using DataTable.Table.RequestUser;
using DataTable.Table.User;
using DataViewModel.ViewModelUser.LoginAndRegiter_Vm;
using DataViewModel.ViewModelUser.ReportBugClient_Vm;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.ServiceUser.LoginAndRegiter
{
    public class loginUser: IloginUser
    {
        private readonly ContextDB context;
        private readonly UserManager<T_User> userManager;
        private readonly SignInManager<T_User> signInManager;
        public loginUser(ContextDB _context, UserManager<T_User> _userManager, SignInManager<T_User> _signInManager)
        {
            context = _context;
            userManager = _userManager;
            signInManager = _signInManager;
        }

        //login
        public async Task<NotifiationLogin> Login(Login_V request)
        {
            var Q_Email = await userManager.FindByEmailAsync(request.Email);
            var Result = new NotifiationLogin();
            var Q_Login = new T_Login();
            if (Q_Email == null)
            {
                Result.Status = false;
                Result.TokenData = null;
                Result.Message = 1;
                return Result;
            }
            if (Q_Email.IdAccountActiver == 2)
            {
                Result.Status = false;
                Result.TokenData = null;
                Result.Message = 4;
                return Result;
            }
            var Q_Password = await signInManager.PasswordSignInAsync(Q_Email, 
                                                                        request.Password,   
                                                                        true, true);
            if(Q_Password.Succeeded == false)
            {
                Result.Status = false;
                Result.TokenData = null;
                Result.Message = 2;
                return Result;
            }
            var GetRole = context.T_UserRoles.FirstOrDefault(x => x.IdUser == Q_Email.IdUser);
            var GetNameRole = context.T_Roles.FirstOrDefault(x => x.IdRole == GetRole.IdRole);
            var GetLever = context.T_LeverUsers.FirstOrDefault(x => x.IdLever == Q_Email.IdLever);
            var GetNameSatffOrUser = context.T_StaffOrUsers.FirstOrDefault(x => x.IdStaffOrUser == Q_Email.IdStaffOrUser);
            var GetMarriage = context.T_Marriages.FirstOrDefault(x => x.IdMarriage == Q_Email.IdMarriage);
            var GetGender = context.T_Genders.FirstOrDefault(x => x.IdGender == Q_Email.IdGender);
            var GetCity = context.T_Cities.FirstOrDefault(x => x.IdCity == Q_Email.IdCity);
            var GetDistrict = context.T_Districts.FirstOrDefault(x => x.IdDistrict == Q_Email.IdDistrict);

            Result.Status = true;
            Result.IdUser = Q_Email.IdUser;
            Result.IdRole = GetRole.IdRole;
            Result.NameRole = GetNameRole.Name;
            Result.SymbolRole = GetNameRole.SymbolRole;
            Result.FullName = Q_Email.FullName;
            Result.Birthday = Q_Email.Birthday.ToString("dd/MM/yyyy");
            Result.Email = Q_Email.Email;
            Result.UserNames = Q_Email.UserName;
            Result.IdAccountActiver = Q_Email.IdAccountActiver;
            Result.Age = Q_Email.Age;
            Result.ImageAvata = Q_Email.ImageAvata;
            Result.Lever = GetLever.Name;
            Result.NameStaffOrUser = GetNameSatffOrUser.Description;
            Result.IdStaff = (Q_Email.IdStaff != null) ? Q_Email.IdStaff : "Exception";
            Result.AddressSatff = (Q_Email.AddressSatff != null) ? Q_Email.AddressSatff : "Exception";
            Result.PhoneMunerStaff = (Q_Email.PhoneStaff != null) ? Q_Email.PhoneStaff : "Exception";
            Result.HireStaff = (Q_Email.CancelHideStaff != null) ? Q_Email.CancelHideStaff : 0;
            Result.Marriage = (GetMarriage != null) ? GetMarriage.NameMarriage : "Exception"; //if GetMarriage.NameMarriage != null save GetMarriage.NameMarriage nguoc lai save null
            Result.Gender = GetGender.NameGender;
            Result.City = GetCity.NameCity;
            Result.District = GetDistrict.NameDistrict;
            Result.DateCreate = Q_Email.DateCreate.ToString("dd/MM/yyyy");

            var Curentdate = DateTime.UtcNow.AddHours(7);
            Q_Login.IdLogin = new Guid();
            Q_Login.IdUser = Q_Email.IdUser;
            Q_Login.DateLogin = Curentdate;
            Q_Login.TimeLogin = Curentdate;
            context.T_Logins.Add(Q_Login);
            context.SaveChanges();

            return Result;
        }

        //logout system
        public bool Logout(Guid IdUser)
        {
            var QuerLogout = context.T_Logins
                                .OrderByDescending(x => x.DateLogin)
                                        .Where(x => x.IdUser == IdUser).ToList();
            int count = 0;
            foreach (var item in QuerLogout)
            {
                count++;
                if(count == 1)
                {
                    item.TimeSignout = DateTime.UtcNow.AddHours(7);
                    context.T_Logins.Update(item);          
                }
                break;
            }
            context.SaveChanges();
            return true;
        }

        //sent report bug login client
        public async Task<NotificationReportBugClient> ReportBugClient(SentReportBugClient_V request)
        {
            // gmail request
            var QueryGmailUser = await context.T_Users.FirstOrDefaultAsync(x => x.Email == request.EmailRegiter);
            var result = new NotificationReportBugClient();
            if(QueryGmailUser == null)
            {
                result.IdStatus = 1; //not find gmail request
                result.Status = false;
            }
            else
            {
                var SetData = new T_RequestPassword()
                {
                    IdReceiveRequest = 1,
                    IdUser = QueryGmailUser.IdUser,
                    NameUser = request.NameSent,
                    TitleRequest = request.TitleReprot,
                    ContentRequest = request.ContentReport,
                    GmailRequest = request.EmailRegiter,
                    ImageRequest = request.ImageBug,
                    DateRequest = request.DateCreate,
                    MineType = request.MineType,
                    TypeImg = request.TypeImage
                };
                await context.T_RequestPasswords.AddAsync(SetData);
                await context.SaveChangesAsync();
                result.IdStatus = 2; //sent report bug success
                result.Status = true;
            }
            return result;
        }

        //get user
        public List<GetUsers> Users()
        {
            var Query_User = context.T_Users.ToList();
            var Query_Role = context.T_Roles.ToList();
            var Query_UserRole = context.T_UserRoles.ToList();
            List<GetUsers> L_Users = new List<GetUsers>();
            foreach (var Item in Query_UserRole)
            {
                var result = new GetUsers()
                {
                    IdRole = Item.IdRole,
                    IdUser = Item.IdUser,
                    UserName = Query_User.FirstOrDefault(x=>x.IdUser == Item.IdUser).UserName,
                    SymbolRole = Query_Role.FirstOrDefault(x=>x.IdRole == Item.IdRole).SymbolRole
                };
                L_Users.Add(result);
            }
            return L_Users;          
        }
    }
}
