using DataMigration.DataEF;
using DataViewModel.ViewModelUser.ChartClient_Vm;
using DataViewModel.ViewModelUser.Muisc_Vm;
using DataViewModel.ViewModelUser.RatingClient_Vm;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.ServiceUser.HomeClient
{
    public class HomeClient : IhomeClient
    {
        private readonly ContextDB context;
        public HomeClient(ContextDB _context)
        {
            context = _context;
        }

        //detail list muisc dowload by id muisc
        public async Task<List<DowloadMusic_V>> DetailListMuiscDowLoad(Guid IdMuisc)
        {
            List<DowloadMusic_V> L_MuiscDow = new List<DowloadMusic_V>();
            var QueryDowload = await context.T_DowloadMusics.OrderByDescending(x => x.IdDowload)
                                                        .Where(x => x.IdMusic == IdMuisc).ToListAsync();
            var QueryMusic = await context.T_Musics.ToListAsync();
            var QuerySeason = await context.T_Seasons.ToListAsync();

            foreach (var item in QueryDowload)
            {
                var SetData = new DowloadMusic_V();
                SetData.IdMusic = item.IdMusic;
                SetData.NameMuisc = QueryMusic.FirstOrDefault(x => x.IdMusic == item.IdMusic).NameMusic;
                SetData.IdSeason = QueryMusic.FirstOrDefault(x => x.IdMusic == item.IdMusic).IdSeason;
                SetData.NameSeason = QuerySeason.FirstOrDefault(x => x.IdSeason == SetData.IdSeason).NameSeason;
                SetData.DateDowload = item.DateCreate.ToString("dd/MM/yyyy");
                SetData.TimeDowload = item.DateCreate.TimeOfDay.ToString();
                L_MuiscDow.Add(SetData);
            }
            return L_MuiscDow;
        }

        //get all muisc dowload
        public async Task<List<DowloadMusic_V>> GetAllMuiscDowload()
        {
            List<DowloadMusic_V> L_MuiscDow = new List<DowloadMusic_V>();
            var QueryDowload = await context.T_DowloadMusics.OrderByDescending(x => x.IdDowload).ToListAsync();
            var QueryMusic = await context.T_Musics.ToListAsync();
            var QuerySeason = await context.T_Seasons.ToListAsync();

            foreach (var item in QueryDowload)
            {
                var checkData = L_MuiscDow.FirstOrDefault(x => x.IdMusic == item.IdMusic);
                if (checkData == null)
                {
                    var SetData = new DowloadMusic_V();
                    SetData.IdMusic = item.IdMusic;
                    SetData.NameMuisc = QueryMusic.FirstOrDefault(x => x.IdMusic == item.IdMusic).NameMusic;
                    SetData.IdSeason = QueryMusic.FirstOrDefault(x => x.IdMusic == item.IdMusic).IdSeason;
                    SetData.NameSeason = QuerySeason.FirstOrDefault(x => x.IdSeason == SetData.IdSeason).NameSeason;
                    SetData.TotalDowload = 1;
                    L_MuiscDow.Add(SetData);
                }
                else
                {
                    checkData.TotalDowload++;
                }
            }
            return L_MuiscDow;
        }

        //get 6 music dowload more in month
        public async Task<List<DowloadMuiscInMonth_V>> GetAllMuiscDowloadMoreMonth(int Month)
        {
            var GetYearCurrent = DateTime.Now.AddHours(7).Year;
            var QueryDowload = await context.T_DowloadMusics.Where(x => x.DateCreate.Month == Month
                                                    && x.DateCreate.Year == GetYearCurrent).ToListAsync();
            var QueryMuisc = await context.T_Musics.ToListAsync();
            var QuerySeason = await context.T_Seasons.ToListAsync();
            List<DowloadMuiscInMonth_V> L_DowloadMuisc = new List<DowloadMuiscInMonth_V>();
            foreach (var item in QueryDowload)
            {
                var checkData = L_DowloadMuisc.FirstOrDefault(x => x.IdMuisc == item.IdMusic);
                if (checkData == null)
                {
                    var SetData = new DowloadMuiscInMonth_V();
                    SetData.IdMuisc = item.IdMusic;
                    SetData.NameAuthor = QueryMuisc.FirstOrDefault(x => x.IdMusic == item.IdMusic).AuthorMusic;
                    SetData.NameMuisc = QueryMuisc.FirstOrDefault(x => x.IdMusic == item.IdMusic).NameMusic;
                    SetData.IdSeason = QueryMuisc.FirstOrDefault(x => x.IdMusic == item.IdMusic).IdSeason;
                    SetData.NameSeason = QuerySeason.FirstOrDefault(x => x.IdSeason == SetData.IdSeason).NameSeason;
                    SetData.TotalDowload = 1;
                    L_DowloadMuisc.Add(SetData);
                }
                else
                {
                    checkData.TotalDowload++;
                }
            }
            return L_DowloadMuisc.OrderByDescending(x=>x.TotalDowload).Take(6).ToList();
        }

        //get total muisc by season
        public async Task<List<MusicBySeason_V>> GetAllTotalMusicBySeason()
        {
            var QueryMuisc = await context.T_Musics.Where(x => x.IdStatusMusic == 1).ToListAsync();
            var QuerySeason = await context.T_Seasons.ToListAsync();
            List<MusicBySeason_V> L_MusicSeason = new List<MusicBySeason_V>();
            foreach (var item in QuerySeason)
            {
                var FindData = QueryMuisc.Where(x => x.IdSeason == item.IdSeason).ToList();
                var CheckData = new MusicBySeason_V()
                {
                    IdSeason = item.IdSeason,
                    NameSeason = item.NameSeason,
                    TotalMusic = FindData.Count()
                };
                L_MusicSeason.Add(CheckData);
            }
            return L_MusicSeason;
        }

        //get all data music for chart home client
        public async Task<List<ChartClient_V>> GetDataChartHomeClient(int Year)
        {
            var QueryMusic = await context.T_Musics.Where(x => x.IdStatusMusic == 1 && x.Year == Year).ToListAsync();
            List<ChartClient_V> L_DataChart = new List<ChartClient_V>();
            if (QueryMusic.Count() == 0)
            {
                return L_DataChart;
            }
            else
            {
                for (int i = 1; i <= 12; i++)
                {
                    var SetMonth = new ChartClient_V();
                    SetMonth.Month = i.ToString();
                    SetMonth.Year = Year;
                    L_DataChart.Add(SetMonth);
                }
                foreach (var item in QueryMusic)
                {
                    var SetData = L_DataChart.FirstOrDefault(x => x.Month == item.Month.ToString());
                    if (SetData != null)
                    {
                        SetData.TotalMusic++;
                    }
                }
                return L_DataChart;
            }
        }

        //get total music in month
        public int GetTotalMusicInMonth()
        {
            var Curentdate = DateTime.UtcNow.AddHours(7);
            var QueryMusic = context.T_Musics.Where(x => x.Year == Curentdate.Year
                                                    && x.Month == Curentdate.Month
                                                        && x.IdStatusMusic == 1).ToList();
            return QueryMusic.Count();
        }

        //get total muisc last month
        public int GetTotalMusicLastMonth()
        {
            var LastMonth = DateTime.UtcNow.AddHours(7);
            var resultMonth = LastMonth.AddMonths(-1);
            var QueryMusic = context.T_Musics.Where(x => x.Year == resultMonth.Year
                                                    && x.Month == resultMonth.Month
                                                        && x.IdStatusMusic == 1).ToList();
            return QueryMusic.Count();
        }

        //total rating and comment
        public TotalRatingComment_V TotalRatingAndComment()
        {
            var QueryRating = context.T_Ratings.ToList();
            var QueryComment = context.T_CommentMusic.ToList();
            var resutl = new TotalRatingComment_V()
            {
                TotalRating = QueryRating.Count(),
                TotalComment = QueryComment.Count()
            };
            return resutl;
        }

        public UpAndDownMuisc_V TotalUpdownMusic()
        {
            var QueryDowload = context.T_DowloadMusics.ToList();
            var QueryMuisc = context.T_Musics.ToList();
            var result = new UpAndDownMuisc_V()
            {
                TotalDown = QueryDowload.Count(),
                TotalUp = QueryMuisc.Count()
            };
            return result;
        }

        //total user have account
        public int TotalUserAccount()
        {
            var QueryUser = context.T_Users.Where(x => x.IdStaff == null).ToList();
            return QueryUser.Count();
        }

    }
}
