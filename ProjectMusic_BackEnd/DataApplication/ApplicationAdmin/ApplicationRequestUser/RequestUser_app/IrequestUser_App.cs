using DataViewModel.ViewModelAdmin.RequestUser_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.ApplicationAdmin.ApplicationRequestUser.RequestUser_app
{
    public interface IrequestUser_App
    {
        //get request user "Chưa Giải Quyết"
        Task<List<GetAllRequestUser_Vm>> GetAllRequestUser_Notresolved(int Selecter);

        //get all receive user
        Task<List<GetAllReceive_Vm>> GetAllReceiveUser();

        //get all status request user
        Task<List<GetAllStatusRequest_Vm>> GetAllStatusRequest();

        //detail request user
        Task<DetailRequestUser_Vm> DetailRequestUser(int IdRequest);

        //accept request user
        Task<NotificationRequestUser> CacceptRequestUser(int IdRequest, Guid IdUser, int TypeSent);

        //check type sent request user
        Task<NotificationTypeSent_Vm> CheckTypeSentRequestUser(int IdTypeSent);

        //Sent Email request user
        Task<NotificationRequestUser> SentEmailRequestUser(ContentAnswerSentRequestUser request);

        //total request users
        int TotalRequestUser();

        //get all request user for progress
        Task<List<GetAllRequestUserProgress>> GetAllProgressRequestUser();
    }
}
