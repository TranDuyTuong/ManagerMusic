using DataService.ServiceUser.HomeClient;
using DataViewModel.ViewModelUser.ChartClient_Vm;
using DataViewModel.ViewModelUser.Muisc_Vm;
using DataViewModel.ViewModelUser.RatingClient_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.ApplicationUser.ApplicationHome.HomeClient
{
    public class HomeClient_App : IhomeClient_App
    {
        private readonly IhomeClient context;
        public HomeClient_App(IhomeClient _context)
        {
            context = _context;
        }

        //get all muisc were dowload
        public async Task<List<DowloadMusic_V>> GetAllMusicWereDowload()
        {
            var result = await context.GetAllMuiscDowload();
            return result;
        }

        //get data for chart home client
        public async Task<List<ChartClient_V>> GetDataChartClient(int year)
        {
            var result = await context.GetDataChartHomeClient(year);
            return result;
        }

        //get list muisc by id muisc
        public async Task<List<DowloadMusic_V>> GetListMuiscById(Guid IdMuisc)
        {
            var result = await context.DetailListMuiscDowLoad(IdMuisc);
            return result;
        }

        //get 6 music dowload more in month
        public async Task<List<DowloadMuiscInMonth_V>> GetMusicDowloadMoreMonth()
        {
            var CurrentMonth = DateTime.UtcNow.AddHours(7).Month;
            var result = await context.GetAllMuiscDowloadMoreMonth(CurrentMonth);
            return result;
        }

        //get total muisic in month
        public int GetTotalMuiscInMonth()
        {
            var result = context.GetTotalMusicInMonth();
            return result;
        }

        //get total music last month
        public int GetTotalMuiscLastMonth()
        {
            var result = context.GetTotalMusicLastMonth();
            return result;
        }

        //get total music by season
        public async Task<List<MusicBySeason_V>> GetTotalMusicBySeason()
        {
            var result = await context.GetAllTotalMusicBySeason();
            return result;
        }

        //total rating and comment music
        public TotalRatingComment_V TotalRatingAndComment()
        {
            var resutl = context.TotalRatingAndComment();
            return resutl;
        }

        //total up and down muisc
        public UpAndDownMuisc_V TotalUpandDownMusic()
        {
            var result = context.TotalUpdownMusic();
            return result;
        }

        //get total user have account
        public int TotalUserHaveAccount()
        {
            var result = context.TotalUserAccount();
            return result;
        }
    }
}
