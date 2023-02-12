using DataService.ServiceAdmin.Season;
using DataViewModel.ViewModelAdmin.Music_Vm;
using DataViewModel.ViewModelAdmin.Season_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.ApplicationAdmin.ApplicationSeason.Season_App
{
    public class Season_App : ISeason_App
    {
        private readonly Iservice_Season _Context;
        public Season_App(Iservice_Season Context)
        {
            _Context = Context;
        }

        //change status season 
        public async Task<NotificationMusic_V> ChangeStatusSeason(int IdSeason, int IdStatus, string FullName)
        {
            var result = await _Context.ChangeStatusSeason(IdSeason, IdStatus, FullName);
            return result;
        }

        //get all
        public Paing_Season GetAllSeason(int PageSize, int PageIndex, int Sort_Id)
        {
            var Query = _Context.GetAllSeason();
            var result = new Paing_Season();
            if(Query.Count() == 0)
            {
                return result;
            }
            else
            {
                List<GetAllSeason_V> L_Data = new List<GetAllSeason_V>();
                if(Sort_Id != 0) {
                    switch (Sort_Id)
                    {
                        case 1:
                            L_Data = Query.OrderByDescending(x=>x.Id).Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                            break;
                        case -1:
                            L_Data = Query.OrderBy(x => x.Id).Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                            break;
                        case 2:
                            L_Data = Query.OrderByDescending(x => x.Name).Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                            break;
                        case -2:
                            L_Data = Query.OrderBy(x => x.Name).Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                            break;
                        default:
                            L_Data = Query.Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                            break;
                    }
                }
                else
                {
                    L_Data = Query.Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                }
                result.L_Season = L_Data;
                result.Total = Query.Count();
                return result;
            }
        }

        public List<GetAllSeason_V> GetAllSeasonNotPaing()
        {
            var result = _Context.GetAllSeason();
            return result;
        }

        //get all status season
        public List<GetAllStatusSeason_V> GetAllStatusSeason()
        {
            var result = _Context.GetAllStatusSeason();
            return result;
        }

        //view list music by id season
        public PagingMusic_V ListMusicByIdSeason(int PageIndex, int PageSize, int IdSeason, int Sort)
        {
            var modal = new PagingMusic_V();
            var result = _Context.ListMusicByIdSeason(IdSeason);
            if(result.Count() == 0)
            {
                modal.Total = 0;
            }
            else
            {
                List<GetAll_V> L_Music = new List<GetAll_V>();
                switch (Sort)
                {
                    case 1:
                        L_Music = result.OrderByDescending(x=>x.NoMusic)
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
                        L_Music = result.OrderByDescending(x => x.NameStatusMusic)
                                            .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                        break;
                    case -4:
                        L_Music = result.OrderBy(x => x.NameStatusMusic)
                                            .Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
                        break;
                }
                modal.L_Music = L_Music;
                modal.Total = result.Count();
            }
            return modal;

        }


    }
}
