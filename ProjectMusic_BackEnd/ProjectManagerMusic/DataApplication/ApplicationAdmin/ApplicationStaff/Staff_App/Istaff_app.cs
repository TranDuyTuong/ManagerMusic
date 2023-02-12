using DataViewModel.ViewModelAdmin.ConverFile_Vm;
using DataViewModel.ViewModelAdmin.Plan_Vm;
using DataViewModel.ViewModelAdmin.Role_Vm;
using DataViewModel.ViewModelAdmin.User_Vm;
using DataViewModel.ViewModelUser.LoginAndRegiter_Vm;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.ApplicationAdmin.ApplicationStaff.Staff_App
{
    public interface Istaff_app
    {
        //get all status account
        public List<GetAllStatusAccount_V> GetAllStatusAccount();

        //get all gender
        public List<GetAllGender_V> GetAllGender();

        //get all marriage
        public List<GetAllMarriage_V> GetAllMarriage();

        //get lever by id role
        GetAllLever_V GetLeverByIdRole(Guid idRole);

        //create staff
        Task<NotificationRegiter_V> CreateStaff(CreateSatff_V request);

        //GetAll Staff
        List<GetAllUser_v> GetAllStaff();

        Task<byte[]> ConverFromFileToByte(IFormFile request);

        //conver Iformfile -> base 64
        Task<string> ConverFormFileTobase64(IFormFile request);

        //create comment staff
        Task<GetAllChatBy_Staff> CreateChatStaff(CreateChatStaff_V request);

        //loading message
        Task<GetAllChatBy_Staff> LoadingMessage();

        //get info user chat
        Task<GetInfoChatUser_V> InfoUserChat(int IdChat, int PageIndex, int PageSize, int Sort);

        //create chat like message staff
        Task<GetAllChatBy_Staff> CreateChatIconMessage(CreateChatStaff_V request);

        //conver iformFile to byte
        Task<ConverFile> ConverDataFile(IFormFile request);

        //sent images chat 
        Task<GetAllChatBy_Staff> CreateImagesChat(CreateChatStaff_V request);

        //get images chat by id images
        Task<GetAllChatImages_V> GetImageBy_Id(int Id_File);

        //dowload file in message 
        Task<GetAllChatImages_V> DowloadFile_ById(int Id_File);

        //get all images in message slider
        List<GetAllChatImages_V> SliderListImageMessage();

        //get all file in message
        List<GetAllFileMessage_V> GetAllFileInMessage();

        //get totalChat by id User
        Task<GetAllUser_v> GetTotalChatByIdUser(Guid IdUser);

        //was view message by id user
        Task<bool> WasViewMessageByIdUser(Guid IdUser);

        //get update staff
        Task<UpdateStaff_V> Get_UpdateStaff(Guid IdUser);

        //post update staff
        Task<NotificationUser_V> Post_UpdateStaff(UpdateStaff_V request);

        //detail staff
        Task<DetailStaff_V> DetailStaff(Guid IdUser);

        //block account staff
        Task<NotificationUser_V> BlockAccountStaff(Guid IdUser);

        //open lock account satff
        Task<NotificationUser_V> OpenLockAccount(Guid IdUser);

        //cancel hide staff
        Task<NotificationUser_V> CancelHideStaff(Guid IdUser);

        //decentralization role staff
        Task<RoleStaff_V> Get_DecenRoleSatff(Guid IdUser);

        //change role staff
        Task<NotificationUser_V> ChangeRoleStaff(Guid IdUser, Guid IdRole, Guid IdUserDecenRole, Guid IdRoleCurrent);

        //check gmail staff
        Task<NotificationUser_V> CheckGmailStaff(string Gmail);

        //change password staff
        Task<NotificationUser_V> ChangePasswordStaff(string Gmail, string Password);

        //create plan for staff
        Task<NotificationUser_V> CreatePlanStaff(CreatePlan_V request);
    }
}
