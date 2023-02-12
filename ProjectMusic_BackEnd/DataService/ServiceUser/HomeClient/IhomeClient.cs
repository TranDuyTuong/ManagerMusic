using DataViewModel.ViewModelUser.ChartClient_Vm;
using DataViewModel.ViewModelUser.Muisc_Vm;
using DataViewModel.ViewModelUser.RatingClient_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.ServiceUser.HomeClient
{
    public interface IhomeClient
    {
        //get data music for chart home client
        Task<List<ChartClient_V>> GetDataChartHomeClient(int Year);

        //get total music in month
        int GetTotalMusicInMonth();

        //get total music last month
        int GetTotalMusicLastMonth();

        //total up and down muisc
        UpAndDownMuisc_V TotalUpdownMusic();

        //get list muisc dowload
        Task<List<DowloadMusic_V>> GetAllMuiscDowload();

        //get list muisc dowload by id muisc
        Task<List<DowloadMusic_V>> DetailListMuiscDowLoad(Guid IdMuisc);

        //get total muisc by Id Season
        Task<List<MusicBySeason_V>> GetAllTotalMusicBySeason();

        //get 6 muisc dowload more in month
        Task<List<DowloadMuiscInMonth_V>> GetAllMuiscDowloadMoreMonth(int Month);

        //total user have account
        int TotalUserAccount();

        //total rating and comment
        TotalRatingComment_V TotalRatingAndComment();
    }
}
