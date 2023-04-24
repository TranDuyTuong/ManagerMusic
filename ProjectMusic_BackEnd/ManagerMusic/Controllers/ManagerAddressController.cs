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
            var L_City = new List<GetAllCity_Vm>();
            var result = new ReadDataCityExcel_Vm();
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
                                    AreaCode = Convert.ToInt32(worksheet.Cells[row,4].Value.ToString().Trim()),
                                    CreateDate = DateTime.UtcNow.AddHours(7),
                                });
                            }
                        }

                    }
                    // Add list citys in model result
                    result.L_Citys = L_City;
                    result.TotalCitys = L_City.Count;
                    result.Status = 1; //Have Data
                    break;
                default:
                    result.Status = 2; //No Data
                    break;
            }
            return new JsonResult(0);
        }

    }
}
