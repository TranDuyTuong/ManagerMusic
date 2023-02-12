using DataService.ServiceAdmin.Reports;
using DataViewModel.ViewModelAdmin.Report_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.ApplicationAdmin.ApplicationReports.Reports_app
{
    public class Report_App : Ireport_App
    {
        private readonly Iservice_Reports context;
        public Report_App(Iservice_Reports _context)
        {
            context = _context;
        }

        //get all music for chart report
        public async Task<List<ChartReportMusic_V>> GetAllMusicChartReport(int Year)
        {
            var result = await context.GetAllMusicChart(Year);
            return result;
        }

        //get all music for report
        public async Task<List<DowLoadMusic_V>> GetAllReportMusic()
        {
            var result = await context.GetAllMusicReport();
            return result;
        }

        //get all staff for chart report
        public async Task<List<ChartReportMusic_V>> GetAllStaffChartReport(int Year)
        {
            var result = await context.GetAllStaffChart(Year);
            return result;
        }

        //get all user for chart report
        public async Task<List<ChartReportMusic_V>> GetAllUserChartReport(int Year)
        {
            var result = await context.GetAllUserChart(Year);
            return result;
        }

    }
}
