using DataViewModel.ViewModelAdmin.Comment_Vm;
using DataViewModel.ViewModelAdmin.Dowload_Vm;
using DataViewModel.ViewModelAdmin.Music_Vm;
using DataViewModel.ViewModelAdmin.Rating_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.ServiceAdmin.Music
{
    public interface Iserivce_Music
    {
        //get all music
        List<GetAll_V> GetAllMusic();

        //get all status music
        List<GetAllSatusMusic_V> GetAllSatusMusic();

        //create music
        Task<NotificationMusic_V> CreateMusic(CreateMusic_V request);

        //detail music
        Task<DetailMusic_V> DetailMusic(Guid IdMusic);

        //get all comment by id music
        List<GetAllComment_Vm> GetAllCommentByIdMuisc(Guid IdMuisc);

        //get all rating by id music
        List<GetAllRating_Vm> GetAllRatingByIdMuisc(Guid IdMuisc);

        //change status music
        Task<NotificationMusic_V> ChangeStatusMusic(int IdStatus, Guid IdMusic, Guid IdUser);

        //delete music
        Task<NotificationMusic_V> DeleteMusic(Guid IdMusic, Guid IdUser, List<Guid> L_IdMuisc);

        //dowload music by Idstaff
        Task<NotificationMusic_V> DowloadMusicByStaff(DowloadMusic_V request);

        //update Music
        Task<UpdateMuisc_V> GetUpdateMuisc(Guid IdMuisc);
        Task<NotificationMusic_V> UpdateMuisc(UpdateMuisc_V request);

        //get all history updateMuisc
        List<GetAllHistoryUpdate_V> GetAllHistoryUpdate(Guid IdMuisc);

        //activer file music
        Task<NotificationMusic_V> ActiverFileMusic(List<Guid> IdMuisc, string NameStaff);

        //get all dowload music
        List<GetAllDowload_V> GetAllDowloadMusic();

        //delete dowload music
        Task<NotificationMusic_V> DeleteMusicDowload(List<int>L_Music, int IdDowload);

        //detail dowload music
        Task<GetAllDowload_V> DetailDowloadMusic(int IdDowload);

        //get all music delete
        List<GetAll_V> GetAllDeleteMusic();

        //recover music delete
        Task<NotificationMusic_V> RecoverMusicDelete(List<Guid> L_Music, Guid IdMusic, int FlagGuid, Guid IdUser);

        //get 10 music new
        List<GetAll_V> GetNewMusic();
    }
}
