using DataViewModel.ViewModelAdmin.Music_Vm;
using DataViewModel.ViewModelAdmin.Saint_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.ServiceAdmin.Saint
{
    public interface Iservice_Saint
    {
        //get all saint
        List<GetAllSaint_V> GetAllSaint();

        //get all saint activer
        List<GetAllSaint_V> GetAllSaintActiver();

        //create new saint
        Task<NotificationMusic_V> CreateSaint(CreateSaint_V request);

        //get data update saint
        Task<GetAllSaint_V> GetDataUpdateSaint(int IdSaint);

        //update saint
        Task<NotificationMusic_V> UpdateSaint(GetAllSaint_V request, string NameStaff);

        //get all status saint
        List<GetAllStatusSaint_V> GetAllStatusSaint(int IdSaint);

        //change status saint
        Task<NotificationMusic_V> ChangeStatusSaint(GetAllSaint_V request, string NameStaff);

        //get all music by id saint
        List<GetAll_V> GetAllMusicByIdSaint(int IdSaint);

    }
}
