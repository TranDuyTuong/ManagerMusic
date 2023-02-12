using DataViewModel.ViewModelAdmin.Report_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.ApplicationAdmin.ApplicationReports.Reports_app
{
    public interface Ireport_App
    {
        //get all music for report
        Task<List<DowLoadMusic_V>> GetAllReportMusic();

        //get all muisc for chart report
        Task<List<ChartReportMusic_V>> GetAllMusicChartReport(int Year);

        //get all staff for chart report
        Task<List<ChartReportMusic_V>> GetAllStaffChartReport(int Year);

        //get all user for chart report
        Task<List<ChartReportMusic_V>> GetAllUserChartReport(int Year);
    }
}
