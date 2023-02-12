using DataService.ServiceAdmin.User;
using DataViewModel.ViewModelAdmin.User_Vm;
using DataViewModel.ViewModelAdmin.Users_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.ApplicationAdmin.ApplicationUsers.Users_App
{
    public class User_app : Iusers_app
    {
        private readonly IUser context;
        public User_app(IUser _context)
        {
            context = _context;
        }


        //get all users birthday
        public async Task<List<GetAllUsers_V>> GetAllUserBithday()
        {
            var result = await context.GetAllBirthdayUsers();
            return result;
        }

        //get all Users
        public async Task<List<GetAllUsers_V>> GetAllUsers()
        {
            var result = await context.GetAllUsers();
            return result;
        }

        //get info user birthday
        public async Task<GetInfoUserBirthday_V> GetInfoUserBirthday(Guid IdUser)
        {
            var result = await context.GetInfoUserBirthday(IdUser);
            return result;
        }

        //sent birthday message user
        public async Task<NotificationUser_V> SentMessageBirthdayUser(GetInfoUserBirthday_V request)
        {
            var result = new NotificationUser_V();
            if (request.IdUser == new Guid())
            {
                result.IdNotification = 3; //id user ivaliate
                result.Status = false;
            }
            else
            {
                result = await context.SentMessageBirthdayUser(request);
            }             
            return result;
        }

        //get all sent message user birthday
        public async Task<List<GetAllSentBirthdayUser_V>> GetAllSentMessageBirthday()
        {
            var resutl = await context.GetAllSentBirthdayMessage();
            return resutl;
        }

        //detail user
        public async Task<DetailUser_V> DetailUser(Guid Iduser)
        {
            var result = await context.DetailUser(Iduser);
            return result;
        }

        public async Task<List<GetAllTimeWorking_V>> GetTimeWorkingByUser(Guid Iduser)
        {
            var result = await context.GetAllTimeWork(Iduser);
            return result;
        }

        //get all rating by id user
        public async Task<List<GetAllRatingByIdUser>> GetAllRatingByIdUser(Guid IdUser)
        {
            var result = await context.GetAllRatingByIdUser(IdUser);
            return result;
        }

        //get all comment by id user
        public async Task<List<GetAllCommentByIdUser_V>> GetAllCommentByIdUser(Guid IdUser)
        {
            var result = await context.GetAllCommentByIdUser(IdUser);
            return result;
        }

        //get all dowload by id user
        public async Task<List<GetAllDowloadByIdUser_V>> GetAllDowloadByIdUser(Guid IdUser)
        {
            var result = await context.GetAllDowloadByIdUser(IdUser);
            return result;
        }

    }
}
