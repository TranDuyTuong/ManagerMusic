using DataService.ServiceUser.LoginAndRegiter;
using DataViewModel.ViewModelUser.LoginAndRegiter_Vm;
using DataViewModel.ViewModelUser.ReportBugClient_Vm;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataApplication.ApplicationUser.ApplicationSignin.SignInUser
{
    public class UserLogin_App: IuserLogin_App
    {
        private readonly IloginUser context;
        private readonly IConfiguration _config;
        public UserLogin_App(IloginUser _context , IConfiguration config)
        {
            context = _context;
            _config = config;
        }

        //login
        public async Task<NotifiationLogin> Login(Login_V request)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(request.Email);
            var result = new NotifiationLogin();
            if (match.Success == false)
            {
                result.Status = false;
                result.Message = 3;
                result.TokenData = null;
                return result;
            }
            result = await context.Login(request);
            if(result.Status == false)
            {
                return result;
            }
            var CurentTime = DateTime.UtcNow.AddHours(7);
            var UpdateTime = CurentTime.AddHours(1);
            var claims = new[]
            {
                new Claim("C_IdUser", result.IdUser.ToString()),
                new Claim("C_IdRole", result.IdRole.ToString()),
                new Claim("C_NameRole", result.NameRole),
                new Claim("C_SymbolRole", result.SymbolRole),
                new Claim("C_FullName", result.FullName),
                new Claim("C_Birthday", result.Birthday),
                new Claim("C_Email", result.Email),
                new Claim("C_IdAccountActiver", result.IdAccountActiver.ToString()),
                new Claim("C_Age", result.Age.ToString()),
                new Claim("C_Lever", result.Lever),
                new Claim("C_NameStaffOrUser", result.NameStaffOrUser),
                new Claim("C_IdStaff", result.IdStaff),
                new Claim("C_AddressSatff", result.AddressSatff),
                new Claim("C_PhoneMunerStaff", result.PhoneMunerStaff),
                new Claim("C_HireStaff", result.HireStaff.ToString()),
                new Claim("C_Marriage", result.Marriage),
                new Claim("C_Gender", result.Gender),
                new Claim("C_City", result.City),
                new Claim("C_District", result.District),
                new Claim("C_TokenTime", UpdateTime.ToString()),
                new Claim("C_UserName", result.UserNames),
                new Claim("C_DateCreate", result.DateCreate),
            };
            //create token
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                _config["Tokens:Issuer"],
                _config["Tokens:Issuer"],
                claims,
                expires: CurentTime.AddHours(1),
                signingCredentials: creds
                );

            result.TokenData = new JwtSecurityTokenHandler().WriteToken(token);
            return result;
        }

        //logout
        public bool Logout(Guid IdUser)
        {
            var result = context.Logout(IdUser);
            return result;
        }

        //report bug user client login
        public async Task<NotificationReportBugClient> ReportBugClient(SentReportBugClient_V request)
        {
            var result = await context.ReportBugClient(request);
            return result;
        }

        //get user
        public List<GetUsers> Users()
        {
            var result = context.Users();
            return result;
        }
    }
}
