using DataViewModel.ViewModelAdmin.Comment_Vm;
using DataViewModel.ViewModelAdmin.Dowload_Vm;
using DataViewModel.ViewModelAdmin.Music_Vm;
using DataViewModel.ViewModelAdmin.Rating_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.ApplicationAdmin.ApplicationMusic.Music_App
{
    public interface ImusicApplication
    {
        //get all music
        PagingMusic_V GetAllMusic(int PageSize, int PageIndex, int IdSeason, string SeachKey, int IdStatus, int Sort_No);

        //get all music delete
        PagingMusic_V GetAllMusicDelete(int PageSize, int PageIndex, int SelectSeason, string Seach);

        //get all status music
        List<GetAllSatusMusic_V> GetAllSatusMusic();

        //create music
        Task<NotificationMusic_V> CreateMusic(CreateMusic_V request);

        //detail music
        Task<DetailMusic_V> DetailMusic(Guid IdMusic);

        //change status music
        Task<NotificationMusic_V> ChangeStatusMusic(int IdStatus, Guid IdMusic, Guid IdUser);

        //delete music
        Task<NotificationMusic_V> DeleteMusic(Guid IdMusic, Guid IdUser, List<Guid> L_IdMuisc);

        //dowload music staff
        Task<NotificationMusic_V> DowloadMusicStaff(DowloadMusic_V request);

        //get all comment by id music
        List<GetAllComment_Vm> GetAllCommentByIdMuisc(Guid IdMuisc);

        //get all rating by id music
        List<GetAllRating_Vm> GetAllRatingByIdMuisc(Guid IdMuisc);

        //update Muisc
        Task<UpdateMuisc_V> GetUpdateMusic(Guid IdMuisc);
        Task<NotificationMusic_V> UpdateMuisc(UpdateMuisc_V request);

        //get all history update music
        List<GetAllHistoryUpdate_V> GetAllHistoryUpdate(Guid IdMuisc);

        //activer file muisc
        Task<NotificationMusic_V> ActiverFileMusic(List<Guid> L_Muisc, string NameStaff);

        //get all file music dowload
        PagingDowload_V GetAllFileMusicDowload(int PageSize, int PageIndex, string SeachKey);

        //delete dowload music 
        Task<NotificationMusic_V> DeleteDowloadMusic(List<int> IdMusic, int IdDowload);

        //detail dowload music
        Task<GetAllDowload_V> DetailDowloadMusic(int IdDowload);

        //recover music delete
        Task<NotificationMusic_V> RecoverMusicDelete(List<Guid> L_Music, Guid IdMusic, int Flag, Guid IdUser);

        //get 10 nusic new
        PagingMusic_V GetNewMusic(int PageSize, int PageIndex);
    } 
}
