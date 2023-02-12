using DataMigration.DataEF;
using DataTable.Table.User;
using DataViewModel.ViewModelUser.Notification_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.ServiceUser.NotificatonUser
{
    public class NotificationUser : INotificationUser
    {
        private readonly ContextDB context;
        public NotificationUser(ContextDB _context)
        {
            context = _context;
        }

        //create notification user
        public bool CreateNotification(CreateNotification_v request)
        {
            var result = new T_NotificationUser()
            {
                IdUser = request.IdUser,
                IdViewNotification = request.IdViewNotification,
                IdDeleteNotification = request.IdDeleteNotification,
                TitleNotification = request.TitleNotification,
                DateCreate = request.DateCreate,
                TimeCreate = request.TimeCreate,
                AuthorNotification = request.AuthorNotification,
            };
            context.T_NotificationUsers.Add(result);
            context.SaveChanges();
            return true;
        }

        //get notification by id user
        public List<GetNotificationByUser> GetNotificationByUser(Guid IdUser, int take)
        {
            var Query = from N in context.T_NotificationUsers
                        join
                        V in context.T_ViewNotifications on N.IdViewNotification equals V.IdViewNotification
                        where N.IdUser == IdUser && N.IdDeleteNotification == 1
                        select new { N, V };
            var result = new List<GetNotificationByUser>();
            if (take != 0)
            {
                result = Query.OrderByDescending(x => x.N.IdNotification)
                                        .Take(20).Select(x => new GetNotificationByUser()
                {
                    IdNotification = x.N.IdNotification,
                    IdUser = IdUser,
                    IdViewNotification = x.N.IdViewNotification,
                    NameViewNotification = x.V.Description,
                    TitleNotification = x.N.TitleNotification,
                    DateCreate = x.N.DateCreate.ToString("dd/MM/yyyy"),
                    TimeCreate = x.N.TimeCreate.ToShortTimeString(),
                    AuthorNotification = x.N.AuthorNotification
                }).ToList();
            }
            else
            {
                result = Query.OrderByDescending(x => x.N.IdNotification)
                                                    .Select(x => new GetNotificationByUser()
                {
                    IdNotification = x.N.IdNotification,
                    IdUser = IdUser,
                    IdViewNotification = x.N.IdViewNotification,
                    NameViewNotification = x.V.Description,
                    TitleNotification = x.N.TitleNotification,
                    DateCreate = x.N.DateCreate.ToString("dd/MM/yyyy"),
                    TimeCreate = x.N.TimeCreate.ToShortTimeString(),
                    AuthorNotification = x.N.AuthorNotification
                }).ToList();
            }
            return result;
        }

        //watched notification
        public async Task<bool> WatchedNotification(int Id)
        {
            var result = context.T_NotificationUsers.FirstOrDefault(x => x.IdNotification == Id);
            if(result == null)
            {
                return false;
            }
            else
            {
                result.IdViewNotification = 1;
                context.Update(result);
                await context.SaveChangesAsync();
                return true;
            }
        }

        //delete notification by id user
        public async Task<bool> DeleteNotificationUser(List<int> Id, int IdNotification)
        {
            var result = context.T_NotificationUsers.Where(x=>x.IdDeleteNotification == 1).ToList();
            if(result.Count == 0)
            {
                return false;
            }
            if(Id.Count != 0)
            {
                foreach (var item in Id)
                {
                    var CheckData = result.FirstOrDefault(x => x.IdNotification == item);
                    CheckData.IdDeleteNotification = 2;
                    context.Update(CheckData);
                }
            }
            if(IdNotification != 0)
            {
                var CheckData = result.FirstOrDefault(x => x.IdNotification == IdNotification);
                CheckData.IdDeleteNotification = 2;
                context.Update(CheckData);
            }
            await context.SaveChangesAsync();
            return true;

        }
    }
}
