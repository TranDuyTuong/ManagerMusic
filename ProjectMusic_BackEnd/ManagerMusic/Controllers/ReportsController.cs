using ClosedXML.Excel;
using DataApplication.ApplicationAdmin.ApplicationReports.Reports_app;
using DataViewModel.ViewModelAdmin.Report_Vm;
using ManagerMusic.Models.Paging.Page_Reports;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using static DataUtilities.NameRoleSetting;

namespace ManagerMusic.Controllers
{
    [Authorize]
    public class ReportsController : BaseController
    {
        private readonly Ireport_App context;
        private readonly IConfiguration Confi;
        public ReportsController(Ireport_App _context, IConfiguration _Confi)
        {
            context = _context;
            Confi = _Confi;
        }
        //page manager all report 
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public IActionResult Page_Report()
        {
            return View();
        }

        //page manager file muisc report
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public IActionResult Page_FileReport()
        {
            return View();
        }

        //get all music
        private static List<DowLoadMusic_V> L_DowloadFileM = new List<DowLoadMusic_V>();

        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public async Task<IActionResult> JsonGetAllMusic(int pageSize, int pageIndex, 
                                                            int IdFlap, string SeachAuthor, int IdSeason,
                                                            int IdSaints, string SeachDate)
        {
            var result = await context.GetAllReportMusic();
            var ModalPaging = new PagingReports();
            switch (IdFlap)
            {
                case 0:
                    L_DowloadFileM = new List<DowLoadMusic_V>();
                    ModalPaging.L_ReportMusic = result.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
                    ModalPaging.TotalMusic = result.Count();
                    break;
                case 1:
                    L_DowloadFileM = result;
                    ModalPaging.L_ReportMusic = result.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
                    ModalPaging.TotalMusic = result.Count();
                    break;
                case 2:
                    L_DowloadFileM = result.Where(x=>x.Author.Contains(SeachAuthor)).ToList();
                    ModalPaging.L_ReportMusic = L_DowloadFileM.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
                    ModalPaging.TotalMusic = L_DowloadFileM.Count();
                    break;
                case 3:
                    L_DowloadFileM = result.Where(x => x.IdSeason == IdSeason).ToList();
                    ModalPaging.L_ReportMusic = L_DowloadFileM.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
                    ModalPaging.TotalMusic = L_DowloadFileM.Count();
                    break;
                case 4:
                    L_DowloadFileM = result.Where(x => x.IsSaint == IdSaints).ToList();
                    ModalPaging.L_ReportMusic = L_DowloadFileM.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
                    ModalPaging.TotalMusic = L_DowloadFileM.Count();
                    break;
                case 5:
                    string[] strDateCreate = SeachDate.Split(" to ");
                    var DateFrom = Convert.ToDateTime(strDateCreate[0]).Date;
                    var DateTo = Convert.ToDateTime(strDateCreate[1]).Date;
                    L_DowloadFileM = result.Where(x => x.DateCreate.Date >= DateFrom && x.DateCreate.Date <= DateTo
                                                                   ).ToList();
                    ModalPaging.L_ReportMusic = L_DowloadFileM.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
                    ModalPaging.TotalMusic = L_DowloadFileM.Count();
                    break;
            }
            return new JsonResult(ModalPaging);
        }

        //dowload all file music
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public IActionResult DowLoadAllMusic()
        {
            var Stream = HttpContext.Request.Cookies["Token"];
            var hander = new JwtSecurityTokenHandler();
            var jsontoken = hander.ReadToken(Stream);
            var token = jsontoken as JwtSecurityToken;
            string NameRole = token.Claims.FirstOrDefault(x => x.Type == "C_NameRole").Value;
            string NameStaff = token.Claims.FirstOrDefault(x => x.Type == "C_FullName").Value;
            string IdStaff = token.Claims.FirstOrDefault(x => x.Type == "C_IdStaff").Value;

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("ListAllMusic");
                worksheet.Cell(1, 1).Value = "Danh Sách Tất Cả Bài Hát Của Manager Music";
                worksheet.Cell(2, 1).Value = "Tên Người Xuất Báo Cáo:";
                worksheet.Cell(2, 2).Value = NameStaff;

                worksheet.Cell(2, 4).Value = "Vai Trò:";
                worksheet.Cell(2, 5).Value = NameRole;

                worksheet.Cell(2, 7).Value = "Mã Nhân Viên:";
                worksheet.Cell(2, 8).Value = IdStaff;

                worksheet.Cell(3, 1).Value = "Ngày Xuất Báo Cáo:";
                worksheet.Cell(3, 2).Value = DateTime.UtcNow.AddHours(7).ToString("dd/MM/yyyy");

                worksheet.Cell(3, 4).Value = "Giờ Xuất Báo Cáo:";
                worksheet.Cell(3, 5).Value = DateTime.UtcNow.AddHours(7).TimeOfDay.ToString();

                worksheet.Cell(4, 1).Value = "Tổng Bài Hát:";
                worksheet.Cell(4, 2).Value = L_DowloadFileM.Count();

                var currentRow = 6;
                worksheet.Cell(currentRow, 1).Value = "Mã Bài Hát";
                worksheet.Cell(currentRow, 2).Value = "Tên Bài Hát";
                worksheet.Cell(currentRow, 3).Value = "Tên Tác Giả";
                worksheet.Cell(currentRow, 4).Value = "Ngày Tạo Bài Hát";
                worksheet.Cell(currentRow, 5).Value = "Thuộc Mùa";
                worksheet.Cell(currentRow, 6).Value = "Thuộc Ngày Lễ";
                worksheet.Cell(currentRow, 7).Value = "Thuộc Ngày Lễ";
                worksheet.Cell(currentRow, 7).Value = "Đường Dẫn Đến File Bài Hát";
                foreach (var item in L_DowloadFileM)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = item.CodeMusic;
                    worksheet.Cell(currentRow, 2).Value = item.Name;
                    worksheet.Cell(currentRow, 3).Value = item.Author;
                    worksheet.Cell(currentRow, 4).Value = item.Str_DateCreate;
                    worksheet.Cell(currentRow, 5).Value = item.NameSeason;
                    worksheet.Cell(currentRow, 6).Value = item.NameSaint;
                    worksheet.Cell(currentRow, 6).Value = item.NameStaff;
                    worksheet.Cell(currentRow, 7).Value = Confi["UrlDetailMusic"] + item.IdMusic;
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();

                    return File(
                        content,
                        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                        "ReportListMusic.xlsx");
                }
            }
        }

        //dowload file music by author
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public IActionResult DowMusicByAuthor()
        {
            var Stream = HttpContext.Request.Cookies["Token"];
            var hander = new JwtSecurityTokenHandler();
            var jsontoken = hander.ReadToken(Stream);
            var token = jsontoken as JwtSecurityToken;
            string NameRole = token.Claims.FirstOrDefault(x => x.Type == "C_NameRole").Value;
            string NameStaff = token.Claims.FirstOrDefault(x => x.Type == "C_FullName").Value;
            string IdStaff = token.Claims.FirstOrDefault(x => x.Type == "C_IdStaff").Value;

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("ListMusicAuthor");
                worksheet.Cell(1, 1).Value = "Danh Sách Bài Hát Theo Tác Giả Của Manager Music";
                worksheet.Cell(2, 1).Value = "Tên Người Xuất Báo Cáo:";
                worksheet.Cell(2, 2).Value = NameStaff;

                worksheet.Cell(2, 4).Value = "Vai Trò:";
                worksheet.Cell(2, 5).Value = NameRole;

                worksheet.Cell(2, 7).Value = "Mã Nhân Viên:";
                worksheet.Cell(2, 8).Value = IdStaff;

                worksheet.Cell(3, 1).Value = "Ngày Xuất Báo Cáo:";
                worksheet.Cell(3, 2).Value = DateTime.UtcNow.AddHours(7).ToString("dd/MM/yyyy");

                worksheet.Cell(3, 4).Value = "Giờ Xuất Báo Cáo:";
                worksheet.Cell(3, 5).Value = DateTime.UtcNow.AddHours(7).TimeOfDay.ToString();

                worksheet.Cell(4, 1).Value = "Tổng Bài Hát:";
                worksheet.Cell(4, 2).Value = L_DowloadFileM.Count();

                var currentRow = 6;
                worksheet.Cell(currentRow, 1).Value = "Mã Bài Hát";
                worksheet.Cell(currentRow, 2).Value = "Tên Bài Hát";
                worksheet.Cell(currentRow, 3).Value = "Tên Tác Giả";
                worksheet.Cell(currentRow, 4).Value = "Ngày Tạo Bài Hát";
                worksheet.Cell(currentRow, 5).Value = "Thuộc Mùa";
                worksheet.Cell(currentRow, 6).Value = "Thuộc Ngày Lễ";
                worksheet.Cell(currentRow, 7).Value = "Thuộc Ngày Lễ";
                worksheet.Cell(currentRow, 7).Value = "Đường Dẫn Đến File Bài Hát";
                foreach (var item in L_DowloadFileM)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = item.CodeMusic;
                    worksheet.Cell(currentRow, 2).Value = item.Name;
                    worksheet.Cell(currentRow, 3).Value = item.Author;
                    worksheet.Cell(currentRow, 4).Value = item.Str_DateCreate;
                    worksheet.Cell(currentRow, 5).Value = item.NameSeason;
                    worksheet.Cell(currentRow, 6).Value = item.NameSaint;
                    worksheet.Cell(currentRow, 6).Value = item.NameStaff;
                    worksheet.Cell(currentRow, 7).Value = Confi["UrlDetailMusic"] + item.IdMusic;
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();

                    return File(
                        content,
                        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                        "ReportListMusicAuthor.xlsx");
                }
            }
        }

        //dowload file music by IdSeason
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public IActionResult DowMusicBySeason()
        {
            var Stream = HttpContext.Request.Cookies["Token"];
            var hander = new JwtSecurityTokenHandler();
            var jsontoken = hander.ReadToken(Stream);
            var token = jsontoken as JwtSecurityToken;
            string NameRole = token.Claims.FirstOrDefault(x => x.Type == "C_NameRole").Value;
            string NameStaff = token.Claims.FirstOrDefault(x => x.Type == "C_FullName").Value;
            string IdStaff = token.Claims.FirstOrDefault(x => x.Type == "C_IdStaff").Value;

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("ListMusicSeason");
                worksheet.Cell(1, 1).Value = "Danh Sách Bài Hát Theo Mùa Của Manager Music";
                worksheet.Cell(2, 1).Value = "Tên Người Xuất Báo Cáo:";
                worksheet.Cell(2, 2).Value = NameStaff;

                worksheet.Cell(2, 4).Value = "Vai Trò:";
                worksheet.Cell(2, 5).Value = NameRole;

                worksheet.Cell(2, 7).Value = "Mã Nhân Viên:";
                worksheet.Cell(2, 8).Value = IdStaff;

                worksheet.Cell(3, 1).Value = "Ngày Xuất Báo Cáo:";
                worksheet.Cell(3, 2).Value = DateTime.UtcNow.AddHours(7).ToString("dd/MM/yyyy");

                worksheet.Cell(3, 4).Value = "Giờ Xuất Báo Cáo:";
                worksheet.Cell(3, 5).Value = DateTime.UtcNow.AddHours(7).TimeOfDay.ToString();

                worksheet.Cell(4, 1).Value = "Tổng Bài Hát:";
                worksheet.Cell(4, 2).Value = L_DowloadFileM.Count();

                var currentRow = 6;
                worksheet.Cell(currentRow, 1).Value = "Mã Bài Hát";
                worksheet.Cell(currentRow, 2).Value = "Tên Bài Hát";
                worksheet.Cell(currentRow, 3).Value = "Tên Tác Giả";
                worksheet.Cell(currentRow, 4).Value = "Ngày Tạo Bài Hát";
                worksheet.Cell(currentRow, 5).Value = "Thuộc Mùa";
                worksheet.Cell(currentRow, 6).Value = "Thuộc Ngày Lễ";
                worksheet.Cell(currentRow, 7).Value = "Thuộc Ngày Lễ";
                worksheet.Cell(currentRow, 7).Value = "Đường Dẫn Đến File Bài Hát";
                foreach (var item in L_DowloadFileM)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = item.CodeMusic;
                    worksheet.Cell(currentRow, 2).Value = item.Name;
                    worksheet.Cell(currentRow, 3).Value = item.Author;
                    worksheet.Cell(currentRow, 4).Value = item.Str_DateCreate;
                    worksheet.Cell(currentRow, 5).Value = item.NameSeason;
                    worksheet.Cell(currentRow, 6).Value = item.NameSaint;
                    worksheet.Cell(currentRow, 6).Value = item.NameStaff;
                    worksheet.Cell(currentRow, 7).Value = Confi["UrlDetailMusic"] + item.IdMusic;
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();

                    return File(
                        content,
                        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                        "ReportListMusicSeason.xlsx");
                }
            }
        }

        //dowload file music by IdSaints
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public IActionResult DowMusicBySaints()
        {
            var Stream = HttpContext.Request.Cookies["Token"];
            var hander = new JwtSecurityTokenHandler();
            var jsontoken = hander.ReadToken(Stream);
            var token = jsontoken as JwtSecurityToken;
            string NameRole = token.Claims.FirstOrDefault(x => x.Type == "C_NameRole").Value;
            string NameStaff = token.Claims.FirstOrDefault(x => x.Type == "C_FullName").Value;
            string IdStaff = token.Claims.FirstOrDefault(x => x.Type == "C_IdStaff").Value;

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("ListMusicSaints");
                worksheet.Cell(1, 1).Value = "Danh Sách Bài Hát Theo Ngày Lễ Của Manager Music";
                worksheet.Cell(2, 1).Value = "Tên Người Xuất Báo Cáo:";
                worksheet.Cell(2, 2).Value = NameStaff;

                worksheet.Cell(2, 4).Value = "Vai Trò:";
                worksheet.Cell(2, 5).Value = NameRole;

                worksheet.Cell(2, 7).Value = "Mã Nhân Viên:";
                worksheet.Cell(2, 8).Value = IdStaff;

                worksheet.Cell(3, 1).Value = "Ngày Xuất Báo Cáo:";
                worksheet.Cell(3, 2).Value = DateTime.UtcNow.AddHours(7).ToString("dd/MM/yyyy");

                worksheet.Cell(3, 4).Value = "Giờ Xuất Báo Cáo:";
                worksheet.Cell(3, 5).Value = DateTime.UtcNow.AddHours(7).TimeOfDay.ToString();

                worksheet.Cell(4, 1).Value = "Tổng Bài Hát:";
                worksheet.Cell(4, 2).Value = L_DowloadFileM.Count();

                var currentRow = 6;
                worksheet.Cell(currentRow, 1).Value = "Mã Bài Hát";
                worksheet.Cell(currentRow, 2).Value = "Tên Bài Hát";
                worksheet.Cell(currentRow, 3).Value = "Tên Tác Giả";
                worksheet.Cell(currentRow, 4).Value = "Ngày Tạo Bài Hát";
                worksheet.Cell(currentRow, 5).Value = "Thuộc Mùa";
                worksheet.Cell(currentRow, 6).Value = "Thuộc Ngày Lễ";
                worksheet.Cell(currentRow, 7).Value = "Thuộc Ngày Lễ";
                worksheet.Cell(currentRow, 7).Value = "Đường Dẫn Đến File Bài Hát";
                foreach (var item in L_DowloadFileM)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = item.CodeMusic;
                    worksheet.Cell(currentRow, 2).Value = item.Name;
                    worksheet.Cell(currentRow, 3).Value = item.Author;
                    worksheet.Cell(currentRow, 4).Value = item.Str_DateCreate;
                    worksheet.Cell(currentRow, 5).Value = item.NameSeason;
                    worksheet.Cell(currentRow, 6).Value = item.NameSaint;
                    worksheet.Cell(currentRow, 6).Value = item.NameStaff;
                    worksheet.Cell(currentRow, 7).Value = Confi["UrlDetailMusic"] + item.IdMusic;
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();

                    return File(
                        content,
                        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                        "ReportListMusicSaints.xlsx");
                }
            }
        }

        //dowload file music by Date
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public IActionResult DowMusicByDate()
        {
            var Stream = HttpContext.Request.Cookies["Token"];
            var hander = new JwtSecurityTokenHandler();
            var jsontoken = hander.ReadToken(Stream);
            var token = jsontoken as JwtSecurityToken;
            string NameRole = token.Claims.FirstOrDefault(x => x.Type == "C_NameRole").Value;
            string NameStaff = token.Claims.FirstOrDefault(x => x.Type == "C_FullName").Value;
            string IdStaff = token.Claims.FirstOrDefault(x => x.Type == "C_IdStaff").Value;

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("ListMusicDateCreate");
                worksheet.Cell(1, 1).Value = "Danh Sách Bài Hát Theo Ngày Của Manager Music";
                worksheet.Cell(2, 1).Value = "Tên Người Xuất Báo Cáo:";
                worksheet.Cell(2, 2).Value = NameStaff;

                worksheet.Cell(2, 4).Value = "Vai Trò:";
                worksheet.Cell(2, 5).Value = NameRole;

                worksheet.Cell(2, 7).Value = "Mã Nhân Viên:";
                worksheet.Cell(2, 8).Value = IdStaff;

                worksheet.Cell(3, 1).Value = "Ngày Xuất Báo Cáo:";
                worksheet.Cell(3, 2).Value = DateTime.UtcNow.AddHours(7).ToString("dd/MM/yyyy");

                worksheet.Cell(3, 4).Value = "Giờ Xuất Báo Cáo:";
                worksheet.Cell(3, 5).Value = DateTime.UtcNow.AddHours(7).TimeOfDay.ToString();

                worksheet.Cell(4, 1).Value = "Tổng Bài Hát:";
                worksheet.Cell(4, 2).Value = L_DowloadFileM.Count();

                var currentRow = 6;
                worksheet.Cell(currentRow, 1).Value = "Mã Bài Hát";
                worksheet.Cell(currentRow, 2).Value = "Tên Bài Hát";
                worksheet.Cell(currentRow, 3).Value = "Tên Tác Giả";
                worksheet.Cell(currentRow, 4).Value = "Ngày Tạo Bài Hát";
                worksheet.Cell(currentRow, 5).Value = "Thuộc Mùa";
                worksheet.Cell(currentRow, 6).Value = "Thuộc Ngày Lễ";
                worksheet.Cell(currentRow, 7).Value = "Thuộc Ngày Lễ";
                worksheet.Cell(currentRow, 7).Value = "Đường Dẫn Đến File Bài Hát";
                foreach (var item in L_DowloadFileM)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = item.CodeMusic;
                    worksheet.Cell(currentRow, 2).Value = item.Name;
                    worksheet.Cell(currentRow, 3).Value = item.Author;
                    worksheet.Cell(currentRow, 4).Value = item.Str_DateCreate;
                    worksheet.Cell(currentRow, 5).Value = item.NameSeason;
                    worksheet.Cell(currentRow, 6).Value = item.NameSaint;
                    worksheet.Cell(currentRow, 6).Value = item.NameStaff;
                    worksheet.Cell(currentRow, 7).Value = Confi["UrlDetailMusic"] + item.IdMusic;
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();

                    return File(
                        content,
                        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                        "ReportListMusicDate.xlsx");
                }
            }
        }


        //----------------------------------------------------
        //page manager file muisc chart report
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public IActionResult Page_FileChartReport()
        {
            return View();
        }

        //get all muisc by year
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public async Task<IActionResult> JsonGetAllMuiscChart(int Year)
        {
            var result = await context.GetAllMusicChartReport(Year);
            return new JsonResult(result);
        }

        //----------------------------------------------------
        //page manager staff chart report
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public IActionResult Page_StaffChartReport()
        {
            return View();
        }

        //get all satff by year
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public async Task<IActionResult> JsonGetAllStaffChart(int Year)
        {
            var result = await context.GetAllStaffChartReport(Year);
            return new JsonResult(result);
        }

        //----------------------------------------------------
        //page manager user chart report
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public IActionResult Page_UserChartReport()
        {
            return View();
        }

        //get all satff by year
        [Authorize(Roles = RoleSetting.symbolRole_Admin + "," + RoleSetting.symbolRole_Satff)]
        [HttpGet]
        public async Task<IActionResult> JsonGetAllUserChart(int Year)
        {
            var result = await context.GetAllUserChartReport(Year);
            return new JsonResult(result);
        }

    }
}
