using DataMigration.DataEF;
using DataViewModel.ViewModelAdmin.Rating_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.ServiceAdmin.Ratings
{
    public class Rating_Service : Irating_Service
    {
        private readonly ContextDB context;
        public Rating_Service(ContextDB _context)
        {
            context = _context;
        }

        //get ratin by id music
        public List<GetAllRating_Vm> GetRatingByMusic(Guid IdMusic)
        {
            var Q_Rating = context.T_Ratings.Where(x => x.IdMusic == IdMusic).ToList();
            if(Q_Rating.Count() == 0)
            {
                return new List<GetAllRating_Vm>();
            }
            var Q_User = context.T_Users.ToList();
            var Q_UserRole = context.T_UserRoles.ToList();
            var Q_Role = context.T_Roles.ToList();
            List<GetAllRating_Vm> L_Rating = new List<GetAllRating_Vm>();
            foreach(var item in Q_Rating)
            {
                var Find_User = Q_User.FirstOrDefault(x => x.IdUser == item.IdUser);
                var Find_UserRole = Q_UserRole.FirstOrDefault(x => x.IdUser == Find_User.IdUser);
                var Find_Role = Q_Role.FirstOrDefault(x => x.IdRole == Find_UserRole.IdRole);
                var result = new GetAllRating_Vm()
                {
                    Id = item.IdRating,
                    IdMusic = item.IdMusic,
                    IdUser = Find_User.IdUser,
                    NameUser = Find_User.FullName,
                    NameRole = Find_Role.Name,
                    Rating = item.Rating,
                    DateCreate = item.DateCreate.ToString("dd/MM/yyyy"),
                    TimeCreate = item.DateCreate.ToShortTimeString()
                };
                L_Rating.Add(result);
            }
            return L_Rating;
        }
    }
}
