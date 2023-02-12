using DataViewModel.ViewModelAdmin.Music_Vm;
using DataViewModel.ViewModelAdmin.Saint_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.ApplicationAdmin.ApplicationSaints.Saint_App
{
    public interface ISaint_App
    {
        //get all saint
        Paing_Saint_V GetAllSaint(int PageIndex, int PageSize, int sort, string Seach);

        //get all saint activer
        List<GetAllSaint_V> GetAllSaintActiver();

        //create new saint
        Task<NotificationMusic_V> CreateNewSaint(CreateSaint_V request);

        //get data update saint
        Task<GetAllSaint_V> GetDataUpdateSaint(int IdSaint);

        //update saint
        Task<NotificationMusic_V> UpdateSaint(GetAllSaint_V request, string NameSatff);

        //get all status saint
        List<GetAllStatusSaint_V> GetAllStatusSaint(int IdSaint);

        //change status saint
        Task<NotificationMusic_V> ChangeStatusSaint(GetAllSaint_V request, string NameStaff);

        //get all music by id saint
        PagingMusic_V ListMusicById_Saint(int IdSaint, int PageIndex, int PageSize, int sort);

    }
}
