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
    public interface IhomeClient_App
    {
        //get data muisc for chart client
        Task<List<ChartClient_V>> GetDataChartClient(int year);

        //get total music in month
        int GetTotalMuiscInMonth();

        //get total music last month
        int GetTotalMuiscLastMonth();

        //total up and donw muisc
        UpAndDownMuisc_V TotalUpandDownMusic();

        //get muisc were dowload
        Task<List<DowloadMusic_V>> GetAllMusicWereDowload();

        //get list muisc dowload by id muisc
        Task<List<DowloadMusic_V>> GetListMuiscById(Guid IdMuisc);

        //get total music by season
        Task<List<MusicBySeason_V>> GetTotalMusicBySeason();

        //get 6 muisc dowload more in month
        Task<List<DowloadMuiscInMonth_V>> GetMusicDowloadMoreMonth();

        //total user have account
        int TotalUserHaveAccount();

        //total rating and comment
        TotalRatingComment_V TotalRatingAndComment();
    }
}
