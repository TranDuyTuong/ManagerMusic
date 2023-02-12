using DataApplication.ApplicationUser.ApplicationHome.MusicClient;
using DataViewModel.ViewModelUser.RatingClient_Vm;
using ManagerMusic.Controllers;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

namespace ManagerMusic.Hubs
{
    public class RatingHub: Hub
    {
        private readonly ImusicClient_App context;
        public RatingHub(ImusicClient_App _context)
        {
            context = _context;
        }

        //sent message
        public async Task SendRatings(Guid IdMuisc, int Rating_VL)
        {
            var Stream = ClientListMusicController.GetTokenLogin;
            var hander = new JwtSecurityTokenHandler();
            var jsontoken = hander.ReadToken(Stream);
            var token = jsontoken as JwtSecurityToken;
            Guid IdUser = Guid.Parse(token.Claims.FirstOrDefault(x => x.Type == "C_IdUser").Value);

            var resutl = new RatingMusic_V()
            {
                IdMuisc = IdMuisc,
                IsUser = IdUser,
                Ratings = Rating_VL,
                DateCreate = DateTime.UtcNow.AddHours(7)
            };
            var GetDat = await context.SentRatingMuisc(resutl);
            await Clients.All.SendAsync("ReceiveRating", GetDat);
        }
    }
}
