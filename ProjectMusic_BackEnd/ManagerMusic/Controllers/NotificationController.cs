using DataApplication.ApplicationUser.ApplicationNotification;
using ManagerMusic.Models.Paging.Page_Notification;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

namespace ManagerMusic.Controllers
{
    [Authorize]
    public class NotificationController : BaseController
    {
        private readonly INotificationUser_App context;
        public NotificationController(INotificationUser_App _context)
        {
            context = _context;
        }

        //get Notification by id user
        [HttpGet]
        public IActionResult GetNotificationByUser(Guid IdUser, int take)
        {
            var result = context.GetNotificationByUser(IdUser, take);
            return new JsonResult(result);
        }

        //watched notification 
        [HttpGet]
        public async Task<IActionResult> WatchNotification(int IdNotification)
        {
            var result = await context.WatchedNotification(IdNotification);
            return new JsonResult(result);
        }

        //view all notification by id user
        [HttpGet]
        public IActionResult PageNotificationUer()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetAllNotificationByIdUser(int PageSize, int PageIndex)
        {
            var Stream = HttpContext.Request.Cookies["Token"];
            var hander = new JwtSecurityTokenHandler();
            var jsontoken = hander.ReadToken(Stream);
            var token = jsontoken as JwtSecurityToken;
            Guid IdUser = Guid.Parse(token.Claims.FirstOrDefault(x => x.Type == "C_IdUser").Value);
            var result = context.GetNotificationByUser(IdUser, 0);
            if (result.Count() == 0)
            {
                return new JsonResult(0);
            }
            else
            {
                var modalPaging = result.Skip((PageIndex - 1) * PageSize).Take(PageSize);
                var Result = new PagingNotification()
                {
                    L_Notification = modalPaging,
                    TotalNotification = result.Count()
                };
                return new JsonResult(Result);
            }
        }

        //delete notification user
        [HttpPost]
        public async Task<IActionResult> JsonDeleteNotification(List<int> Id, int IdNotification)
        {
            var result = await context.DeleteNotification(Id, IdNotification);
            return new JsonResult(result);
        }
    }
}
