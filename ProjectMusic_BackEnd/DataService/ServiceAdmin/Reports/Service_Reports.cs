using DataMigration.DataEF;
using DataViewModel.ViewModelAdmin.Report_Vm;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.ServiceAdmin.Reports
{
    public class Service_Reports : Iservice_Reports
    {
        private readonly ContextDB context;
        public Service_Reports(ContextDB _context)
        {
            context = _context;
        }

        //get all music by year in chart
        public async Task<List<ChartReportMusic_V>> GetAllMusicChart(int Year)
        {
            var QueryMusic = await context.T_Musics.Where(x => x.Year == Year).ToListAsync();
            List<ChartReportMusic_V> L_Result = new List<ChartReportMusic_V>();
            foreach(var item in QueryMusic)
            {
                var CheckDate = L_Result.FirstOrDefault(x => x.FullDate == item.Date + "/" + item.Month + "/" + item.Year);
                if(CheckDate == null)
                {
                    var setData = new ChartReportMusic_V()
                    {
                        Day = item.Date,
                        Month = item.Month,
                        Year = item.Year,
                        FullDate = item.Date + "/" + item.Month + "/" + item.Year,
                        TotalMuisc = 1
                    };
                    L_Result.Add(setData);
                }
                else
                {
                    CheckDate.TotalMuisc++;
                }
            }
            return L_Result;
        }

        //get all staff by year in chart
        public async Task<List<ChartReportMusic_V>> GetAllStaffChart(int Year)
        {
            var QueryStaff = await context.T_Users.Where(x => x.IdStaff != null && x.DateCreate.Year == Year).ToListAsync();
            List<ChartReportMusic_V> L_Result = new List<ChartReportMusic_V>();
            foreach (var item in QueryStaff)
            {
                var CheckDate = L_Result.FirstOrDefault(x => x.FullDate == item.DateCreate.Day + "/" + item.DateCreate.Month + "/" + item.DateCreate.Year);
                if (CheckDate == null)
                {
                    var setData = new ChartReportMusic_V()
                    {
                        Day = item.DateCreate.Day,
                        Month = item.DateCreate.Month,
                        Year = item.DateCreate.Year,
                        FullDate = item.DateCreate.Day + "/" + item.DateCreate.Month + "/" + item.DateCreate.Year,
                        TotalMuisc = 1
                    };
                    L_Result.Add(setData);
                }
                else
                {
                    CheckDate.TotalMuisc++;
                }
            }
            return L_Result;
        }


        //get all user by year in chart
        public async Task<List<ChartReportMusic_V>> GetAllUserChart(int Year)
        {
            var QueryStaff = await context.T_Users.Where(x => x.IdStaff == null && x.DateCreate.Year == Year).ToListAsync();
            List<ChartReportMusic_V> L_Result = new List<ChartReportMusic_V>();
            foreach (var item in QueryStaff)
            {
                var CheckDate = L_Result.FirstOrDefault(x => x.FullDate == item.DateCreate.Day + "/" + item.DateCreate.Month + "/" + item.DateCreate.Year);
                if (CheckDate == null)
                {
                    var setData = new ChartReportMusic_V()
                    {
                        Day = item.DateCreate.Day,
                        Month = item.DateCreate.Month,
                        Year = item.DateCreate.Year,
                        FullDate = item.DateCreate.Day + "/" + item.DateCreate.Month + "/" + item.DateCreate.Year,
                        TotalMuisc = 1
                    };
                    L_Result.Add(setData);
                }
                else
                {
                    CheckDate.TotalMuisc++;
                }
            }
            return L_Result;
        }

        //get all music report
        public async Task<List<DowLoadMusic_V>> GetAllMusicReport()
        {
            var QueryData = from Item_M in context.T_Musics
                            join Item_File in context.T_FileMusics on Item_M.IdMusic equals Item_File.IdMusic
                            join Item_Season in context.T_Seasons on Item_M.IdSeason equals Item_Season.IdSeason
                            join Item_Saint in context.T_Saints on Item_M.IdSaints equals Item_Saint.IdSaints
                            join Item_User in context.T_Users on Item_M.IdStaff equals Item_User.IdStaff
                            where Item_M.IdStatusMusic == 1 && Item_User.IdStaff != null
                            select new { Item_M, Item_File, Item_Season, Item_Saint, Item_User };
            var result = await QueryData.OrderByDescending(x => x.Item_M.DateCreate).Select(x => new DowLoadMusic_V()
            {
                IdMusic = x.Item_M.IdMusic,
                CodeMusic = x.Item_M.NoMusic,
                Name = x.Item_M.NameMusic,
                Author = x.Item_M.AuthorMusic,
                DateCreate = x.Item_M.DateCreate,
                Str_DateCreate = x.Item_M.DateCreate.ToString("dd/MM/yyyy"),
                IdSeason = x.Item_M.IdSeason,
                NameSeason = x.Item_Season.NameSeason,
                IsSaint = x.Item_Saint.IdSaints,
                NameSaint = x.Item_Saint.NameSaints,
                FileName = x.Item_File.NameFile,
                FileContent = x.Item_File.DataFile,
                MineFile = x.Item_File.MimeType,
                IdStaff = x.Item_M.IdStaff,
                NameStaff = x.Item_User.FullName,
                Day = x.Item_M.Date,
                Month = x.Item_M.Month,
                Year = x.Item_M.Year
            }).ToListAsync();
            return result;
        }

    }
}
