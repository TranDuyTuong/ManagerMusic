using DataMigration.DataEF;
using DataService.ServiceAdmin.User;
using DataService.ServiceUser.NotificatonUser;
using DataTable.Table.Saints;
using DataViewModel.ViewModelAdmin.Music_Vm;
using DataViewModel.ViewModelAdmin.Saint_Vm;
using DataViewModel.ViewModelUser.Notification_Vm;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.ServiceAdmin.Saint
{
    public class Service_Saint : Iservice_Saint
    {
        private readonly ContextDB context;
        private readonly IUser user;
        private readonly INotificationUser notificationUser;
        public Service_Saint(ContextDB _context, 
                            IUser _user,
                            INotificationUser _notificationUser)
        {
            context = _context;
            user = _user;
            notificationUser = _notificationUser;
        }

        //change status saint 
        public async Task<NotificationMusic_V> ChangeStatusSaint(GetAllSaint_V request, string NameStaff)
        {
            var result = new NotificationMusic_V();
            var Query = await context.T_Saints.FirstOrDefaultAsync(x => x.IdSaints == request.IdSaint);
            if(Query == null)
            {
                result.IsStatus = 1; //not find saint
                result.Status = false;
            }
            else
            {
                var QueryStatus = await context.T_StatusSaints
                                        .FirstOrDefaultAsync(x => x.IdIdStatusSaints == request.IdStatuSaint);
                if(QueryStatus == null)
                {
                    result.IsStatus = 2; // not find Id Status
                    result.Status = false;
                }
                else
                {
                    Query.IdStatusSaints = request.IdStatuSaint;
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
                                TitleNotification = "Ngày lễ " + Query.NameSaints +
                                                    " đã được thay đổi trạng thái từ " + QueryStatus.NameStatusSaints +
                                                    " thành " + request.Name_Status +
                                                    " ,do nhân viên " + NameStaff + " cập nhật",
                                DateCreate = DateTime.UtcNow.AddHours(7),
                                TimeCreate = DateTime.UtcNow.AddHours(7),
                                AuthorNotification = NameStaff,
                            };
                            notificationUser.CreateNotification(Result_N);
                        }
                    }
                    await context.SaveChangesAsync();
                    result.IsStatus = 3; //change status success
                    result.Status = true;
                }
              
            }
            return result;
        }

        //create new saint
        public async Task<NotificationMusic_V> CreateSaint(CreateSaint_V request)
        {
            var results = new NotificationMusic_V();
            var result = new T_Saints()
            {
                NameSaints = request.NameSaint,
                DateCreate = request.DateCreate,
                IdStatusSaints = request.IdStatusSaint,
                IdStaff = request.IdStaff,
                IdUser = request.IdUser,
                TokenData = request.TokenData
            };
            await context.AddAsync(result);
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
                        TitleNotification = "Ngày lễ " + request.NameSaint +
                                            " đã được thêm mới vào danh sách các ngày lễ " +
                                            " ,do nhân viên " + request.FullName + " thêm mới",
                        DateCreate = DateTime.UtcNow.AddHours(7),
                        TimeCreate = DateTime.UtcNow.AddHours(7),
                        AuthorNotification = request.FullName,
                    };
                    notificationUser.CreateNotification(Result_N);
                }
            }
            await context.SaveChangesAsync();
            results.IsStatus = 3; // create success
            results.Status = true;
            return results;
        }

        //get all music by id saint
        public List<GetAll_V> GetAllMusicByIdSaint(int IdSaint)
        {
            var Query = from M in context.T_Musics
                        join S in context.T_Seasons on M.IdSeason equals S.IdSeason
                        join T in context.T_StatusMusics on M.IdStatusMusic equals T.IdStatusMusic
                        join Sa in context.T_Saints on M.IdSaints equals Sa.IdSaints
                        where M.IdStatusMusic != 3 && M.IdSaints == IdSaint
                        select new { M, S, T, Sa };
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

        //get all saint
        public List<GetAllSaint_V> GetAllSaint()
        {
            var Query = from S in context.T_Saints
                        join T in context.T_StatusSaints on S.IdStatusSaints equals T.IdIdStatusSaints
                        select new { S, T };
            var result = Query.Select(x => new GetAllSaint_V()
            {
                IdSaint = x.S.IdSaints,
                NameSaint = x.S.NameSaints,
                Date_Create = x.S.DateCreate.ToString("dd/MM/yyyy"),
                Time_Create = x.S.DateCreate.ToShortTimeString(),
                DateCreate = x.S.DateCreate,
                Name_Status = x.T.NameStatusSaints,
                IdStatuSaint = x.S.IdStatusSaints
            }).ToList();
            return result;
        }

        //get all saint activer
        public List<GetAllSaint_V> GetAllSaintActiver()
        {
            var Query = from S in context.T_Saints
                        join T in context.T_StatusSaints on S.IdStatusSaints equals T.IdIdStatusSaints
                        where S.IdStatusSaints == 1
                        select new { S, T };
            var result = Query.Select(x => new GetAllSaint_V()
            {
                IdSaint = x.S.IdSaints,
                NameSaint = x.S.NameSaints,
                Date_Create = x.S.DateCreate.ToString("dd/MM/yyyy"),
                Time_Create = x.S.DateCreate.ToShortTimeString(),
                Name_Status = x.T.NameStatusSaints,
                IdStatuSaint = x.S.IdStatusSaints
            }).ToList();
            return result;
        }

        //get all status saint
        public List<GetAllStatusSaint_V> GetAllStatusSaint(int IdSaint)
        {
            var QuerySaint = context.T_Saints.FirstOrDefault(x => x.IdSaints == IdSaint);
            var QueryById = context.T_StatusSaints.FirstOrDefault(x => x.IdIdStatusSaints == QuerySaint.IdStatusSaints);
            var Query = context.T_StatusSaints.Where(x => x.IdIdStatusSaints != QueryById.IdIdStatusSaints).ToList();
            List<GetAllStatusSaint_V> L_Status = new List<GetAllStatusSaint_V>();
            var result_Data = new GetAllStatusSaint_V()
            {
                Id = QueryById.IdIdStatusSaints,
                Name = QueryById.NameStatusSaints
            };
            L_Status.Add(result_Data);
            foreach (var item in Query)
            {
                var result = new GetAllStatusSaint_V()
                {
                    Id = item.IdIdStatusSaints,
                    Name = item.NameStatusSaints
                };
                L_Status.Add(result);
            }
            return L_Status;
        }


        //get data update saint
        public async Task<GetAllSaint_V> GetDataUpdateSaint(int IdSaint)
        {
            var Query = await context.T_Saints.FirstOrDefaultAsync(x => x.IdSaints == IdSaint);
            var result = new GetAllSaint_V();
            if(Query == null)
            {
                return result;
            }
            else
            {
                var QuerySatus = await context.T_StatusSaints
                                        .FirstOrDefaultAsync(x => x.IdIdStatusSaints == Query.IdStatusSaints);
                result.NameSaint = Query.NameSaints;
                result.IdSaint = Query.IdSaints;
                result.Date_Create = Query.DateCreate.ToString("dd/MM/yyyy");
                result.Time_Create = Query.DateCreate.ToShortTimeString();
                result.Name_Status = QuerySatus.NameStatusSaints;
                result.IdStatuSaint = QuerySatus.IdIdStatusSaints;
                return result;
            }
        }

        //update saint
        public async Task<NotificationMusic_V> UpdateSaint(GetAllSaint_V request, string NameStaff)
        {
            var Query = await context.T_Saints.FirstOrDefaultAsync(x => x.IdSaints == request.IdSaint);
            var result = new NotificationMusic_V();
            if(Query == null)
            {
                result.IsStatus = 1; //not find saint
                result.Status = false;
            }
            else
            {
                string oldName = Query.NameSaints;
                Query.NameSaints = request.NameSaint;
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
                            TitleNotification = "Ngày lễ " + oldName +
                                                " đã được cập nhật lại thành, " + request.NameSaint +
                                                " ,do nhân viên " + NameStaff + " cập nhật",
                            DateCreate = DateTime.UtcNow.AddHours(7),
                            TimeCreate = DateTime.UtcNow.AddHours(7),
                            AuthorNotification = NameStaff,
                        };
                        notificationUser.CreateNotification(Result_N);
                    }
                }
                await context.SaveChangesAsync();
                result.IsStatus = 2; //update saint success
                result.Status = true;
            }
            return result;
        }

    }
}
