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
                result.L_Citys = L_City.Skip((request.PageIndex - 1)* request.PageSize).Take(request.PageSize).ToList();
            }
            else
            {
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
            if(L_City.Count() == 0)
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
            if(nameCity == null || nameCity == "" || symbol == null || symbol == "" || areaCode == 0) {
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

    }
}
