using DataViewModel.ViewModelAdmin.Music_Vm;
using DataViewModel.ViewModelAdmin.Season_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.ApplicationAdmin.ApplicationSeason.Season_App
{
    public interface ISeason_App
    {
        //get all season
        Paing_Season GetAllSeason(int PageSize, int PageIndex, int Sort_Id);

        //get all status season
        List<GetAllStatusSeason_V> GetAllStatusSeason();

        //change status season
        Task<NotificationMusic_V> ChangeStatusSeason(int IdSeason, int IdStatus, string FullName);

        // view list music by id season
        PagingMusic_V ListMusicByIdSeason(int PageIndex, int PageSize, int IdSeason, int Sort);

        //Get All season not paing
        List<GetAllSeason_V> GetAllSeasonNotPaing();
    }
}
