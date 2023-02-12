using DataViewModel.ViewModelAdmin.RequestUser_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.ServiceAdmin.RequestUser
{
    public interface Isevice_RequestUser
    {
        //get request user "Chưa Giải Quyết"
        Task<List<GetAllRequestUser_Vm>> GetAllRequestUser_Notresolved(int Selecter);

        //get all Receive
        Task<List<GetAllReceive_Vm>> GetAllReceiveUser();

        //get all status request
        Task<List<GetAllStatusRequest_Vm>> GetAllStatusRequest();

        //detail request user by id request
        Task<DetailRequestUser_Vm> DetailRequestUser(int IdRequest);

        //accept request user
        Task<NotificationRequestUser> CacceptRequestUser(int IdRequest, Guid IdUser, int TypeSent);

        //check type sent request User
        Task<NotificationTypeSent_Vm> CheckTypeSentRequestUser(int IdTypeSent);

        //sent gmail request user
        Task<NotificationRequestUser> SentEmailRequestUser(ContentAnswerSentRequestUser request);

        //total request users
        int TotalRequestUser();

        //get all request user for progress
        Task<List<GetAllRequestUserProgress>> GetAllProgressRequestUser();
    }
}
