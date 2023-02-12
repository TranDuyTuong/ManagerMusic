using DataViewModel.ViewModelAdmin.Music_Vm;
using DataViewModel.ViewModelAdmin.Season_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.ServiceAdmin.Season
{
    public interface Iservice_Season
    {
        //get all season
        List<GetAllSeason_V> GetAllSeason();

        //get all status season
        List<GetAllStatusSeason_V> GetAllStatusSeason();

        //change status season
        Task<NotificationMusic_V> ChangeStatusSeason(int IdSeason, int IdStatus, string FullName);

        //view list music by id season
        List<GetAll_V> ListMusicByIdSeason(int IdSeason);
    }
}
