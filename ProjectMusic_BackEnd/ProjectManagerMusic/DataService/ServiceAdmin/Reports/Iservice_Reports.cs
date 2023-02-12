using DataViewModel.ViewModelAdmin.Report_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.ServiceAdmin.Reports
{
    public interface Iservice_Reports
    {
        //get all file music report
        Task<List<DowLoadMusic_V>> GetAllMusicReport();

        //get all music for chart
        Task<List<ChartReportMusic_V>> GetAllMusicChart(int Year);

        //get all satff for chart
        Task<List<ChartReportMusic_V>> GetAllStaffChart(int Year);

        //get all user for chart
        Task<List<ChartReportMusic_V>> GetAllUserChart(int Year);
    }
}
