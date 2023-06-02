using DataApplication.ApplicationAdmin.ApplicationAddress.Address_App;
using DataViewModel.ViewModelAdmin.Address_Vm;
using ManagerMusic.Models.ImportFileAddress;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using static DataUtilities.NameRoleSetting;

namespace ManagerMusic.Controllers
{
    [Authorize]
    public class ManagerAddressController : Controller
    {
        private readonly IaddressApplication _context;
        public ManagerAddressController(IaddressApplication context)
        {
            _context = context;
        }

        /// <summary>
        /// L_City
        /// </summary>
        private static List<GetAllCity_Vm> L_City = new List<GetAllCity_Vm>();

        /// <summary>
        /// Duplicate
        /// </summary>
        private static List<GetAllCity_Vm> L_CityDuplicate = new List<GetAllCity_Vm>();

        /// <summary>
        /// L_District
        /// </summary>
        private static List<GetAllDistrict_Vm> L_District = new List<GetAllDistrict_Vm>();

        /// <summary>
        /// Duplicate
        /// </summary>
        private static List<GetAllDistrict_Vm> L_DistrictDuplicate = new List<GetAllDistrict_Vm>();


        /// <summary>
        /// PageCitys
        /// </summary>
        [Authorize(Roles = RoleSetting.symbolRole_Satff + "," + RoleSetting.symbolRole_Admin)]
        [HttpGet]
        public IActionResult PageCitys()
        {
            return View();
        }

        /// <summary>
        /// JsonGetAllCitys
        /// </summary>
        [Authorize(Roles = RoleSetting.symbolRole_Satff + "," + RoleSetting.symbolRole_Admin)]
        [HttpGet]
        public IActionResult JsonGetAllCitys(int pageSize, int pageIndex, string seach, int orderBy)
        {
            var result = _context.GetAllCitys(pageIndex, pageSize, orderBy, seach);
            return new JsonResult(result);
        }

        /// <summary>
        /// Page Create Citys With Excel Import
        /// </summary>
        [Authorize(Roles = RoleSetting.symbolRole_Satff + "," + RoleSetting.symbolRole_Admin)]
        [HttpGet]
        public IActionResult PageCreateCitys()
        {
            return View();
        }

        /// <summary>
        /// Read Content In Excel File Citys
        /// </summary>
        [Authorize(Roles = RoleSetting.symbolRole_Satff + "," + RoleSetting.symbolRole_Admin)]
        [HttpPost]
        public async Task<IActionResult> JsonReadFileExcelCitys(ImportExcel_Citys request)
        {
            var result = new ReadDataCityExcel_Vm();
            //Pading data
            if (L_City.Count() != 0)
            {
                result.Status = 0; //Have Data
                result.L_Citys = L_City.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize).ToList();
            }
            else
            {
                L_City = new List<GetAllCity_Vm>();
                L_CityDuplicate = new List<GetAllCity_Vm>();
                IFormFile ExcelFile = request.FileExcel;
                string[] SplitFile = ExcelFile.FileName.Split('.');
                switch (SplitFile[1])
                {
                    case "xlsx":
                        ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                        using (var stream = new MemoryStream())
                        {
                            await ExcelFile.CopyToAsync(stream);
                            using (var package = new ExcelPackage(stream))
                            {
                                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                                var rowcount = worksheet.Dimension.Rows;
                                for (int row = 3; row <= rowcount; row++)
                                {
                                    L_City.Add(new GetAllCity_Vm
                                    {
                                        CityName = worksheet.Cells[row, 2].Value.ToString().Trim(),
                                        Symbol = worksheet.Cells[row, 3].Value.ToString().Trim(),
                                        AreaCode = Convert.ToInt32(worksheet.Cells[row, 4].Value.ToString().Trim()),
                                        CreateDate = DateTime.UtcNow.AddHours(7),
                                    });
                                }
                            }

                        }
                        // Add list citys in model result
                        result.L_Citys = L_City.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize).ToList();
                        result.Status = 0; //Have Data
                        break;
                    default:
                        result.Status = 2; //No Data
                        break;
                }
            }
            result.TotalCitys = L_City.Count;
            return new JsonResult(result);
        }

        /// <summary>
        /// Check data in database
        /// </summary>
        [Authorize(Roles = RoleSetting.symbolRole_Satff + "," + RoleSetting.symbolRole_Admin)]
        [HttpGet]
        public IActionResult JsonCheckDataBase()
        {
            var result = new ReadDataCityExcel_Vm();
            if (L_City.Count() == 0)
            {
                result.Status = 1; // Not have data in List Citys File
            }
            else
            {
                result.L_Citys = _context.CheckDataCityDB(L_City);
                result.Status = 2; // Find Data duplicate in DB
                result.TotalCitys = result.L_Citys.Count;

                L_CityDuplicate = result.L_Citys;
            }
            return new JsonResult(result);
        }

        /// <summary>
        /// Create data in database
        /// </summary>
        [Authorize(Roles = RoleSetting.symbolRole_Satff + "," + RoleSetting.symbolRole_Admin)]
        [HttpGet]
        public async Task<IActionResult> JsonCreateCitys()
        {
            var result = new NotificationAddress_Vm();
            if (L_City.Count() == 0)
            {
                result.status = 2; // List citys Import Null
            }
            else
            {
                result = await _context.CreateCitys(L_City, L_CityDuplicate);
            }
            L_City = new List<GetAllCity_Vm>();
            L_CityDuplicate = new List<GetAllCity_Vm>();
            return new JsonResult(result);
        }

        /// <summary>
        /// Detail City
        /// </summary>
        /// 
        [Authorize(Roles = RoleSetting.symbolRole_Satff + "," + RoleSetting.symbolRole_Admin)]
        [HttpGet]
        public IActionResult PageDetailCity(int IdCitys)
        {
            ViewBag.IdCity = IdCitys;
            return View();
        }

        /// <summary>
        /// Json get data Detail City
        /// </summary>
        /// 
        [Authorize(Roles = RoleSetting.symbolRole_Satff + "," + RoleSetting.symbolRole_Admin)]
        [HttpGet]
        public IActionResult JsonDetailCitys(int IdCitys)
        {
            var result = _context.DetailCity(IdCitys);
            return new JsonResult(result);
        }

        /// <summary>
        /// Json edit city
        /// </summary>
        [Authorize(Roles = RoleSetting.symbolRole_Satff + "," + RoleSetting.symbolRole_Admin)]
        [HttpPost]
        public async Task<IActionResult> JsonEditCitys(int IdCitys, string nameCity, string symbol, int areaCode)
        {
            var request = new EditCity_Vm();
            var result = new NotificationAddress_Vm();
            if (nameCity == null || nameCity == "" || symbol == null || symbol == "" || areaCode == 0)
            {
                result.status = 5; //Update citys Error;
            }
            else
            {
                request.IdCity = IdCitys;
                request.Name = nameCity;
                request.Symbol = symbol;
                request.AreaCode = areaCode;
                result = await _context.EditCitys(request);
            }
            return new JsonResult(result);
        }

        /// <summary>
        /// Json Show district and staff was remove with city
        /// </summary>
        [Authorize(Roles = RoleSetting.symbolRole_Satff + "," + RoleSetting.symbolRole_Admin)]
        [HttpGet]
        public IActionResult GetAllDistrictOrStaffByCity(int IdCity, int Selection)
        {
            var result = _context.GetAllDistrictOrStaffByCity(IdCity, Selection);
            return new JsonResult(result);
        }

        /// <summary>
        /// Confirm remove city
        /// </summary>
        [Authorize(Roles = RoleSetting.symbolRole_Satff + "," + RoleSetting.symbolRole_Admin)]
        [HttpPost]
        public async Task<IActionResult> RemoveCityById(int IdCity)
        {
            var Stream = HttpContext.Request.Cookies["Token"];
            var hander = new JwtSecurityTokenHandler();
            var jsontoken = hander.ReadToken(Stream);
            var token = jsontoken as JwtSecurityToken;
            Guid IdUser = Guid.Parse(token.Claims.FirstOrDefault(x => x.Type == "C_IdUser").Value);
            //connection to application remove city
            var result = await _context.RemoveCity(IdCity, IdUser);
            return new JsonResult(result);
        }

        /// <summary>
        /// Activer City
        /// </summary>
        [Authorize(Roles = RoleSetting.symbolRole_Satff + "," + RoleSetting.symbolRole_Admin)]
        [HttpGet]
        public async Task<IActionResult> ActiverCity(int IdCity)
        {
            var Stream = HttpContext.Request.Cookies["Token"];
            var hander = new JwtSecurityTokenHandler();
            var jsontoken = hander.ReadToken(Stream);
            var token = jsontoken as JwtSecurityToken;
            Guid IdUser = Guid.Parse(token.Claims.FirstOrDefault(x => x.Type == "C_IdUser").Value);
            //connection to application activer city
            var result = await _context.ActiverCity(IdCity, IdUser);
            return new JsonResult(result);
        }

        /// <summary>
        /// Page Get All Citys Remove
        /// </summary>
        [Authorize(Roles = RoleSetting.symbolRole_Satff + "," + RoleSetting.symbolRole_Admin)]
        [HttpGet]
        public IActionResult PageGetAllCitysRemove()
        {
            return View();
        }

        /// <summary>
        /// Json Get All Citys Remove
        /// </summary>
        [Authorize(Roles = RoleSetting.symbolRole_Satff + "," + RoleSetting.symbolRole_Admin)]
        [HttpGet]
        public IActionResult JsonGetAllCitysRemove(int pageIndex, int pageSize, int seach)
        {
            var result = _context.GetAllCitysRemove(pageIndex, pageSize, seach);
            return new JsonResult(result);
        }

        /// <summary>
        /// Json Activer Citys Reomve
        /// </summary>
        [Authorize(Roles = RoleSetting.symbolRole_Satff + "," + RoleSetting.symbolRole_Admin)]
        [HttpPost]
        public IActionResult JsonActiverCitysRemove(string[] lIdCitysActiver)
        {
            // Get User Login Current
            var Stream = HttpContext.Request.Cookies["Token"];
            var hander = new JwtSecurityTokenHandler();
            var jsontoken = hander.ReadToken(Stream);
            var token = jsontoken as JwtSecurityToken;
            Guid IdUser = Guid.Parse(token.Claims.FirstOrDefault(x => x.Type == "C_IdUser").Value);
            var result = _context.ActiverCitysRemove(lIdCitysActiver, IdUser);
            return new JsonResult(result);
        }

        /// <summary>
        /// PageDistrict
        /// </summary>
        [Authorize(Roles = RoleSetting.symbolRole_Satff + "," + RoleSetting.symbolRole_Admin)]
        [HttpGet]
        public IActionResult PageDistricts()
        {
            return View();
        }

        /// <summary>
        /// JsonGetAllDistricts
        /// </summary>
        [Authorize(Roles = RoleSetting.symbolRole_Satff + "," + RoleSetting.symbolRole_Admin)]
        [HttpGet]
        public IActionResult JsonGetAllDistricts(int pageSize, int pageIndex, string seach, int orderBy)
        {
            var result = _context.GetAllDistricts(pageIndex, pageSize, orderBy, seach);
            return new JsonResult(result);
        }

        /// <summary>
        /// Page Create Districts With Excel Import
        /// </summary>
        [Authorize(Roles = RoleSetting.symbolRole_Satff + "," + RoleSetting.symbolRole_Admin)]
        [HttpGet]
        public IActionResult PageCreateDistricts()
        {
            return View();
        }

        /// <summary>
        /// Read Content In Excel File Districts
        /// </summary>
        [Authorize(Roles = RoleSetting.symbolRole_Satff + "," + RoleSetting.symbolRole_Admin)]
        [HttpPost]
        public async Task<IActionResult> JsonReadFileExcelDistricts(ImportExcel_Districts request)
        {
            var result = new ReadDataDistrictExcel_Vm();
            //Pading data
            if (L_District.Count() != 0)
            {
                result.Status = 0; //Have Data
                result.L_Districts = L_District.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize).ToList();
            }
            else
            {
                L_District = new List<GetAllDistrict_Vm>();
                L_DistrictDuplicate = new List<GetAllDistrict_Vm>();
                // Get All Citys
                var citysList = _context.GetAllCitysByDistrict();
                IFormFile ExcelFile = request.FileExcel;
                string[] SplitFile = ExcelFile.FileName.Split('.');
                switch (SplitFile[1])
                {
                    case "xlsx":
                        ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                        using (var stream = new MemoryStream())
                        {
                            await ExcelFile.CopyToAsync(stream);
                            using (var package = new ExcelPackage(stream))
                            {
                                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                                var rowcount = worksheet.Dimension.Rows;
                                for (int row = 3; row <= rowcount; row++)
                                {
                                    var findCity = citysList.FirstOrDefault(x => x.CityId == Convert.ToInt32(worksheet.Cells[row, 2].Value.ToString().Trim()));
                                    if (findCity != null)
                                    {
                                        L_District.Add(new GetAllDistrict_Vm
                                        {
                                            CityId = findCity.CityId,
                                            NameDistrict = worksheet.Cells[row, 3].Value.ToString().Trim(),
                                            DateCreate = DateTime.UtcNow.AddHours(7),
                                            NameCity = findCity.CityName,
                                            Identifier = worksheet.Cells[row, 4].Value.ToString().Trim(),
                                            TimeCreate = DateTime.Now.ToShortTimeString()
                                        });
                                    }
                                }
                            }

                        }
                        // Add list citys in model result
                        result.L_Districts = L_District.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize).ToList();
                        result.Status = 0; //Have Data
                        break;
                    default:
                        result.Status = 2; //No Data
                        break;
                }
            }
            result.TotalDistricts = L_District.Count;
            return new JsonResult(result);
        }

        /// <summary>
        /// Check data districts in database
        /// </summary>
        [Authorize(Roles = RoleSetting.symbolRole_Satff + "," + RoleSetting.symbolRole_Admin)]
        [HttpGet]
        public IActionResult JsonCheckDataBaseDistrict()
        {
            var result = new ReadDataDistrictExcel_Vm();
            if (L_District.Count() == 0)
            {
                result.Status = 1; // Not have data in List Citys File
            }
            else
            {
                result.L_Districts = _context.CheckDistricDB(L_District);
                result.Status = 2; // Find Data duplicate in DB
                result.TotalDistricts = result.L_Districts.Count;

                L_DistrictDuplicate = result.L_Districts;
            }
            return new JsonResult(result);
        }

        /// <summary>
        /// Create data in database
        /// </summary>
        [Authorize(Roles = RoleSetting.symbolRole_Satff + "," + RoleSetting.symbolRole_Admin)]
        [HttpGet]
        public async Task<IActionResult> JsonCreateDistricts()
        {
            var result = new NotificationAddress_Vm();
            if (L_District.Count() == 0)
            {
                result.status = 2; // List citys Import Null
                result.TotalCreateSuccess = 0;
            }
            else
            {
                // get current user login
                var Stream = HttpContext.Request.Cookies["Token"];
                var hander = new JwtSecurityTokenHandler();
                var jsontoken = hander.ReadToken(Stream);
                var token = jsontoken as JwtSecurityToken;
                Guid IdUser = Guid.Parse(token.Claims.FirstOrDefault(x => x.Type == "C_IdUser").Value);

                var listIdentifierDistricts = new List<GetAllDistrict_Vm>();
                if (L_DistrictDuplicate.Any() == true)
                {
                    // Get list Identifier in list district DB
                    foreach (var district in L_DistrictDuplicate)
                    {
                        listIdentifierDistricts.Add(new GetAllDistrict_Vm()
                        {
                            Identifier = district.Identifier,
                        });
                    }
                }
                result = await _context.CreateDistricts(L_District, listIdentifierDistricts, IdUser);
            }
            L_District = new List<GetAllDistrict_Vm>();
            L_DistrictDuplicate = new List<GetAllDistrict_Vm>();
            return new JsonResult(result);
        }


    }
}
