using DataMigration.DataEF;
using DataService.ServiceAdmin.Comment_Answer;
using DataService.ServiceAdmin.Ratings;
using DataService.ServiceAdmin.Saint;
using DataService.ServiceAdmin.Season;
using DataService.ServiceAdmin.User;
using DataService.ServiceUser.NotificatonUser;
using DataTable.Table.Dowload;
using DataTable.Table.Music;
using DataViewModel.ViewModelAdmin.Comment_Vm;
using DataViewModel.ViewModelAdmin.Dowload_Vm;
using DataViewModel.ViewModelAdmin.Music_Vm;
using DataViewModel.ViewModelAdmin.Rating_Vm;
using DataViewModel.ViewModelUser.Notification_Vm;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.ServiceAdmin.Music
{
    public class Serivce_Music : Iserivce_Music
    {
        private readonly ContextDB context;
        private readonly IUser user;
        private readonly INotificationUser notificationUser;
        private readonly Icomment_Answer L_CommentByIdMusic;
        private readonly Irating_Service L_RatingByIdMusic;
        private readonly Iservice_Saint L_Saint;
        private readonly Iservice_Season L_Season;
        public Serivce_Music(ContextDB _context,
                            IUser _user,
                            INotificationUser _notificationUser,
                            Icomment_Answer _L_CommentByIdMusic,
                            Irating_Service _L_RatingByIdMusic,
                            Iservice_Saint _L_Saint,
                            Iservice_Season _L_Season)
        {
            context = _context;
            user = _user;
            notificationUser = _notificationUser;
            L_CommentByIdMusic = _L_CommentByIdMusic;
            L_RatingByIdMusic = _L_RatingByIdMusic;
            L_Saint = _L_Saint;
            L_Season = _L_Season;
        }

        //change status music
        public async Task<NotificationMusic_V> ChangeStatusMusic(int IdStatus, Guid IdMusic, Guid IdUser)
        {
            var Query = await context.T_Musics.FirstOrDefaultAsync(x => x.IdMusic == IdMusic);
            var Query_User = await context.T_Users.FirstOrDefaultAsync(x => x.IdUser == IdUser);
            var Query_Status = await context.T_StatusMusics.FirstOrDefaultAsync(x => x.IdStatusMusic == IdStatus);
            var result = new NotificationMusic_V();
            if (Query == null)
            {
                result.IsStatus = 1; // not find music
                result.Status = false;
                return result;
            }
            if (Query_User == null)
            {
                result.IsStatus = 2; //not find user
                result.Status = false;
                return result;
            }
            Query.IdStatusMusic = IdStatus;
            context.T_Musics.Update(Query);
            await context.SaveChangesAsync();
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
                        TitleNotification = "Bài hát " + Query.NameMusic +
                                            "đã được đổi trạng thái thành " + Query_Status.NameStatusMusic +
                                            " ,do nhân viên " + Query_User.FullName + " thay đổi",
                        DateCreate = DateTime.UtcNow.AddHours(7),
                        TimeCreate = DateTime.UtcNow.AddHours(7),
                        AuthorNotification = Query_User.FullName,
                    };
                    notificationUser.CreateNotification(Result_N);
                }
                result.IsStatus = 3; // change success
                result.Status = true;
                return result;
            }
            result.IsStatus = 4; // change error
            result.Status = false;
            return result;
        }

        //create music
        public async Task<NotificationMusic_V> CreateMusic(CreateMusic_V request)
        {
            var CheckFileName = await context.T_FileMusics
                                        .Where(x => x.NameFile.Contains(request.FileName)).ToListAsync();
            var result = new NotificationMusic_V();
            if (CheckFileName.Count() != 0)
            {
                result.IsStatus = 3;
                result.Status = false;
                return result;
            }
            else
            {
                var CreateData = new T_Music()
                {
                    IdMusic = new Guid(),
                    NoMusic = request.NoMusic,
                    NameMusic = request.NameMusic,
                    AuthorMusic = request.AuthorMusic,
                    IdSeason = request.IdSeason,
                    DateCreate = request.DateCreate,
                    IdStatusMusic = request.IdStatusMusic,
                    IdUser = request.IdUser,
                    IdStaff = request.IdStaff,
                    TimeCreate = request.TimeCreate,
                    IdSaints = (request.IdSaints != 0) ? request.IdSaints : 8,
                    Date = request.Date,
                    Month = request.Month,
                    Year = request.Year,
                    TokenData = request.TokenData
                };
                await context.AddAsync(CreateData);
                var CreateFile = new T_FileMusic()
                {
                    IdMusic = CreateData.IdMusic,
                    NameFile = request.FileName,
                    DataFile = request.ContentFile,
                    MimeType = request.MimeType,
                    DateCreate = request.DateCreate,
                    NameImage = request.FileImage.FileName,
                    DataFieImage = request.ContentFileImage,
                    TypeImage = request.TypeImage
                };
                await context.AddAsync(CreateFile);
                await context.SaveChangesAsync();
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
                            TitleNotification = "Có một bài hát mới đã được tạo là: " + request.FileName,
                            DateCreate = DateTime.UtcNow.AddHours(7),
                            TimeCreate = DateTime.UtcNow.AddHours(7),
                            AuthorNotification = request.FileName,
                        };
                        notificationUser.CreateNotification(Result_N);
                    }
                }
                result.IsStatus = 1;
                result.Status = true;
                return result;
            }
            result.IsStatus = 2;
            result.Status = false;
            return result;
        }

        //delete music
        public async Task<NotificationMusic_V> DeleteMusic(Guid IdMusic, Guid IdUser, List<Guid> L_IdMuisc)
        {
            var result = new NotificationMusic_V();
            var Query_User = await context.T_Users.FirstOrDefaultAsync(x => x.IdUser == IdUser);
            if (Query_User == null)
            {
                result.IsStatus = 2; //not find id user
                result.Status = false;
                return result;
            }
            //a music
            if (IdMusic != new Guid())
            {
                var Query = await context.T_Musics
                    .FirstOrDefaultAsync(x => x.IdMusic == IdMusic && x.IdStatusMusic != 3);
                if (Query == null)
                {
                    result.IsStatus = 1; //not find id music
                    result.Status = false;
                    return result;
                }
                Query.IdStatusMusic = 3;
                context.T_Musics.Update(Query);
                await context.SaveChangesAsync();
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
                            TitleNotification = "Bài hát " + Query.NameMusic +
                                                " đã bị xóa, do nhân viên " + Query_User.FullName + " xóa ",
                            DateCreate = DateTime.UtcNow.AddHours(7),
                            TimeCreate = DateTime.UtcNow.AddHours(7),
                            AuthorNotification = Query_User.FullName,
                        };
                        notificationUser.CreateNotification(Result_N);
                    }
                    result.IsStatus = 3; // delete success
                    result.Status = true;
                    return result;
                }
            }
            //list music
            if (L_IdMuisc.Count() != 0)
            {
                var Query_L = await context.T_Musics.ToListAsync();
                foreach (var item in L_IdMuisc)
                {
                    var CheckData = Query_L.FirstOrDefault(x => x.IdMusic == item);
                    if (CheckData != null)
                    {
                        CheckData.IdStatusMusic = 3;
                        context.T_Musics.Update(CheckData);
                        await context.SaveChangesAsync();
                        //add notification
                        var L_AllUser = user.GetAllUser();
                        if (L_AllUser.Count() != 0)
                        {
                            foreach (var item_User in L_AllUser)
                            {
                                var Result_N = new CreateNotification_v()
                                {
                                    IdUser = item_User.IdUser,
                                    IdViewNotification = 2,
                                    IdDeleteNotification = 1,
                                    TitleNotification = "Bài hát " + CheckData.NameMusic +
                                                        " đã bị xóa, do nhân viên " + Query_User.FullName + " xóa ",
                                    DateCreate = DateTime.UtcNow.AddHours(7),
                                    TimeCreate = DateTime.UtcNow.AddHours(7),
                                    AuthorNotification = Query_User.FullName,
                                };
                                notificationUser.CreateNotification(Result_N);
                            }
                        }
                    }

                }
                result.IsStatus = 3; // delete success
                result.Status = true;
                return result;
            }
            result.IsStatus = 4; //delete erorr
            result.Status = false;
            return result;
        }

        //detail music
        public async Task<DetailMusic_V> DetailMusic(Guid IdMusic)
        {
            var Q_Music = await context.T_Musics.FirstOrDefaultAsync(x => x.IdMusic == IdMusic);
            if (Q_Music == null)
            {
                return new DetailMusic_V();
            }
            var Q_StatusMusic = await context.T_StatusMusics
                                        .FirstOrDefaultAsync(x => x.IdStatusMusic == Q_Music.IdStatusMusic);
            var Q_Season = await context.T_Seasons.FirstOrDefaultAsync(x => x.IdSeason == Q_Music.IdSeason);
            var Q_Saint = await context.T_Saints.FirstOrDefaultAsync(x => x.IdSaints == Q_Music.IdSaints);
            var Q_User = await context.T_Users.FirstOrDefaultAsync(x => x.IdUser == Q_Music.IdUser);
            var Q_UserRole = await context.T_UserRoles.FirstOrDefaultAsync(x => x.IdUser == Q_User.IdUser);
            var Q_Role = await context.T_Roles.FirstOrDefaultAsync(x => x.IdRole == Q_UserRole.IdRole);
            var Q_FileMusic = await context.T_FileMusics.FirstOrDefaultAsync(x => x.IdMusic == Q_Music.IdMusic);
            var Q_QR = await context.T_ImageQRCores.Where(x => x.IdMusic == Q_Music.IdMusic).ToListAsync();
            var Q_Dowload = await context.T_DowloadMusics.Where(x => x.IdMusic == Q_Music.IdMusic).ToListAsync();
            var Q_Like = await context.T_LikeMusics
                                        .Where(x => x.IdMusic == Q_Music.IdMusic && x.LikeStatus == true).ToListAsync();
            var L_Comment = L_CommentByIdMusic.GetCommentByIdMusic(Q_Music.IdMusic);
            var L_Ratings = L_RatingByIdMusic.GetRatingByMusic(Q_Music.IdMusic);
            var result = new DetailMusic_V()
            {
                IdMusic = Q_Music.IdMusic,
                NoMusic = Q_Music.NoMusic,
                IdUser = Q_User.IdUser,
                IdStaff = Q_User.IdStaff,
                NameStaff = Q_User.FullName,
                NameRole = Q_Role.Name,
                DateCreate = Q_Music.DateCreate.ToString("dd/MM/yyyy"),
                LikeMusic = Q_Like.Count(),
                NumberDowload = Q_Dowload.Count(),
                TimeCreate = Q_Music.TimeCreate.ToShortTimeString(),
                NumberQR = Q_QR.Count(),
                NameMusic = Q_Music.NameMusic,
                Author = Q_Music.AuthorMusic,
                NameSeason = Q_Season.NameSeason,
                NameSaint = Q_Saint.NameSaints,
                NameStatus = Q_StatusMusic.NameStatusMusic,
                NameFile = Q_FileMusic.NameFile,
                ContentFile = Q_FileMusic.DataFile,
                MimeType = Q_FileMusic.MimeType,
                ImageMusic = Q_FileMusic.DataFieImage,
                TypeImage = Q_FileMusic.TypeImage,
            };
            return result;

        }

        //dowload music by staff
        public async Task<NotificationMusic_V> DowloadMusicByStaff(DowloadMusic_V request)
        {
            var Query = await context.T_Musics.FirstOrDefaultAsync(x => x.IdMusic == request.IdMusic);
            var QueryUser = await context.T_Users.FirstOrDefaultAsync(x => x.IdUser == request.IdUser);
            var QueryFile = await context.T_FileMusics.FirstOrDefaultAsync(x => x.IdMusic == request.IdMusic);
            var Result = new NotificationMusic_V();
            if (Query == null)
            {
                Result.IsStatus = 1; //not find music
                Result.Status = false;
                return Result;
            }
            if (QueryUser == null)
            {
                Result.IsStatus = 2; //not find user
                Result.Status = false;
                return Result;
            }
            //add notification
            var L_AllUser = user.GetAllUser();
            if (L_AllUser.Count() != 0)
            {
                var DowloadValue = new T_DowloadMusic()
                {
                    IdMusic = Query.IdMusic,
                    NameUser = QueryUser.IdStaff,
                    IdUser = QueryUser.IdUser,
                    DateCreate = DateTime.UtcNow.AddHours(7)
                };
                await context.T_DowloadMusics.AddAsync(DowloadValue);
                await context.SaveChangesAsync();

                foreach (var item in L_AllUser)
                {
                    var Result_N = new CreateNotification_v()
                    {
                        IdUser = item.IdUser,
                        IdViewNotification = 2,
                        IdDeleteNotification = 1,
                        TitleNotification = "Có một nhân viên đã tải về 1 bài hát là: " + Query.NameMusic,
                        DateCreate = DateTime.UtcNow.AddHours(7),
                        TimeCreate = DateTime.UtcNow.AddHours(7),
                        AuthorNotification = QueryUser.FullName,
                    };
                    notificationUser.CreateNotification(Result_N);
                }
                Result.IsStatus = 3;  //dowload success
                Result.Status = true;
                Result.ContentFile = QueryFile.DataFile;
                Result.MineType = QueryFile.MimeType;
                return Result;
            }
            Result.IsStatus = 4;  //dowload erorr
            Result.Status = false; ;
            return Result;
        }

        //get all comment by id music
        public List<GetAllComment_Vm> GetAllCommentByIdMuisc(Guid IdMuisc)
        {
            var L_Comment = L_CommentByIdMusic.GetCommentByIdMusic(IdMuisc);
            return L_Comment;
        }

        //get all rating by id muisc
        public List<GetAllRating_Vm> GetAllRatingByIdMuisc(Guid IdMuisc)
        {
            var L_Ratings = L_RatingByIdMusic.GetRatingByMusic(IdMuisc);
            return L_Ratings;
        }

        //Get all music
        public List<GetAll_V> GetAllMusic()
        {
            var Query = from M in context.T_Musics
                        join S in context.T_Seasons on M.IdSeason equals S.IdSeason
                        join T in context.T_StatusMusics on M.IdStatusMusic equals T.IdStatusMusic
                        where M.IdStatusMusic != 3 && S.IdStatusSeason == 1
                        select new { M, S, T };
            var L_Data = Query.OrderByDescending(x => x.M.NameMusic).Select(x => new GetAll_V()
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

        //get all status music
        public List<GetAllSatusMusic_V> GetAllSatusMusic()
        {
            var Query = from s in context.T_StatusMusics
                        select new { s };
            var result = Query.OrderBy(x => x.s.NameStatusMusic).Select(x => new GetAllSatusMusic_V
            {
                IdStatusMusic = x.s.IdStatusMusic,
                Name = x.s.NameStatusMusic
            }).ToList();
            return result;
        }

        //Update Music
        public async Task<UpdateMuisc_V> GetUpdateMuisc(Guid IdMuisc)
        {
            var Query = await context.T_Musics.FirstOrDefaultAsync(x => x.IdMusic == IdMuisc);
            var Query_File = await context.T_FileMusics.FirstOrDefaultAsync(x => x.IdMusic == Query.IdMusic);
            if (Query == null)
            {
                return new UpdateMuisc_V();
            }
            else
            {
                var result = new UpdateMuisc_V()
                {
                    IdMuisc = Query.IdMusic,
                    NameMuisc = Query.NameMusic,
                    Author = Query.AuthorMusic,
                    NameFile = Query_File.NameFile,
                    ContentFile = Query_File.DataFile,
                    MineType = Query_File.MimeType,
                    TypeImage = Query_File.TypeImage,
                    ContentImage = Query_File.DataFieImage
                };
                var GetSaint = L_Saint.GetAllSaintActiver();
                result.IdSaint = Query.IdSaints;
                result.NameSaint = GetSaint.FirstOrDefault(x => x.IdSaint == Query.IdSaints).NameSaint;
                result.L_Saint = GetSaint.Where(x => x.IdSaint != result.IdSaint).ToList();

                var GetSeason = L_Season.GetAllSeason();
                result.IdSeason = Query.IdSeason;
                result.NameSeason = GetSeason.FirstOrDefault(x => x.Id == Query.IdSeason).Name;
                result.L_Season = GetSeason.Where(x => x.Id != result.IdSeason).ToList();
                return result;
            }
        }

        public async Task<NotificationMusic_V> UpdateMuisc(UpdateMuisc_V request)
        {
            var Query_Music = await context.T_Musics.FirstOrDefaultAsync(x => x.IdMusic == request.IdMuisc);
            var result = new NotificationMusic_V();
            var ItemUpdateMusic = new T_UpdateMusic();
            if (Query_Music == null)
            {
                result.IsStatus = 1; //not find Music
                result.Status = false;
                return result;
            }
            else
            {
                var Query_User = await context.T_Users.FirstOrDefaultAsync(x => x.IdUser == request.IdUser);
                if (Query_User == null)
                {
                    result.IsStatus = 2; // not find User
                    result.Status = false;
                    return result;
                }
                else
                {
                    if (request.ContentFile != null && request.ContentImage != null)
                    {
                        var Query_FileMusic = await context.T_FileMusics
                                                    .FirstOrDefaultAsync(x => x.IdMusic == Query_Music.IdMusic);
                        ItemUpdateMusic.FileNameOld = Query_FileMusic.NameFile;

                        Query_FileMusic.NameFile = request.NameFile;
                        Query_FileMusic.DataFile = request.ContentFile;
                        Query_FileMusic.MimeType = request.MineType;
                        Query_FileMusic.DataFieImage = request.ContentImage;
                        Query_FileMusic.TypeImage = request.TypeImage;
                        context.T_FileMusics.Update(Query_FileMusic);
                    }
                    ItemUpdateMusic.IdMusic = Query_Music.IdMusic;
                    ItemUpdateMusic.IdUser = Query_User.IdUser;
                    ItemUpdateMusic.TokenData = request.TokenData;
                    ItemUpdateMusic.FileNameNew = (ItemUpdateMusic.FileNameOld != null)
                                                    ? request.NameFile : "Not Update File";
                    ItemUpdateMusic.NameMusicOld = Query_Music.NameMusic;
                    ItemUpdateMusic.NameMuiscNew = request.NameMuisc;
                    ItemUpdateMusic.AuthorOld = Query_Music.AuthorMusic;
                    ItemUpdateMusic.AuthorNew = request.Author;
                    ItemUpdateMusic.IdSeasonOld = Query_Music.IdSeason;
                    ItemUpdateMusic.IdSaintOld = Query_Music.IdSaints;
                    ItemUpdateMusic.IdSeasonNew = request.IdSeason;
                    ItemUpdateMusic.IdSaintNew = request.IdSaint;
                    ItemUpdateMusic.DateUpdate = request.DateUpdate;
                    await context.AddAsync(ItemUpdateMusic);

                    Query_Music.NameMusic = request.NameMuisc;
                    Query_Music.AuthorMusic = request.Author;
                    Query_Music.IdSeason = request.IdSeason;
                    Query_Music.IdSaints = request.IdSaint;
                    context.T_Musics.Update(Query_Music);

                    await context.SaveChangesAsync();

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
                                TitleNotification = "Bài bát: "
                                                    + ItemUpdateMusic.NameMusicOld +
                                                    " đã được cập nhật lại "
                                                    + ItemUpdateMusic.NameMuiscNew +
                                                    " người cập nhật là nhân viên: "
                                                    + Query_User.FullName,
                                DateCreate = DateTime.UtcNow.AddHours(7),
                                TimeCreate = DateTime.UtcNow.AddHours(7),
                                AuthorNotification = Query_User.FullName,
                            };
                            notificationUser.CreateNotification(Result_N);
                        }
                        result.IsStatus = 3;  //update success
                        result.Status = true;
                        return result;
                    }
                }
            }
            result.IsStatus = 4; //update fail
            result.Status = false;
            return result;
        }

        //get all history update  muisc
        public List<GetAllHistoryUpdate_V> GetAllHistoryUpdate(Guid IdMuisc)
        {
            var result = context.T_UpdateMusics.OrderByDescending(x => x.Id).Where(x => x.IdMusic == IdMuisc).ToList();
            List<GetAllHistoryUpdate_V> L_History = new List<GetAllHistoryUpdate_V>();
            foreach (var item in result)
            {
                var DataItem = new GetAllHistoryUpdate_V()
                {
                    Id = item.Id,
                    IdMuisc = item.IdMusic,
                    IdUser = item.IdUser,
                    TokenData = item.TokenData,
                    FileNameOld = item.FileNameOld,
                    FileNameNew = item.FileNameNew,
                    NameMusicOld = item.NameMusicOld,
                    NameMuiscNew = item.NameMuiscNew,
                    AuthorOld = item.AuthorOld,
                    AuthorNew = item.AuthorNew,
                    IdSeasonOld = item.IdSeasonOld,
                    IdSaintOld = item.IdSaintOld,
                    IdSeasonNew = item.IdSeasonNew,
                    IdSaintNew = item.IdSaintNew,
                    NameSeason = (item.IdSeasonNew != 0) ?
                                    L_Season.GetAllSeason().FirstOrDefault(x => x.Id == item.IdSeasonNew).Name
                                    : "Not Update",
                    NameSaint = (item.IdSaintNew != 0) ?
                                    L_Saint.GetAllSaint().FirstOrDefault(x => x.IdSaint == item.IdSaintNew).NameSaint
                                    : "Not Update",
                    DateUpdate = item.DateUpdate.ToString("dd/MM/yyyy")
                };
                L_History.Add(DataItem);
            }
            return L_History;
        }

        //activer file muisc
        public async Task<NotificationMusic_V> ActiverFileMusic(List<Guid> IdMuisc, string NameStaff)
        {
            var Query = await context.T_Musics.Where(x => x.IdStatusMusic == 2).ToListAsync();
            var result = new NotificationMusic_V();
            if(Query.Count() == 0)
            {
                result.IsStatus = 1; //not find list music
                result.Status = false;
            }
            else
            {
                foreach(var item in IdMuisc)
                {
                    var Check = Query.FirstOrDefault(x => x.IdMusic == item);
                    if(Check != null)
                    {
                        Check.IdStatusMusic = 1;
                        context.T_Musics.Update(Check);
                        //add notification
                        var L_AllUser = user.GetAllUser();
                        if (L_AllUser.Count() != 0)
                        {
                            foreach (var item_User in L_AllUser)
                            {
                                var Result_N = new CreateNotification_v()
                                {
                                    IdUser = item_User.IdUser,
                                    IdViewNotification = 2,
                                    IdDeleteNotification = 1,
                                    TitleNotification = "Bài hát " + Check.NameMusic +
                                                        " đã được kích hoạt, do nhân viên " + NameStaff + " kích hoạt ",
                                    DateCreate = DateTime.UtcNow.AddHours(7),
                                    TimeCreate = DateTime.UtcNow.AddHours(7),
                                    AuthorNotification = NameStaff,
                                };
                                notificationUser.CreateNotification(Result_N);
                            }
                        }                        
                    }
                }
                await context.SaveChangesAsync();
                result.IsStatus = 2; //activer success
                result.Status = true;
            }
            return result;
        }

        //get all dowload music
        public List<GetAllDowload_V> GetAllDowloadMusic()
        {
            var Query = context.T_DowloadMusics.ToList();
            List<GetAllDowload_V> L_Dowload = new List<GetAllDowload_V>();
            if (Query.Count() == 0)
            {
                return L_Dowload;
            }
            else
            {
                var Query_User = context.T_Users.ToList();
                var Query_Music = context.T_Musics.ToList();
                var Query_File = context.T_FileMusics.ToList();
                foreach(var item in Query)
                {
                    var FindIdUser = Query_User.FirstOrDefault(x => x.IdUser == item.IdUser);
                    if(FindIdUser == null)
                    {
                        var GetItem = new GetAllDowload_V()
                        {
                            Id = item.IdDowload,
                            NoMusic = Query_Music.FirstOrDefault(x => x.IdMusic == item.IdMusic).NoMusic,
                            IdMusic = Query_Music.FirstOrDefault(x => x.IdMusic == item.IdMusic).IdMusic,
                            NameMusic = Query_Music.FirstOrDefault(x => x.IdMusic == item.IdMusic).NameMusic,
                            Author = Query_Music.FirstOrDefault(x => x.IdMusic == item.IdMusic).AuthorMusic,
                            contentImage = Query_File.FirstOrDefault(x => x.IdMusic == item.IdMusic).DataFieImage,
                            DateDowload = item.DateCreate.ToString("dd/MM/yyyy"),
                            TimeDowload = item.DateCreate.ToShortDateString()
                        };
                        L_Dowload.Add(GetItem);
                    }
                    else
                    {
                        var GetItem = new GetAllDowload_V()
                        {
                            Id = item.IdDowload,
                            NoMusic = Query_Music.FirstOrDefault(x => x.IdMusic == item.IdMusic).NoMusic,
                            IdMusic = Query_Music.FirstOrDefault(x => x.IdMusic == item.IdMusic).IdMusic,
                            NameMusic = Query_Music.FirstOrDefault(x => x.IdMusic == item.IdMusic).NameMusic,
                            Author = Query_Music.FirstOrDefault(x => x.IdMusic == item.IdMusic).AuthorMusic,
                            contentImage = Query_File.FirstOrDefault(x => x.IdMusic == item.IdMusic).DataFieImage,
                            FullName = Query_User.FirstOrDefault(x => x.IdUser == item.IdUser).FullName,
                            IdStaff = Query_User.FirstOrDefault(x => x.IdUser == item.IdUser).IdStaff,
                            DateDowload = item.DateCreate.ToString("dd/MM/yyyy"),
                            TimeDowload = item.DateCreate.ToShortDateString()
                        };
                        L_Dowload.Add(GetItem);
                    }                   
                }
                return L_Dowload;
            }

        }

        //delete dowload music
        public async Task<NotificationMusic_V> DeleteMusicDowload(List<int> L_Music, int IdDowload)
        {
            var Query = await context.T_DowloadMusics.ToListAsync();
            var result = new NotificationMusic_V();
            if(Query.Count() == 0)
            {
                result.IsStatus = 1; //not find list music dowload
                result.Status = false;
            }

            //delete a dowlaod music
            if (L_Music.Count() == 0 && IdDowload != 0)
            {
                var checkdata = Query.FirstOrDefault(x => x.IdDowload == IdDowload);
                if (checkdata != null)
                {
                    context.T_DowloadMusics.Remove(checkdata);
                }
                result.IsStatus = 4; //delete a dowload music success
                result.Status = true;
                await context.SaveChangesAsync();
                return result;
            }
            //delete list dowload music
            if(L_Music.Count() != 0 && IdDowload == 0)
            {
                foreach (var item in L_Music)
                {
                    var checkdata = Query.FirstOrDefault(x => x.IdDowload == item);
                    if (checkdata != null)
                    {
                        context.T_DowloadMusics.Remove(checkdata);
                    }
                }              
                result.IsStatus = 2; //delete list dowload music success
                result.Status = true;
                await context.SaveChangesAsync();
                return result;
            }           

            result.IsStatus = 5; //delete music dowload erorr
            result.Status = false;
            return result;
        }

        //detail dowload music
        public async Task<GetAllDowload_V> DetailDowloadMusic(int IdDowload)
        {
            var result = new GetAllDowload_V();
            var Query = await context.T_DowloadMusics.FirstOrDefaultAsync(x => x.IdDowload == IdDowload);
            if(Query != null)
            {
                var Query_music = await context.T_Musics.FirstOrDefaultAsync(x => x.IdMusic == Query.IdMusic);
                var Query_File = await context.T_FileMusics.FirstOrDefaultAsync(x => x.IdMusic == Query.IdMusic);
                var Query_User = await context.T_Users.FirstOrDefaultAsync(x => x.IdUser == Query.IdUser);
                result.Id = Query.IdDowload;
                result.IdMusic = Query_music.IdMusic;
                result.NoMusic = Query_music.NoMusic;
                result.NameMusic = Query_music.NameMusic;
                result.Author = Query_music.AuthorMusic;
                result.contentImage = Query_File.DataFieImage;
                result.TypeImage = Query_File.TypeImage;
                result.IdUser = (Query_User == null) ? new Guid() : Query_User.IdUser;
                result.FullName = (Query_User == null) ? Query.NameUser : Query_User.FullName;
                result.IdStaff = (Query_User == null) ? null : Query_User.IdStaff;
                result.DateDowload = Query.DateCreate.ToString("dd/MM/yyyy");
                result.TimeDowload = Query.DateCreate.ToShortTimeString();
                return result;
            }
            else
            {
                return result;
            }
        }

        //get all delete music
        public List<GetAll_V> GetAllDeleteMusic()
        {
            var Query = from M in context.T_Musics
                        join S in context.T_Seasons on M.IdSeason equals S.IdSeason
                        join T in context.T_StatusMusics on M.IdStatusMusic equals T.IdStatusMusic
                        where M.IdStatusMusic == 3 && S.IdStatusSeason == 1
                        select new { M, S, T };
            var L_Data = Query.OrderByDescending(x => x.M.NameMusic).Select(x => new GetAll_V()
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

        //Recover music delete
        public async Task<NotificationMusic_V> RecoverMusicDelete(List<Guid> L_Music, Guid IdMusic, int Flag, Guid IdUser)
        {
            var Query = await context.T_Musics.Where(x => x.IdStatusMusic == 3).ToListAsync();
            var result = new NotificationMusic_V();
            if(Query.Count() == 0)
            {
                result.IsStatus = 3; // not find list music delete
                result.Status = false;
            }
            else
            {
                var Query_User = await context.T_Users.FirstOrDefaultAsync(x => x.IdUser == IdUser);
                switch (Flag)
                {
                    case 1:
                        //recover list music
                        foreach(var item in L_Music)
                        {
                            var check = Query.FirstOrDefault(x => x.IdMusic == item);
                            if(check != null)
                            {
                                check.IdStatusMusic = 1;
                                context.T_Musics.Update(check);

                                //add notification
                                var L_AllUser = user.GetAllUser();
                                if (L_AllUser.Count() != 0)
                                {
                                    foreach (var item_Chirl in L_AllUser)
                                    {
                                        var Result_N = new CreateNotification_v()
                                        {
                                            IdUser = item_Chirl.IdUser,
                                            IdViewNotification = 2,
                                            IdDeleteNotification = 1,
                                            TitleNotification = "Bài bát: "
                                                                + check.NameMusic +
                                                                " đã được thay đổi trạng thái đã xóa, "
                                                                + " thành cho phép sử dụng "
                                                                + " người cập nhật là nhân viên: "
                                                                + Query_User.FullName,
                                            DateCreate = DateTime.UtcNow.AddHours(7),
                                            TimeCreate = DateTime.UtcNow.AddHours(7),
                                            AuthorNotification = Query_User.FullName,
                                        };
                                        notificationUser.CreateNotification(Result_N);
                                    }
                                }
                                await context.SaveChangesAsync();
                            }
                        }
                        result.IsStatus = 4; //recover list music delete success
                        result.Status = true;
                        break;

                    case 2:
                        //recover a music
                        var checkMusic = Query.FirstOrDefault(x => x.IdMusic == IdMusic);
                        if(checkMusic != null)
                        {
                            checkMusic.IdStatusMusic = 1;
                            context.T_Musics.Update(checkMusic);

                            //add notification
                            var L_AllUser = user.GetAllUser();
                            if (L_AllUser.Count() != 0)
                            {
                                foreach (var item_Chirl in L_AllUser)
                                {
                                    var Result_N = new CreateNotification_v()
                                    {
                                        IdUser = item_Chirl.IdUser,
                                        IdViewNotification = 2,
                                        IdDeleteNotification = 1,
                                        TitleNotification = "Bài bát: "
                                                            + checkMusic.NameMusic +
                                                            " đã được thay đổi trạng thái đã xóa, "
                                                            + " thành cho phép sử dụng "
                                                            + " người cập nhật là nhân viên: "
                                                            + Query_User.FullName,
                                        DateCreate = DateTime.UtcNow.AddHours(7),
                                        TimeCreate = DateTime.UtcNow.AddHours(7),
                                        AuthorNotification = Query_User.FullName,
                                    };
                                    notificationUser.CreateNotification(Result_N);
                                }
                            }
                            await context.SaveChangesAsync();
                            result.IsStatus = 5; //recover a music delete success
                            result.Status = true;
                        }
                        break;
                }
            }
            return result;
        }

        //Get 10 new music
        public List<GetAll_V> GetNewMusic()
        {
            var Query = from M in context.T_Musics
                        join S in context.T_Seasons on M.IdSeason equals S.IdSeason
                        join T in context.T_StatusMusics on M.IdStatusMusic equals T.IdStatusMusic
                        where M.IdStatusMusic != 3 && S.IdStatusSeason == 1
                        select new { M, S, T };
            var L_Data = Query.OrderByDescending(x => x.M.DateCreate).Take(10).Select(x => new GetAll_V()
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
