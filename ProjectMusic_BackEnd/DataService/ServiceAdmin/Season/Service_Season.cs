using DataMigration.DataEF;
using DataService.ServiceAdmin.User;
using DataService.ServiceUser.NotificatonUser;
using DataViewModel.ViewModelAdmin.Music_Vm;
using DataViewModel.ViewModelAdmin.Season_Vm;
using DataViewModel.ViewModelUser.Notification_Vm;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.ServiceAdmin.Season
{
    public class Service_Season : Iservice_Season
    {
        private readonly ContextDB context;
        private readonly INotificationUser notificationUser;
        private readonly IUser user;
        public Service_Season(ContextDB _context, INotificationUser _notificationUser, IUser _user)
        {
            context = _context;
            notificationUser = _notificationUser;
            user = _user;
        }

        //change status season
        public async Task<NotificationMusic_V> ChangeStatusSeason(int IdSeason, int IdStatus, string FullName)
        {
            var Query = await context.T_Seasons.FirstOrDefaultAsync(x => x.IdSeason == IdSeason);
            var result = new NotificationMusic_V();
            if(Query == null)
            {
                result.IsStatus = 1; //not find season
                result.Status = false;
                return result;
            }
            else
            {
                var Query_Status = await context.T_StatusSeasons.FirstOrDefaultAsync(x => x.IdStatusSeason == IdStatus);
                if(Query_Status != null)
                {
                    Query.IdStatusSeason = IdStatus;
                    context.Update(Query);
                    //add notification
                    var L_AllUser = user.GetAllUser();
                    if (L_AllUser.Count() != 0)
                    {
                        foreach (var item in L_AllUser)
                        {
                            var Result_N = new CreateNotification_v()
                            {
                                IdUser = item.IdUser,
                                IdViewNotification = 2,
                                IdDeleteNotification = 1,
                                TitleNotification = "Mùa " + Query.NameSeason +
                                                    "đã được đổi trạng thái thành " + Query_Status.NameStatus +
                                                    " ,do nhân viên " + FullName + " thay đổi",
                                DateCreate = DateTime.UtcNow.AddHours(7),
                                TimeCreate = DateTime.UtcNow.AddHours(7),
                                AuthorNotification = FullName,
                            };
                            notificationUser.CreateNotification(Result_N);
                        }
                    }
                    await context.SaveChangesAsync();
                    result.IsStatus = 2; // change status success
                    result.Status = true;
                    return result;
                }
                else
                {
                    result.IsStatus = 3; //not find id Status
                    result.Status = false;
                    return result;
                }
            }
        }

        //get all season
        public List<GetAllSeason_V> GetAllSeason()
        {
            var Query = from S in context.T_Seasons
                        join T in context.T_StatusSeasons on S.IdStatusSeason equals T.IdStatusSeason
                        select new { S, T };

            var result = Query.OrderByDescending(x => x.S.IdSeason).Select(x => new GetAllSeason_V() {
                Id = x.S.IdSeason,
                Name = x.S.NameSeason,
                DateCreate = x.S.DateCreate.ToString("dd/MM/yyyy"),
                TimeCreate = x.S.DateCreate.ToShortTimeString(),
                IdStatusSeason = x.S.IdStatusSeason,
                NameStatus = x.T.NameStatus
            }).ToList();
            return result;
        }

        //get all status season
        public List<GetAllStatusSeason_V> GetAllStatusSeason()
        {
            var Query = from S in context.T_StatusSeasons
                        select new { S };
            var result = Query.OrderByDescending(x => x.S.IdStatusSeason).Select(x => new GetAllStatusSeason_V()
            {
                Id = x.S.IdStatusSeason,
                Name = x.S.NameStatus
            }).ToList();
            return result;
        }

        //view list music by id season
        public List<GetAll_V> ListMusicByIdSeason(int IdSeason)
        {
            var Query = from M in context.T_Musics
                        join S in context.T_Seasons on M.IdSeason equals S.IdSeason
                        join T in context.T_StatusMusics on M.IdStatusMusic equals T.IdStatusMusic
                        where M.IdStatusMusic != 3 && S.IdStatusSeason == 1 && M.IdSeason == IdSeason
                        select new { M, S, T };
            var L_Data = Query.Select(x => new GetAll_V()
            {
                IdMusic = x.M.IdMusic,
                NoMusic = x.M.NoMusic,
                IdStatusMusic = x.M.IdStatusMusic,
                IdSeason = x.M.IdSeason,
                NameSeason = x.S.NameSeason,
                NameMusic = x.M.NameMusic,
                NameStatusMusic = x.T.NameStatusMusic,
                DateCreate = x.M.DateCreate,
                TimeCreate = x.M.TimeCreate.ToLongTimeString(),
                C_dateCreate = x.M.DateCreate.ToString("dd/MM/yyyy")
            }).ToList();
            return L_Data;
        }

    }
}
