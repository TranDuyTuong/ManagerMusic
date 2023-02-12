using DataService.ServiceAdmin.RequestUser;
using DataViewModel.ViewModelAdmin.RequestUser_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.ApplicationAdmin.ApplicationRequestUser.RequestUser_app
{
    public class RequestUser_App : IrequestUser_App
    {
        private readonly Isevice_RequestUser context;
        public RequestUser_App(Isevice_RequestUser _context)
        {
            context = _context;
        }

        //get all receive user
        public async Task<List<GetAllReceive_Vm>> GetAllReceiveUser()
        {
            var result = await context.GetAllReceiveUser();
            return result;
        }

        //get request user "Chưa Giải Quyết"
        public async Task<List<GetAllRequestUser_Vm>> GetAllRequestUser_Notresolved(int Selecter)
        {
            var result = await context.GetAllRequestUser_Notresolved(Selecter);
            return result;
        }

        //get all status request user
        public async Task<List<GetAllStatusRequest_Vm>> GetAllStatusRequest()
        {
            var result = await context.GetAllStatusRequest();
            return result;
        }

        //Detail Request User
        public async Task<DetailRequestUser_Vm> DetailRequestUser(int IdRequest)
        {
            var result = await context.DetailRequestUser(IdRequest);
            return result;
        }

        //accept request user
        public async Task<NotificationRequestUser> CacceptRequestUser(int IdRequest, Guid IdUser, int TypeSent)
        {
            var result = await context.CacceptRequestUser(IdRequest, IdUser, TypeSent);
            return result;
        }

        //check type sent request user
        public async Task<NotificationTypeSent_Vm> CheckTypeSentRequestUser(int IdTypeSent)
        {
            var result = await context.CheckTypeSentRequestUser(IdTypeSent);
            return result;
        }

        //Sent email request user
        public async Task<NotificationRequestUser> SentEmailRequestUser(ContentAnswerSentRequestUser request)
        {
            var result = await context.SentEmailRequestUser(request);
            return result;
        }

        //total request user
        public int TotalRequestUser()
        {
            var result = context.TotalRequestUser();
            return result;
        }

        //get all request user for progess
        public async Task<List<GetAllRequestUserProgress>> GetAllProgressRequestUser()
        {
            var result = await context.GetAllProgressRequestUser();
            return result;
        }
    }
}
