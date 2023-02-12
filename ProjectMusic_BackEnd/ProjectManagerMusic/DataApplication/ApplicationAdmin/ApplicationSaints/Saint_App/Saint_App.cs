using DataService.ServiceAdmin.Saint;
using DataViewModel.ViewModelAdmin.Music_Vm;
using DataViewModel.ViewModelAdmin.Saint_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.ApplicationAdmin.ApplicationSaints.Saint_App
{
    public class Saint_App : ISaint_App
    {
        private readonly Iservice_Saint context;
        public Saint_App(Iservice_Saint _context)
        {
            context = _context;
        }

        //change status saint
        public async Task<NotificationMusic_V> ChangeStatusSaint(GetAllSaint_V request, string NameStaff)
        {
            var Result = await context.ChangeStatusSaint(request, NameStaff);
            return Result;
        }

        //create new saint
        public async Task<NotificationMusic_V> CreateNewSaint(CreateSaint_V request)
        {
            var result = new NotificationMusic_V();
            if (request.IdUser == new Guid())
            {
                result.IsStatus = 1; //null id user
                result.Status = false;
            }
            else
            {
                request.IdStatusSaint = 1;
                request.DateCreate = DateTime.UtcNow.AddHours(7);
                result = await context.CreateSaint(request);
            }
            return result;
        }

        //get all saint
        public Paing_Saint_V GetAllSaint(int PageIndex, int PageSize, int sort, string Seach)
        {
            var result = context.GetAllSaint();
            var modal = new Paing_Saint_V();
            if (result.Count() == 0)
            {
                modal.Total = result.Count();
            }
            else
            {
                List<GetAllSaint_V> L_Saints = new List<GetAllSaint_V>();
                switch (sort)
                {
                    case 1:
                        if (Seach != null)
                        {
                            L_Saints = result.OrderByDescending(x => x.IdSaint).Where(x => x.NameSaint.Contains(Seach))
                                                .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                        }
                        else
                        {
                            L_Saints = result.OrderByDescending(x => x.IdSaint)
                                                .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                        }
                        break;

                    case -1:
                        if (Seach != null)
                        {
                            L_Saints = result.OrderBy(x => x.IdSaint).Where(x => x.NameSaint.Contains(Seach))
                                                .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                        }
                        else
                        {
                            L_Saints = result.OrderBy(x => x.IdSaint)
                                                .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                        }
                        break;

                    case 2:
                        if (Seach != null)
                        {
                            L_Saints = result.OrderByDescending(x => x.NameSaint).Where(x => x.NameSaint.Contains(Seach))
                                        .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                        }
                        else
                        {
                            L_Saints = result.OrderByDescending(x => x.NameSaint)
                                    .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                        }
                        break;

                    case -2:
                        if (Seach != null)
                        {
                            L_Saints = result.OrderBy(x => x.NameSaint).Where(x => x.NameSaint.Contains(Seach))
                                        .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                        }
                        else
                        {
                            L_Saints = result.OrderBy(x => x.NameSaint)
                                    .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                        }
                        break;

                    case 3:
                        if (Seach != null)
                        {
                            L_Saints = result.OrderByDescending(x => x.DateCreate).Where(x => x.NameSaint.Contains(Seach))
                                        .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                        }
                        else
                        {
                            L_Saints = result.OrderByDescending(x => x.DateCreate)
                                    .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                        }
                        break;

                    case -3:
                        if (Seach != null)
                        {
                            L_Saints = result.OrderBy(x => x.DateCreate).Where(x => x.NameSaint.Contains(Seach))
                                        .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                        }
                        else
                        {
                            L_Saints = result.OrderBy(x => x.DateCreate)
                                    .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                        }
                        break;

                    case 4:
                        if (Seach != null)
                        {
                            L_Saints = result.OrderByDescending(x => x.IdStatuSaint).Where(x => x.NameSaint.Contains(Seach))
                                        .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                        }
                        else
                        {
                            L_Saints = result.OrderByDescending(x => x.IdStatuSaint)
                                    .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                        }
                        break;

                    case -4:
                        if (Seach != null)
                        {
                            L_Saints = result.OrderBy(x => x.IdStatuSaint).Where(x => x.NameSaint.Contains(Seach))
                                        .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                        }
                        else
                        {
                            L_Saints = result.OrderBy(x => x.IdStatuSaint)
                                    .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                        }
                        break;
                }
                modal.L_Saint = L_Saints;
                modal.Total = result.Count();
            }
            return modal;
        }

        //get all saint activer
        public List<GetAllSaint_V> GetAllSaintActiver()
        {
            var result = context.GetAllSaint();
            List<GetAllSaint_V> L_Saints = new List<GetAllSaint_V>();
            L_Saints = result.Where(x => x.IdStatuSaint == 1).ToList();
            return L_Saints;
        }

        //get all status saint
        public List<GetAllStatusSaint_V> GetAllStatusSaint(int IdSaint)
        {
            var result = context.GetAllStatusSaint(IdSaint);
            return result;
        }

        //get data update saint
        public async Task<GetAllSaint_V> GetDataUpdateSaint(int IdSaint)
        {
            var result = new GetAllSaint_V();
            if (IdSaint == 0)
            {
                return result;
            }
            else
            {
                result = await context.GetDataUpdateSaint(IdSaint);
                return result;
            }
        }

        //get all music by id saint
        public PagingMusic_V ListMusicById_Saint(int IdSaint, int PageIndex, int PageSize, int sort)
        {
            var modal = new PagingMusic_V();
            var result = context.GetAllMusicByIdSaint(IdSaint);
            List<GetAll_V> L_Music = new List<GetAll_V>();
            if (sort != 0)
            {
                switch (sort)
                {
                    case 1:
                        L_Music = result.OrderByDescending(x => x.NoMusic)
                                       .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                        break;
                    case -1:
                        L_Music = result.OrderBy(x => x.NoMusic)
                                    .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                        break;
                    case 2:
                        L_Music = result.OrderByDescending(x => x.NameMusic)
                                    .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                        break;
                    case -2:
                        L_Music = result.OrderBy(x => x.NameMusic)
                                    .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                        break;
                    case 3:
                        L_Music = result.OrderByDescending(x => x.DateCreate)
                                    .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                        break;
                    case -3:
                        L_Music = result.OrderBy(x => x.DateCreate)
                                    .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                        break;
                    case 4:
                        L_Music = result.OrderByDescending(x => x.IdStatusMusic)
                                    .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                        break;
                    case -4:
                        L_Music = result.OrderBy(x => x.IdStatusMusic)
                                    .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                        break;
                }
            }
            modal.L_Music = L_Music;
            modal.Total = result.Count();
            return modal;
        }

        //update saint
        public async Task<NotificationMusic_V> UpdateSaint(GetAllSaint_V request, string NameSatff)
        {
            var result = await context.UpdateSaint(request, NameSatff);
            return result;
        }

    }
}
