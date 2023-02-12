using DataMigration.DataEF;
using DataViewModel.ViewModelAdmin.Comment_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.ServiceAdmin.Comment_Answer
{
    public class Comment_Answer: Icomment_Answer
    {
        private readonly ContextDB context;
        public Comment_Answer(ContextDB _context)
        {
            context = _context;
        }

        //get all comment
        public List<GetAllComment_Vm> GetAllComment()
        {
            return new List<GetAllComment_Vm>();
        }

        //get answer by id comment
        public List<GetAllAnswer_Vm> GetAnswerByIdComment(int IdComment)
        {
            var Q_Answer = context.T_AnswerComments.Where(x => x.IdComment == IdComment).ToList();
            if(Q_Answer.Count() == 0)
            {
                return new List<GetAllAnswer_Vm>();
            }
            var Q_User = context.T_Users.ToList();
            var Q_UserRole = context.T_UserRoles.ToList();
            var Q_Role = context.T_Roles.ToList();
            List<GetAllAnswer_Vm> L_Answer = new List<GetAllAnswer_Vm>();
            foreach (var item in Q_Answer)
            {
                var FindData_User = Q_User.FirstOrDefault(x => x.IdUser == item.IdUser);
                var FindData_UserRole = Q_UserRole.FirstOrDefault(x => x.IdUser == FindData_User.IdUser);
                var FinData_Role = Q_Role.FirstOrDefault(x => x.IdRole == FindData_UserRole.IdRole);
                var result = new GetAllAnswer_Vm()
                {
                    Id = item.IdAnswer,
                    IdComment = item.IdComment,
                    IsUser = FindData_User.IdUser,
                    NameUser = FindData_User.FullName,
                    NameRole = FinData_Role.Name,
                    Answer = item.ContentAnswer,
                    DateCreate = item.DateCreate.ToString("dd/MM/yyyy"),
                    TimeCreate = item.DateCreate.ToShortTimeString()
                };
                L_Answer.Add(result);
            }
            return L_Answer;

        }

        //get comment by id muisc
        public List<GetAllComment_Vm> GetCommentByIdMusic(Guid IdMusic)
        {
            var Q_Comment = context.T_CommentMusic.Where(x=>x.IdMusic == IdMusic);
            if(Q_Comment.Count() == 0)
            {
                return new List<GetAllComment_Vm>();
            }
            var Q_User = context.T_Users.ToList();
            var Q_UserRole = context.T_UserRoles.ToList();
            var Q_Role = context.T_Roles.ToList();

            List<GetAllComment_Vm> L_Comment = new List<GetAllComment_Vm>();
            foreach(var item in Q_Comment)
            {
                var FindData_User = Q_User.FirstOrDefault(x => x.IdUser == item.IdUser);
                var FindData_UserRole = Q_UserRole.FirstOrDefault(x => x.IdUser == FindData_User.IdUser);
                var FinData_Role = Q_Role.FirstOrDefault(x => x.IdRole == FindData_UserRole.IdRole);
                var result = new GetAllComment_Vm()
                {
                    Id = item.IdComment,
                    IdMusic = IdMusic,
                    IdUser = FindData_User.IdUser,
                    NameUser = FindData_User.FullName,
                    NameRole = FinData_Role.Name,
                    Comment = item.ContentComment,
                    DateCreate = item.DateCreate.ToString("dd/MM/yyyy"),
                    TimeCreate = item.DateCreate.ToShortTimeString(),
                    L_Answer = GetAnswerByIdComment(item.IdComment)
                };
                L_Comment.Add(result);
            }
            return L_Comment;
        }


    }
}
