using DataViewModel.ViewModelAdmin.User_Vm;
using DataViewModel.ViewModelAdmin.Users_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.ApplicationAdmin.ApplicationUsers.Users_App
{
    public interface Iusers_app
    {
        //get all users
        Task<List<GetAllUsers_V>> GetAllUsers();

        //get all users bithday
        Task<List<GetAllUsers_V>> GetAllUserBithday();

        //get user info birthday
        Task<GetInfoUserBirthday_V> GetInfoUserBirthday(Guid IdUser);

        //sent birthday user
        Task<NotificationUser_V> SentMessageBirthdayUser(GetInfoUserBirthday_V request);

        //get all message sent birthday user
        Task<List<GetAllSentBirthdayUser_V>> GetAllSentMessageBirthday();

        //detail user
        Task<DetailUser_V> DetailUser(Guid Iduser);

        //get time working by id user
        Task<List<GetAllTimeWorking_V>> GetTimeWorkingByUser(Guid Iduser);

        //get all rating by id user
        Task<List<GetAllRatingByIdUser>> GetAllRatingByIdUser(Guid IdUser);

        //get all comment by id user
        Task<List<GetAllCommentByIdUser_V>> GetAllCommentByIdUser(Guid IdUser);

        //get all dowload by id user
        Task<List<GetAllDowloadByIdUser_V>> GetAllDowloadByIdUser(Guid IdUser);
    }
}
