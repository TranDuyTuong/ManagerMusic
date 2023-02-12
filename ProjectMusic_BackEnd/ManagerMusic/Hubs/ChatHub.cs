using DataApplication.ApplicationAdmin.ApplicationStaff.Staff_App;
using DataViewModel.ViewModelAdmin.User_Vm;
using ManagerMusic.Controllers;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ManagerMusic.Hubs
{
    public class ChatHub: Hub
    {
        private readonly Istaff_app context;
        public ChatHub(Istaff_app _context)
        {
            context = _context;
        }

        //sent message
        public async Task SendMessage(Guid IdUser, string FullName, string message)
        {
            var resutl = new CreateChatStaff_V()
            {
                IdUser = IdUser,
                FullName = FullName,
                DateCreate = DateTime.UtcNow.AddHours(7),
                Message = message
            };           
            var GetDat = await context.CreateChatStaff(resutl);
            await Clients.All.SendAsync("BroadcastMessage", GetDat);
        }

        //sent image like
        public async Task SendLikeMessage(Guid IdUser, string FullName, string LikeHtml)
        {
            var resutl = new CreateChatStaff_V()
            {
                IdUser = IdUser,
                FullName = FullName,
                DateCreate = DateTime.UtcNow.AddHours(7),
                Message = LikeHtml
            };
            var GetDat = await context.CreateChatIconMessage(resutl);
            await Clients.All.SendAsync("BroadcastMessage", GetDat);
        }

        //sent image funny
        public async Task SendFunnyMessage(Guid IdUser, string FullName, string FunnyHtml)
        {
            var resutl = new CreateChatStaff_V()
            {
                IdUser = IdUser,
                FullName = FullName,
                DateCreate = DateTime.UtcNow.AddHours(7),
                Message = FunnyHtml
            };
            var GetDat = await context.CreateChatIconMessage(resutl);
            await Clients.All.SendAsync("BroadcastMessage", GetDat);
        }

        //sent image sad
        public async Task SendSadMessage(Guid IdUser, string FullName, string SadHtml)
        {
            var resutl = new CreateChatStaff_V()
            {
                IdUser = IdUser,
                FullName = FullName,
                DateCreate = DateTime.UtcNow.AddHours(7),
                Message = SadHtml
            };
            var GetDat = await context.CreateChatIconMessage(resutl);
            await Clients.All.SendAsync("BroadcastMessage", GetDat);
        }

        //sent image love
        public async Task SendLoveMessage(Guid IdUser, string FullName, string LoveHtml)
        {
            var resutl = new CreateChatStaff_V()
            {
                IdUser = IdUser,
                FullName = FullName,
                DateCreate = DateTime.UtcNow.AddHours(7),
                Message = LoveHtml
            };
            var GetDat = await context.CreateChatIconMessage(resutl);
            await Clients.All.SendAsync("BroadcastMessage", GetDat);
        }

        //sent images
        public async Task SendImages(Guid IdUser, string FullName, string Message)
        {
            var FormData = UserController.L_ChatImages;
            if(FormData.Count == 0)
            {
                var ResultError = new GetAllChatBy_Staff();
                ResultError.Status = false;
                await Clients.All.SendAsync("BroadcastMessage", ResultError);
            }
            else
            {
                var resutl = new CreateChatStaff_V()
                {
                    IdUser = IdUser,
                    FullName = FullName,
                    DateCreate = DateTime.UtcNow.AddHours(7),
                    Message = Message,
                    L_Images = FormData
                };
                var GetDat = await context.CreateImagesChat(resutl);
                UserController.L_ChatImages = new List<GetAllChatImages_V>();
                await Clients.All.SendAsync("BroadcastMessage", GetDat);
            }
        }


 


    }
}
