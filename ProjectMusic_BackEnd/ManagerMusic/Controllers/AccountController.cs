using DataApplication.ApplicationUser.ApplicationAddress.AddressUser;
using DataApplication.ApplicationUser.ApplicationSignin.SignInUser;
using DataViewModel.ViewModelUser.LoginAndRegiter_Vm;
using ManagerMusic.Models.ConvertImgToBase64;
using ManagerMusic.Models.FileImage;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ManagerMusic.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserRegiter_App context;
        private readonly IUserAddress_App Address;
        private readonly IuserLogin_App ServiceLogin;
        public AccountController(IUserRegiter_App _context, IUserAddress_App _Address, IuserLogin_App _ServiceLogin)
        {
            context = _context;
            Address = _Address;
            ServiceLogin = _ServiceLogin;
        }

        private static List<SaveImageByIdUser_V> L_Image = new List<SaveImageByIdUser_V>();
        //login user
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> LoginSystem(Login_V request)
        {
            var result = await ServiceLogin.Login(request);
            if (result.Status == false)
            {
                return new JsonResult(result);
            }
            else
            {
                var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Email, result.Email),
                        new Claim(ClaimTypes.Name, result.FullName),
                        new Claim(ClaimTypes.DateOfBirth, result.Birthday),
                        new Claim(ClaimTypes.Role, result.SymbolRole),
                    };
                var identity = new ClaimsIdentity(
                claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);
                var authProperties = new AuthenticationProperties();
                await HttpContext.SignInAsync(
                      CookieAuthenticationDefaults.AuthenticationScheme,
                      principal, authProperties);
                HttpContext.Response.Cookies.Append("Token", result.TokenData);

                if (result.ImageAvata != null)
                {
                    var CheckItem = L_Image.FirstOrDefault(x => x.IdUser == result.IdUser);
                    if(CheckItem != null)
                    {
                        CheckItem.ImageStaff = result.ImageAvata;
                    }
                    else
                    {
                        var SaveImageData = new SaveImageByIdUser_V()
                        {
                            IdUser = result.IdUser,
                            ImageStaff = result.ImageAvata
                        };
                        L_Image.Add(SaveImageData);
                    }
                }

                if (request.RequestPath == null)
                {
                    result.LinkUrl = "/Home/Index";
                    return new JsonResult(result);
                }
                else
                {
                    if (request.RequestPath.Contains("%3F"))
                    {
                        string[] arrListStr = request.RequestPath.Split("%2F");
                        string[] arrListStr_2 = arrListStr[3].Split("%3F");
                        string[] arrListStr_3 = arrListStr_2[1].Split("%3D");

                        var Url = string.Concat("/", arrListStr[1], "/", arrListStr[2], "/?", arrListStr_3[0], "=", arrListStr_3[1]);
                        result.LinkUrl = Url;
                    }
                    else
                    {
                        string[] arrListStr = request.RequestPath.Split("%2F");
                        var Url = string.Concat("/", arrListStr[1], "/", arrListStr[2]);
                        result.LinkUrl = Url;
                    }
                    return new JsonResult(result);
                }
            }
        }

        //get info token for Home page
        [HttpGet]
        public async Task<IActionResult> JsonClaimsInfo()
        {
            if (User.Identity.IsAuthenticated == true && HttpContext.Request.Cookies["Token"] != null)
            {
                var Stream = HttpContext.Request.Cookies["Token"];
                var hander = new JwtSecurityTokenHandler();
                var jsontoken = hander.ReadToken(Stream);
                var token = jsontoken as JwtSecurityToken;
                var DataClaim = new NotifiationLogin()
                {
                    IdUser = Guid.Parse(token.Claims.FirstOrDefault(x => x.Type == "C_IdUser").Value),
                    IdRole = Guid.Parse(token.Claims.FirstOrDefault(x => x.Type == "C_IdRole").Value),
                    NameRole = token.Claims.FirstOrDefault(x => x.Type == "C_NameRole").Value,
                    SymbolRole = token.Claims.FirstOrDefault(x => x.Type == "C_SymbolRole").Value,
                    FullName = token.Claims.FirstOrDefault(x => x.Type == "C_FullName").Value,
                    Birthday = token.Claims.FirstOrDefault(x => x.Type == "C_Birthday").Value,
                    Email = token.Claims.FirstOrDefault(x => x.Type == "C_Email").Value,
                    UserNames = token.Claims.FirstOrDefault(x => x.Type == "C_UserName").Value,
                    IdAccountActiver = Convert.ToInt32(token.Claims.FirstOrDefault(x => x.Type == "C_IdAccountActiver").Value),
                    Age = Convert.ToInt32(token.Claims.FirstOrDefault(x => x.Type == "C_Age").Value),
                    Lever = token.Claims.FirstOrDefault(x => x.Type == "C_Lever").Value,
                    NameStaffOrUser = token.Claims.FirstOrDefault(x => x.Type == "C_NameStaffOrUser").Value,
                    IdStaff = token.Claims.FirstOrDefault(x => x.Type == "C_IdStaff").Value,
                    AddressSatff = token.Claims.FirstOrDefault(x => x.Type == "C_AddressSatff").Value,
                    PhoneMunerStaff = token.Claims.FirstOrDefault(x => x.Type == "C_PhoneMunerStaff").Value,
                    HireStaff = Convert.ToInt32(token.Claims.FirstOrDefault(x => x.Type == "C_HireStaff").Value),
                    Marriage = token.Claims.FirstOrDefault(x => x.Type == "C_Marriage").Value,
                    Gender = token.Claims.FirstOrDefault(x => x.Type == "C_Gender").Value,
                    City = token.Claims.FirstOrDefault(x => x.Type == "C_City").Value,
                    District = token.Claims.FirstOrDefault(x => x.Type == "C_District").Value,
                    TokenTime = token.Claims.FirstOrDefault(x => x.Type == "C_TokenTime").Value,
                    DateCreate = token.Claims.FirstOrDefault(x => x.Type == "C_DateCreate").Value,

                };
                if (L_Image.Count() != 0)
                {
                    var Find_IdUser = L_Image.FirstOrDefault(x => x.IdUser == DataClaim.IdUser);
                    if (Find_IdUser != null)
                    {
                        DataClaim.ImageAvata = ConvertImage.ConverByeToImage(Convert.ToBase64String(Find_IdUser.ImageStaff));                      
                    }
                }
                return new JsonResult(DataClaim);
            }
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            Response.Cookies.Append(".AspNetCore.Identity.Application", "Token", new CookieOptions()
            {
                Expires = DateTime.Now.AddDays(-1)
            });
            return new JsonResult(0);

        }

        //logOut
        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            var Stream = HttpContext.Request.Cookies["Token"];
            var hander = new JwtSecurityTokenHandler();
            var jsontoken = hander.ReadToken(Stream);
            var token = jsontoken as JwtSecurityToken;
            Guid IdUser = Guid.Parse(token.Claims.FirstOrDefault(x => x.Type == "C_IdUser").Value);
            var result = ServiceLogin.Logout(IdUser);

            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            Response.Cookies.Append(".AspNetCore.Identity.Application", "Token", new CookieOptions()
            {
                Expires = DateTime.Now.AddDays(-1)
            });
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            Response.Cookies.Append("Token", "Token", new CookieOptions()
            {
                Expires = DateTime.Now.AddDays(-1)
            });
            return RedirectToAction("Index", "Home");
        }

        //Forbidden
        [HttpGet]
        public IActionResult AccessDenied()
        {
            return View();
        }

        //Regiter user
        [HttpGet]
        public IActionResult IndexRegiter()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> JsonRegiterUser(Regiter_V request)
        {
            request.Birthday = new DateTime(request.Year, request.Month, request.Date);
            var result = await context.UserRegiter(request);
            return new JsonResult(result);
        }

        //Get All province and city
        [HttpGet]
        public IActionResult JsonGetAllCity()
        {
            var result = Address.GetAllCity();
            return new JsonResult(result);
        }

        //Gett All District by Id City
        [HttpPost]
        public IActionResult JsonGetAllDistrictById(int Id)
        {
            var result = Address.GetAllDistrictById(Id);
            return new JsonResult(result);
        }


    }
}
