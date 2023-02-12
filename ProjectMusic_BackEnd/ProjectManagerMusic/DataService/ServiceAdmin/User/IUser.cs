using DataViewModel.ViewModelAdmin.Plan_Vm;
using DataViewModel.ViewModelAdmin.Role_Vm;
using DataViewModel.ViewModelAdmin.User_Vm;
using DataViewModel.ViewModelAdmin.Users_Vm;
using DataViewModel.ViewModelUser.LoginAndRegiter_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.ServiceAdmin.User
{
    public interface IUser
    {
        //Get All staff
        List<GetAllUser_v> GetAllUser(); //get all user for regiter staff and user

        //Get TotalChat by Id staff
        Task<GetAllUser_v> GetTotalByIdUser(Guid IdUser);

        //Get All Staff
        List<GetAllUser_v> GetAllStaff();

        //get all status Account
        List<GetAllStatusAccount_V> GetAllStatusAccount();

        //get all marriage
        List<GetAllMarriage_V> GetAllMarriage();

        //get all gender
        List<GetAllGender_V> GetAllGender();

        //get lever by id role
        GetAllLever_V GetLeverByIdRole(Guid idRole);

        //create staff
        Task<NotificationRegiter_V> CreateSatff(CreateSatff_V request);

        //chat staff
        Task<GetAllChatBy_Staff> CreateChatStaff(CreateChatStaff_V request);

        //loading message staff
        Task<GetAllChatBy_Staff> LoadingMessage();

        //get info staff chat by id chat
        Task<GetInfoChatUser_V> InfoUserChat(int IdChat);

        //send message like image
        Task<GetAllChatBy_Staff> CreateChatIconMessage(CreateChatStaff_V request);

        //sent images chat 
        Task<GetAllChatBy_Staff> CreateImagesChat(CreateChatStaff_V request);

        //get image by id images
        Task<GetAllChatImages_V> GetImageBy_Id(int Id_File);

        //dowload file
        Task<GetAllChatImages_V> DowloadFile_ById(int Id_File);

        //get images show slider in message
        List<GetAllChatImages_V> ShowImagesSliderMessage();

        //get all file in message
        List<GetAllFileMessage_V> GetAllFileInMessage();

        //update was view message by id user
        Task<bool> WasViewMessageByIdUser(Guid IdUser);

        //update staff get
        Task<UpdateStaff_V> Get_UpdateStaff(Guid IdUser);

        //update staff post
        Task<NotificationUser_V> Post_UpdateStaff(UpdateStaff_V request);

        //detail staff
        Task<DetailStaff_V> DetailStaff(Guid IdUser);

        //block account staff
        Task<NotificationUser_V> BockAccount(Guid IdUser);

        //Opent account staff
        Task<NotificationUser_V> OpenLockAccount(Guid IdUser);

        //Canel hide staff
        Task<NotificationUser_V> CancelHideStaff(Guid IdUser);

        //Decentralization Role Staff
        Task<RoleStaff_V> DecenRoleStaff(Guid IdUser);

        //change role staff
        Task<NotificationUser_V> ChangeRoleStaff(Guid IdUser, Guid IdRole, Guid IdUserDecenRole, Guid IdRoleCurrent);

        //check gmail staff
        Task<NotificationUser_V> CheckGmailSatff(string Gmail);

        //change password staff
        Task<NotificationUser_V> ChangePasswordStaff(string Gmail, string Password);

        //create plan for staff
        Task<NotificationUser_V> CreatePlanStaff(CreatePlan_V request);


        //-------------------------------------------------------------------------------------------------------
        //--------------------------------------USER-------------------------------------
        //get all users
        Task<List<GetAllUsers_V>> GetAllUsers();

        //get all birthday users
        Task<List<GetAllUsers_V>> GetAllBirthdayUsers();

        //get info user sent birthday
        Task<GetInfoUserBirthday_V> GetInfoUserBirthday(Guid IdUser);

        //sent message birthday user
        Task<NotificationUser_V> SentMessageBirthdayUser(GetInfoUserBirthday_V request);

        //get all sent birthday user message
        Task<List<GetAllSentBirthdayUser_V>> GetAllSentBirthdayMessage();

        //Detail Users
        Task<DetailUser_V> DetailUser(Guid Iduser);

        //Get All Time Working
        Task<List<GetAllTimeWorking_V>> GetAllTimeWork(Guid IdUser);

        //Get All Start rating by id user
        Task<List<GetAllRatingByIdUser>> GetAllRatingByIdUser(Guid IdUser);

        //Get All Comment Muisc by id user
        Task<List<GetAllCommentByIdUser_V>> GetAllCommentByIdUser(Guid IdUser);

        //Get All Dowload Muisc by Id User
        Task<List<GetAllDowloadByIdUser_V>> GetAllDowloadByIdUser(Guid IdUser);

        //Get All request user by id user
        Task<List<GetAllRequestByIdUser>> GetAllRequestByIdUser(Guid IdUser);
    }
}
