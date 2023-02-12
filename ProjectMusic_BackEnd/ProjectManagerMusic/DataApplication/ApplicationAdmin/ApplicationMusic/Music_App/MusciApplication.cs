using DataApplication.ApplicationAdmin.ApplicationStaff.Staff_App;
using DataService.ServiceAdmin.Music;
using DataViewModel.ViewModelAdmin.Comment_Vm;
using DataViewModel.ViewModelAdmin.Dowload_Vm;
using DataViewModel.ViewModelAdmin.Music_Vm;
using DataViewModel.ViewModelAdmin.Rating_Vm;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.ApplicationAdmin.ApplicationMusic.Music_App
{
    public class MusciApplication : ImusicApplication
    {
        private readonly Iserivce_Music context;
        private readonly Istaff_app convertImage;
        public MusciApplication(Iserivce_Music _context, Istaff_app _convertImage)
        {
            context = _context;
            convertImage = _convertImage;
        }

        //change status music
        public async Task<NotificationMusic_V> ChangeStatusMusic(int IdStatus, Guid IdMusic, Guid IdUser)
        {
            if(IdUser == new Guid())
            {
                var resultErorr = new NotificationMusic_V()
                {
                    IsStatus = 5, //Id user null
                    Status = false
                };
                return resultErorr;
            }
            var result = await context.ChangeStatusMusic(IdStatus, IdMusic, IdUser);
            return result;
        }

        //create music
        public async Task<NotificationMusic_V> CreateMusic(CreateMusic_V request)
        {                  
            using(var ms = new MemoryStream())
            {
                request.FileMusic.CopyTo(ms);
                request.MimeType = request.FileMusic.ContentType;
                request.ContentFile = ms.ToArray();
            }
            //conver image from IFormFile -> bye[]
            if (request.FileImage.Length > 0)
            {
                var ImageConvert = await convertImage.ConverFromFileToByte(request.FileImage);
                request.ContentFileImage = ImageConvert;
            }
            var result = await context.CreateMusic(request);
            return result;
        }

        //delete music
        public async Task<NotificationMusic_V> DeleteMusic(Guid IdMusic, Guid IdUser, List<Guid> L_IdMuisc)
        {
            if(IdUser == new Guid())
            {
                var result = new NotificationMusic_V()
                {
                    IsStatus = 5, //id user null
                    Status = false
                };
                return result;
            }
            else
            {
                var result = await context.DeleteMusic(IdMusic, IdUser, L_IdMuisc);
                return result;
            }
        }

        //detail music
        public async Task<DetailMusic_V> DetailMusic(Guid IdMusic)
        {
            var result = await context.DetailMusic(IdMusic);
            return result;
        }

        //dowload music staff
        public async Task<NotificationMusic_V> DowloadMusicStaff(DowloadMusic_V request)
        {
            var result = new NotificationMusic_V();
            if(request.IdUser == new Guid())
            {
                result.IsStatus = 5; // IdUser null
                result.Status = false;
                return result;
            }
            else
            {
                result = await context.DowloadMusicByStaff(request);
                return result;
            }

        }

        //get all rating by id music
        public List<GetAllRating_Vm> GetAllRatingByIdMuisc(Guid IdMuisc)
        {
            var result = context.GetAllRatingByIdMuisc(IdMuisc);
            return result;

        }

        //get all comment by id music
        public List<GetAllComment_Vm> GetAllCommentByIdMuisc(Guid IdMuisc)
        {
            var result = context.GetAllCommentByIdMuisc(IdMuisc);
            return result;
        }

        //GetALL Music
        public PagingMusic_V GetAllMusic(int PageSize, int PageIndex, int IdSeason, 
                                            string SeachKey, int IdStatus, int Sort_No)
        {
            var L_Music = context.GetAllMusic();
            var ModelData = new PagingMusic_V();
            if(L_Music.Count() == 0)
            {
                ModelData.L_Music = L_Music;
                ModelData.Total = L_Music.Count();
            }
            else
            {
                List<GetAll_V> L_MusicPaging = new List<GetAll_V>();
                //check sort Id music
                if(Sort_No == 1)
                {
                    //check season
                    if (IdSeason != 0)
                    {
                        if (SeachKey != null)
                        {
                            //seach by name
                            L_MusicPaging = L_Music.OrderByDescending(x=>x.NoMusic).Where(x => x.IdSeason == IdSeason && x.NameMusic.Contains(SeachKey))
                              .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                            //seach by Id Music
                            if (L_MusicPaging.Count() == 0)
                            {
                                L_MusicPaging = L_Music.OrderByDescending(x => x.NoMusic).Where(x => x.IdSeason == IdSeason && x.NoMusic.Contains(SeachKey))
                              .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                            }
                            //seach by Season
                            if (L_MusicPaging.Count() == 0)
                            {
                                L_MusicPaging = L_Music.OrderByDescending(x => x.NoMusic).Where(x => x.IdSeason == IdSeason && x.NameSeason.Contains(SeachKey))
                              .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                            }
                            //filter status music by seach key
                            if (IdStatus != 0)
                            {
                                ModelData.L_Music = L_MusicPaging.Where(x => x.IdStatusMusic == IdStatus).ToList();
                            }
                            else
                            {
                                ModelData.L_Music = L_MusicPaging;
                            }
                            ModelData.Total = L_Music.Count();
                        }
                        else
                        {
                            L_MusicPaging = L_Music.OrderByDescending(x => x.NoMusic).Where(x => x.IdSeason == IdSeason)
                              .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                            //filter status music by seach key
                            if (IdStatus != 0)
                            {
                                ModelData.L_Music = L_MusicPaging.Where(x => x.IdStatusMusic == IdStatus).ToList();
                            }
                            else
                            {
                                ModelData.L_Music = L_MusicPaging;
                            }
                            ModelData.Total = L_Music.Count();
                        }
                    }
                    else
                    {
                        if (SeachKey != null)
                        {
                            //seach by name
                            L_MusicPaging = L_Music.OrderByDescending(x => x.NoMusic).Where(x => x.NameMusic.Contains(SeachKey))
                              .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                            //seach by Id Music
                            if (L_MusicPaging.Count() == 0)
                            {
                                L_MusicPaging = L_Music.OrderByDescending(x => x.NoMusic).Where(x => x.NoMusic.Contains(SeachKey))
                              .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                            }
                            //seach by Season
                            if (L_MusicPaging.Count() == 0)
                            {
                                L_MusicPaging = L_Music.OrderByDescending(x => x.NoMusic).Where(x => x.NameSeason.Contains(SeachKey))
                              .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                            }
                            //filter status music by seach key
                            if (IdStatus != 0)
                            {
                                ModelData.L_Music = L_MusicPaging.Where(x => x.IdStatusMusic == IdStatus).ToList();
                            }
                            else
                            {
                                ModelData.L_Music = L_MusicPaging;
                            }
                            ModelData.Total = L_Music.Count();
                        }
                        else
                        {
                            L_MusicPaging = L_Music.OrderByDescending(x => x.NoMusic).Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                            //filter status music by seach key
                            if (IdStatus != 0)
                            {
                                ModelData.L_Music = L_MusicPaging.Where(x => x.IdStatusMusic == IdStatus).ToList();
                            }
                            else
                            {
                                ModelData.L_Music = L_MusicPaging;
                            }
                            ModelData.Total = L_Music.Count();
                        }
                    }
                }
                else
                {
                    //check season
                    if (IdSeason != 0)
                    {
                        if (SeachKey != null)
                        {
                            //seach by name
                            L_MusicPaging = L_Music.OrderBy(x => x.NoMusic).Where(x => x.IdSeason == IdSeason && x.NameMusic.Contains(SeachKey))
                              .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                            //seach by Id Music
                            if (L_MusicPaging.Count() == 0)
                            {
                                L_MusicPaging = L_Music.OrderBy(x => x.NoMusic).Where(x => x.IdSeason == IdSeason && x.NoMusic.Contains(SeachKey))
                              .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                            }
                            //seach by Season
                            if (L_MusicPaging.Count() == 0)
                            {
                                L_MusicPaging = L_Music.OrderBy(x => x.NoMusic).Where(x => x.IdSeason == IdSeason && x.NameSeason.Contains(SeachKey))
                              .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                            }
                            //filter status music by seach key
                            if (IdStatus != 0)
                            {
                                ModelData.L_Music = L_MusicPaging.Where(x => x.IdStatusMusic == IdStatus).ToList();
                            }
                            else
                            {
                                ModelData.L_Music = L_MusicPaging;
                            }
                            ModelData.Total = L_Music.Count();
                        }
                        else
                        {
                            L_MusicPaging = L_Music.OrderBy(x => x.NoMusic).Where(x => x.IdSeason == IdSeason)
                              .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                            //filter status music by seach key
                            if (IdStatus != 0)
                            {
                                ModelData.L_Music = L_MusicPaging.Where(x => x.IdStatusMusic == IdStatus).ToList();
                            }
                            else
                            {
                                ModelData.L_Music = L_MusicPaging;
                            }
                            ModelData.Total = L_Music.Count();
                        }
                    }
                    else
                    {
                        if (SeachKey != null)
                        {
                            //seach by name
                            L_MusicPaging = L_Music.OrderBy(x => x.NoMusic).Where(x => x.NameMusic.Contains(SeachKey))
                              .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                            //seach by Id Music
                            if (L_MusicPaging.Count() == 0)
                            {
                                L_MusicPaging = L_Music.OrderBy(x => x.NoMusic).Where(x => x.NoMusic.Contains(SeachKey))
                              .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                            }
                            //seach by Season
                            if (L_MusicPaging.Count() == 0)
                            {
                                L_MusicPaging = L_Music.OrderBy(x => x.NoMusic).Where(x => x.NameSeason.Contains(SeachKey))
                              .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                            }
                            //filter status music by seach key
                            if (IdStatus != 0)
                            {
                                ModelData.L_Music = L_MusicPaging.Where(x => x.IdStatusMusic == IdStatus).ToList();
                            }
                            else
                            {
                                ModelData.L_Music = L_MusicPaging;
                            }
                            ModelData.Total = L_Music.Count();
                        }
                        else
                        {
                            L_MusicPaging = L_Music.OrderBy(x => x.NoMusic).Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                            //filter status music by seach key
                            if (IdStatus != 0)
                            {
                                ModelData.L_Music = L_MusicPaging.Where(x => x.IdStatusMusic == IdStatus).ToList();
                            }
                            else
                            {
                                ModelData.L_Music = L_MusicPaging;
                            }
                            ModelData.Total = L_Music.Count();
                        }
                    }
                }
            }
            return ModelData;
        }

        //get all status music
        public List<GetAllSatusMusic_V> GetAllSatusMusic()
        {
            var result = context.GetAllSatusMusic();
            return result;
        }

        //update muisc
        public async Task<UpdateMuisc_V> GetUpdateMusic(Guid IdMuisc)
        {
            var result = await context.GetUpdateMuisc(IdMuisc);
            return result;
        }

        public async Task<NotificationMusic_V> UpdateMuisc(UpdateMuisc_V request)
        {
            if(request.FormFile_Muisc != null && request.FormFile_Image != null)
            {
                using (var ms = new MemoryStream())
                {
                    request.FormFile_Muisc.CopyTo(ms);
                    request.MineType = request.FormFile_Muisc.ContentType;
                    request.ContentFile = ms.ToArray();
                }
                request.ContentImage = await convertImage.ConverFromFileToByte(request.FormFile_Image);
            }
            var result = await context.UpdateMuisc(request);
            return result;
        }


        // get all update history muisc
        public List<GetAllHistoryUpdate_V> GetAllHistoryUpdate(Guid IdMuisc)
        {
            var result = context.GetAllHistoryUpdate(IdMuisc);
            foreach(var item in result)
            {
                var Stream = item.TokenData;
                var hander = new JwtSecurityTokenHandler();
                var jsontoken = hander.ReadToken(Stream);
                var token = jsontoken as JwtSecurityToken;
                item.NameUser = token.Claims.FirstOrDefault(x => x.Type == "C_FullName").Value;
            }
            return result;
        }

        //activer file muisc
        public async Task<NotificationMusic_V> ActiverFileMusic(List<Guid> L_Muisc, string NameStaff)
        {
            var result = new NotificationMusic_V();
            if (L_Muisc.Count() == 0)
            {
                result.IsStatus = 3; //list muisc mull
                result.Status = false;
            }
            else
            {
                result = await context.ActiverFileMusic(L_Muisc, NameStaff);
            }
            return result;
        }

        //get all file music dowload
        public PagingDowload_V GetAllFileMusicDowload(int PageSize, int PageIndex, string SeachKey)
        {
            var result = context.GetAllDowloadMusic();
            var Result = new PagingDowload_V();
            if (SeachKey != null)
            {
                //seach name music
                Result.L_Dowload = result.OrderByDescending(x => x.Id).Where(x=>x.NameMusic.Contains(SeachKey))
                                                                    .Skip((PageIndex - 1) * PageSize).Take(PageSize);
                //seach Id Music
                if(Result.L_Dowload.Count() == 0)
                {
                    Result.L_Dowload = result.OrderByDescending(x => x.Id).Where(x => x.NoMusic.Contains(SeachKey))
                                                                    .Skip((PageIndex - 1) * PageSize).Take(PageSize);
                }

                Result.Total = result.Count();
            }
            else
            {
                Result.L_Dowload = result.OrderByDescending(x=>x.Id).Skip((PageIndex - 1) * PageSize).Take(PageSize);
                Result.Total = result.Count();
            }           
            return Result;
            
        }

        //delete dowload music
        public async Task<NotificationMusic_V> DeleteDowloadMusic(List<int> IdMusic, int IdDowload)
        {
            var result = new NotificationMusic_V();
            if(IdMusic.Count() == 0 && IdDowload == 0)
            {
                result.IsStatus = 3; //list id music dowload null
                result.Status = false;
            }
            else
            {
                result = await context.DeleteMusicDowload(IdMusic, IdDowload);
            }
            return result;
        }

        //detail dowoad music
        public async Task<GetAllDowload_V> DetailDowloadMusic(int IdDowload)
        {
            var result = await context.DetailDowloadMusic(IdDowload);
            return result;
        }

        //get all music delete
        public PagingMusic_V GetAllMusicDelete(int PageSize, int PageIndex, int SelectSeason, string Seach)
        {
            var modal = new PagingMusic_V();
            var result = context.GetAllDeleteMusic();
            if(result.Count() == 0)
            {
                return modal;
            }
            else
            {
                List<GetAll_V> L_MusicPaging = new List<GetAll_V>();
                if(SelectSeason != 0)
                {
                    if(Seach != null)
                    {
                        //seach by name
                        L_MusicPaging = result.Where(x => x.IdSeason == SelectSeason && x.NameMusic.Contains(Seach))
                          .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                        //seach by Id Music
                        if (L_MusicPaging.Count() == 0)
                        {
                            L_MusicPaging = result.Where(x => x.IdSeason == SelectSeason && x.NoMusic.Contains(Seach))
                          .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                        }
                        //seach by Season
                        if (L_MusicPaging.Count() == 0)
                        {
                            L_MusicPaging = result.Where(x => x.IdSeason == SelectSeason && x.NameSeason.Contains(Seach))
                          .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                        }
                    }
                    else
                    {
                        L_MusicPaging = result.OrderByDescending(x => x.NoMusic).Where(x => x.IdSeason == SelectSeason)
                                        .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                    }
                    modal.L_Music = L_MusicPaging;
                    modal.Total = result.Count();
                }
                else
                {
                    if (Seach != null)
                    {
                        //seach by name
                        L_MusicPaging = result.Where(x => x.NameMusic.Contains(Seach))
                          .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                        //seach by Id Music
                        if (L_MusicPaging.Count() == 0)
                        {
                            L_MusicPaging = result.Where(x => x.NoMusic.Contains(Seach))
                          .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                        }
                        //seach by Season
                        if (L_MusicPaging.Count() == 0)
                        {
                            L_MusicPaging = result.Where(x => x.NameSeason.Contains(Seach))
                          .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                        }
                    }
                    else
                    {
                        L_MusicPaging = result.OrderByDescending(x => x.NoMusic)
                              .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                    }
                    
                    modal.L_Music = L_MusicPaging;
                    modal.Total = result.Count();
                }
                return modal;
            }


        }

        //recover music delete
        public async Task<NotificationMusic_V> RecoverMusicDelete(List<Guid> L_Music, Guid IdMusic, int Flag, Guid IdUser)
        {
            var result = await context.RecoverMusicDelete(L_Music, IdMusic, Flag, IdUser);
            return result;
        }

        //get 10 new music
        public PagingMusic_V GetNewMusic(int PageSize, int PageIndex)
        {
            var result = context.GetNewMusic();
            var modals = new PagingMusic_V();
            List<GetAll_V> L_Music = new List<GetAll_V>();
            if(result.Count() == 0)
            {
                modals.L_Music = L_Music;
                modals.Total = 0;
            }
            else
            {
                L_Music = result.Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                modals.L_Music = L_Music;
                modals.Total = result.Count();
            }
            return modals;
        }


    }
}
