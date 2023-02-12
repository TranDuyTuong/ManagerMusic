using DataApplication.ApplicationUser.ApplicationHome.MusicClient;
using DataViewModel.ViewModelUser.Muisc_Vm;
using ManagerMusic.Controllers;
using ManagerMusic.Models.CommentMuisc;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

namespace ManagerMusic.Hubs
{
    public class CommentHub: Hub
    {
        private readonly ImusicClient_App context_S;
        public CommentHub(ImusicClient_App _context_S)
        {
            context_S = _context_S;
        }
        //sent comment muisc
        public async Task SendComment(Guid IdMuisc, string Comment)
        {
            var Stream = ClientListMusicController.GetTokenLogin;
            var hander = new JwtSecurityTokenHandler();
            var jsontoken = hander.ReadToken(Stream);
            var token = jsontoken as JwtSecurityToken;
            Guid IdUser = Guid.Parse(token.Claims.FirstOrDefault(x => x.Type == "C_IdUser").Value);
            var Setdata = new CommentMuiscClient_V()
            {
                IdMuisc = IdMuisc,
                IdUser = IdUser,
                Content = Comment,
                DateCreate = DateTime.UtcNow.AddHours(7)
            };
            var result = await context_S.SentCommentMuisc(Setdata);
            var RetultS = new CommentMuisc();
            RetultS.L_CommentMuisc = result;
            RetultS.TotalComment = result.Count();

            await Clients.All.SendAsync("ReceiveMessage", result);
        }
    }
}
