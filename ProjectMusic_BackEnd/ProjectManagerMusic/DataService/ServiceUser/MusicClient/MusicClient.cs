using DataMigration.DataEF;
using DataTable.Table.Comment;
using DataTable.Table.Dowload;
using DataTable.Table.Like;
using DataTable.Table.Rating;
using DataViewModel.ViewModelUser.Muisc_Vm;
using DataViewModel.ViewModelUser.RatingClient_Vm;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.ServiceUser.MusicClient
{
    public class MusicClient : ImusicClient
    {
        private readonly ContextDB context;
        public MusicClient(ContextDB _context)
        {
            context = _context;
        }

        //detail muisc client
        public async Task<DetailMuiscClient_V> DetailMuisc(Guid IdMuisc)
        {
            var QueryMusic = await context.T_Musics.FirstOrDefaultAsync(x => x.IdMusic == IdMuisc);
            var QuerySeason = await context.T_Seasons.ToListAsync();
            var QuerySaint = await context.T_Saints.ToListAsync();
            var QueryDowload = await context.T_DowloadMusics.Where(x => x.IdMusic == IdMuisc).ToListAsync();
            var QueryLike = await context.T_LikeMusics.Where(x => x.IdMusic == IdMuisc).ToListAsync();
            var QueryFile = await context.T_FileMusics.FirstOrDefaultAsync(x => x.IdMusic == IdMuisc);
            var QueryComment = await context.T_CommentMusic.Where(x => x.IdMusic == QueryMusic.IdMusic).ToListAsync();
            var result = new DetailMuiscClient_V()
            {
                IdMuisc = QueryMusic.IdMusic,
                NoMuisc = QueryMusic.NoMusic,
                NameMusic = QueryMusic.NameMusic,
                Author = QueryMusic.AuthorMusic,
                DateCreate = QueryMusic.DateCreate,
                Str_DateCreate = QueryMusic.DateCreate.ToString("dd/MM/yyyy"),
                FileName = QueryFile.NameFile,
                ContetnFile = QueryFile.DataFieImage,
                TypeFile = QueryFile.TypeImage,
                IdSeason = QueryMusic.IdSeason,
                NameSeason = QuerySeason.FirstOrDefault(x=>x.IdSeason == QueryMusic.IdSeason).NameSeason,
                IdSaint = QueryMusic.IdSaints,
                NameSaint = QuerySaint.FirstOrDefault(x=>x.IdSaints == QueryMusic.IdSaints).NameSaints,
                TotalLike = QueryLike.Where(x=>x.IdMusic == QueryMusic.IdMusic).Count(),
                TotalDowload = QueryDowload.Where(x=>x.IdMusic == QueryMusic.IdMusic).Count(),
                TotalComment = QueryComment.Count()
             };
            return result;
        }

        //view display pdf with new tap
        public async Task<byte[]> DisplayPDF(Guid IdMuisc)
        {           
            var QueryFile = await context.T_FileMusics.FirstOrDefaultAsync(x => x.IdMusic == IdMuisc);
            return QueryFile.DataFile;
        }

        //dowload muisc pdf file
        public async Task<DowloadMusicPDFfile_V> DowloadMuiscPDFfile(Guid IdMuisc, Guid IdUser)
        {
            var QueryFile = await context.T_FileMusics.FirstOrDefaultAsync(x => x.IdMusic == IdMuisc);
            var QueryUser = await context.T_Users.FirstOrDefaultAsync(x => x.IdUser == IdUser);
            var result = new DowloadMusicPDFfile_V();
            var Setdata = new T_DowloadMusic();
            if (IdUser != new Guid())
            {
                Setdata.IdMusic = QueryFile.IdMusic;
                Setdata.NameUser = QueryUser.FullName;
                Setdata.IdUser = QueryUser.IdUser;
                Setdata.DateCreate = DateTime.UtcNow.AddHours(7);
            }
            else
            {
                Setdata.IdMusic = QueryFile.IdMusic;
                Setdata.NameUser = "Not have account";
                Setdata.DateCreate = DateTime.UtcNow.AddHours(7);
            }
            await context.T_DowloadMusics.AddAsync(Setdata);
            await context.SaveChangesAsync();

            result.DataContent = QueryFile.DataFile;
            result.MineType = QueryFile.MimeType;
            return result;
        }

        //get music client
        public async Task<List<MusicGetAll_V>> GetMusicClient(Guid IdUser)
        {
            var QueryMusic = await context.T_Musics.Where(x => x.IdStatusMusic == 1).ToListAsync();
            var QuerySeason = await context.T_Seasons.ToListAsync();
            var QuerySaint = await context.T_Saints.ToListAsync();
            var QueryLike = await context.T_LikeMusics.ToListAsync();
            var QueryDowload = await context.T_DowloadMusics.ToListAsync();
            var QueryUser = await context.T_Users.FirstOrDefaultAsync(x => x.IdUser == IdUser);
            List<MusicGetAll_V> L_Music = new List<MusicGetAll_V>();
            if(IdUser == new Guid())
            {
                foreach (var item in QueryMusic)
                {
                    var CheckData = new MusicGetAll_V()
                    {
                        IdMuisc = item.IdMusic,
                        NoMusic = item.NoMusic,
                        NameMusic = item.NameMusic,
                        Author = item.AuthorMusic,
                        IdSeason = item.IdSeason,
                        NameSeason = QuerySeason.FirstOrDefault(x => x.IdSeason == item.IdSeason).NameSeason,
                        IdSaint = item.IdSaints,
                        NameSaint = QuerySaint.FirstOrDefault(x => x.IdSaints == item.IdSaints).NameSaints,
                        DateCreate = item.DateCreate,
                        Str_DateCreate = item.DateCreate.ToString("dd/MM/yyyy"),
                        Like = QueryLike.Where(x => x.IdMusic == item.IdMusic).Count(),
                        Dowload = QueryDowload.Where(x => x.IdMusic == item.IdMusic).Count(),
                        UserLike = 1
                    };
                    L_Music.Add(CheckData);
                }
            }
            else
            {
                foreach (var item in QueryMusic)
                {
                    var CheckLike = QueryLike.FirstOrDefault(x => x.IdMusic == item.IdMusic && x.IdUser == QueryUser.IdUser);
                    var CheckData = new MusicGetAll_V()
                    {
                        IdMuisc = item.IdMusic,
                        NoMusic = item.NoMusic,
                        NameMusic = item.NameMusic,
                        Author = item.AuthorMusic,
                        IdSeason = item.IdSeason,
                        NameSeason = QuerySeason.FirstOrDefault(x => x.IdSeason == item.IdSeason).NameSeason,
                        IdSaint = item.IdSaints,
                        NameSaint = QuerySaint.FirstOrDefault(x => x.IdSaints == item.IdSaints).NameSaints,
                        DateCreate = item.DateCreate,
                        Str_DateCreate = item.DateCreate.ToString("dd/MM/yyyy"),
                        Like = QueryLike.Where(x => x.IdMusic == item.IdMusic).Count(),
                        Dowload = QueryDowload.Where(x => x.IdMusic == item.IdMusic).Count(),
                        UserLike = (CheckLike != null)? 2 : 1,
                    };
                    L_Music.Add(CheckData);
                }
            }
            return L_Music.OrderByDescending(x=>x.DateCreate).ToList();
        }

        //plus like muisc by id user
        public async Task<PlusLikeMuisc_V> PlusMuiscByIdUser(Guid Iduser, Guid IdMuisc)
        {
            var QueryMuisc = await context.T_Musics.FirstOrDefaultAsync(x => x.IdMusic == IdMuisc && x.IdStatusMusic == 1);
            var QueryUser = await context.T_Users.FirstOrDefaultAsync(x => x.IdUser == Iduser && x.IdAccountActiver == 1);
            var QueryLike = await context.T_LikeMusics.FirstOrDefaultAsync(x => x.IdUser == Iduser && x.IdMusic == IdMuisc);
            var result = new PlusLikeMuisc_V();
            if(QueryMuisc == null)
            {
                result.IdSatus = 1; //not find muisc this id 
                result.Status = false;
            }
            else
            {
                if(QueryUser == null)
                {
                    result.IdSatus = 2; // not find user this id
                    result.Status = false;
                }
                else
                {
                    if(QueryLike != null)
                    {
                        result.IdSatus = 3; // This user were like this muisc
                        result.Status = false;
                    }
                    else
                    {
                        var SetLike = new T_LikeMusic()
                        {
                            IdMusic = QueryMuisc.IdMusic,
                            IdUser = QueryUser.IdUser,
                            LikeStatus = true,
                            DateLike = DateTime.UtcNow.AddHours(7)
                        };
                        await context.T_LikeMusics.AddAsync(SetLike);
                        await context.SaveChangesAsync();
                        result.IdSatus = 4; //plus like muisc success
                        result.Status = true;
                    }
                }
            }
            return result;
            
        }

        //load all comment by idMuisc
        public async Task<List<CommentMuiscClient_V>> GetAllCommentByIdMuisc(Guid IdMuisc)
        {
            var QueryComment = await context.T_CommentMusic.Where(x => x.IdMusic == IdMuisc).ToListAsync();
            var QueryUser = await context.T_Users.ToListAsync();
            List<CommentMuiscClient_V> L_Comment = new List<CommentMuiscClient_V>();
            foreach(var item in QueryComment)
            {
                var SetData = new CommentMuiscClient_V()
                {
                    IdComments = item.IdComment,
                    IdMuisc = item.IdMusic,
                    IdUser = item.IdUser,
                    NameUser = QueryUser.FirstOrDefault(x=>x.IdUser == item.IdUser).FullName,
                    Content = item.ContentComment,
                    DateCreate = item.DateCreate,
                    Str_DateCreate = item.DateCreate.ToString("dd/MM/yyyy")
                };
                L_Comment.Add(SetData);
            }
            return L_Comment.OrderByDescending(x => x.DateCreate).ToList();
        }

        //sent comment muisc 
        public async Task<List<CommentMuiscClient_V>> SentCommentMuisc(CommentMuiscClient_V request)
        {
            var QueryMuisc = await context.T_Musics.FirstOrDefaultAsync(x => x.IdMusic == request.IdMuisc 
                                                                                            && x.IdStatusMusic == 1);
            var QueryUser = await context.T_Users.FirstOrDefaultAsync(x => x.IdUser == request.IdUser 
                                                                                            && x.IdAccountActiver == 1);
            List<CommentMuiscClient_V> result = new List<CommentMuiscClient_V>();
            if(QueryMuisc == null)
            {
                return result;
            }
            else
            {
                if(QueryUser == null)
                {
                    return result;
                }
                else
                {
                    var Setdata = new T_CommentMusic()
                    {
                        IdMusic = QueryMuisc.IdMusic,
                        IdUser = QueryUser.IdUser,
                        ContentComment = request.Content,
                        DateCreate = request.DateCreate
                    };
                    await context.T_CommentMusic.AddAsync(Setdata);
                    await context.SaveChangesAsync();
                    result = await GetAllCommentByIdMuisc(QueryMuisc.IdMusic);
                }
            }
            return result;
        }

        //get all rating muisc by id user
        public async Task<List<RatingMusic_V>> GetAllRatingByIdMuisc(Guid IdMuisc)
        {
            var QueryRating = await context.T_Ratings.Where(x => x.IdMusic == IdMuisc).ToListAsync();
            var QueryUser = await context.T_Users.ToListAsync();
            List<RatingMusic_V> L_muisc = new List<RatingMusic_V>();
            foreach(var item in QueryRating)
            {
                var result = new RatingMusic_V()
                {
                    IdRating = item.IdRating,
                    IdMuisc = item.IdMusic,
                    IsUser = item.IdUser,
                    NameUser = QueryUser.FirstOrDefault(x=>x.IdUser == item.IdUser).FullName,
                    Ratings = item.Rating,
                    Str_DateCreate = item.DateCreate.ToString("dd/MM/yyyy"),
                    DateCreate = item.DateCreate
                };
                L_muisc.Add(result);
            }
            return L_muisc;
        }

        public async Task<SentRatingMusic_V> SentRatingMuisc(RatingMusic_V request)
        {
            var QueryRating = await context.T_Ratings.FirstOrDefaultAsync(x => x.IdMusic == request.IdMuisc 
                                                                                && x.IdUser == request.IsUser);
            var result = new SentRatingMusic_V();
            if(QueryRating != null)
            {
                result.Notification = 1; //user was rating muisc not rating again
                result.L_Rating = await GetAllRatingByIdMuisc(QueryRating.IdMusic);
            }
            else
            {
                var C_data = new T_Rating()
                {
                    IdMusic = request.IdMuisc,
                    IdUser = request.IsUser,
                    Rating = request.Ratings,
                    DateCreate = request.DateCreate
                };
                await context.T_Ratings.AddAsync(C_data);
                await context.SaveChangesAsync();
                result.Notification = 2; //rating successfully
                result.L_Rating = await GetAllRatingByIdMuisc(C_data.IdMusic);
            }
            return result;
        }

        //view rating muisc by id muisc
        public async Task<List<ViewRatingsClient_V>> ViewRatingMuiscClient(Guid IdMuisc)
        {
            List<ViewRatingsClient_V> L_muisc = new List<ViewRatingsClient_V>();
            for(int i = 1; i <= 5; i++)
            {
                switch (i)
                {
                    case 1:
                        var Start_1 = await CountRatingByStart(i, IdMuisc);
                        L_muisc.Add(Start_1);
                        break;
                    case 2:
                        var Start_2 = await CountRatingByStart(i, IdMuisc);
                        L_muisc.Add(Start_2);
                        break;
                    case 3:
                        var Start_3 = await CountRatingByStart(i, IdMuisc);
                        L_muisc.Add(Start_3);
                        break;
                    case 4:
                        var Start_4 = await CountRatingByStart(i, IdMuisc);
                        L_muisc.Add(Start_4);
                        break;
                    case 5:
                        var Start_5 = await CountRatingByStart(i, IdMuisc);
                        L_muisc.Add(Start_5);
                        break;
                }
            }
            return L_muisc;
        }

        //count rating by start
        private async Task<ViewRatingsClient_V> CountRatingByStart(int Start, Guid IdMuisc)
        {
            var QueryRating = await context.T_Ratings.Where(x => x.IdMusic == IdMuisc).ToListAsync();
            var QueryUser = await context.T_Users.ToListAsync();
            var result = new ViewRatingsClient_V();
            var L_Rating = new List<RatingMusic_V>();
            foreach (var item in QueryRating.Where(x=>x.Rating == Start).ToList())
            {
                var SetData = new RatingMusic_V()
                {
                    IdRating = item.IdRating,
                    IdMuisc = item.IdMusic,
                    IsUser = item.IdUser,
                    Ratings = item.Rating,
                    NameUser = QueryUser.FirstOrDefault(x=>x.IdUser == item.IdUser).FullName,
                    Str_DateCreate = item.DateCreate.ToString("dd/MM/yyyy"),
                    DateCreate = item.DateCreate
                };
                L_Rating.Add(SetData);
            }
            result.L_Ratings = L_Rating;
            result.DefaultStart = Start;
            return result;
        }

        //total muisc yesterday
        public int TotalMuiscYesteray()
        {
            var Yesterday = DateTime.UtcNow.AddHours(7).AddDays(-1);
            var QueryMuisc = context.T_Musics.Where(x => x.DateCreate == Yesterday).ToList();
            return QueryMuisc.Count();
        }
    }
}
