using DataViewModel.ViewModelAdmin.Comment_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.ServiceAdmin.Comment_Answer
{
    public interface Icomment_Answer
    {
        //get comment by id music
        List<GetAllComment_Vm> GetCommentByIdMusic(Guid IdMusic);

        //get answer by id comment
        List<GetAllAnswer_Vm> GetAnswerByIdComment(int IdComment);

        //get all commnet
        List<GetAllComment_Vm> GetAllComment();
    }
}
