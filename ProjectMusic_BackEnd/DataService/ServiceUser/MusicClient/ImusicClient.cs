using DataViewModel.ViewModelUser.Muisc_Vm;
using DataViewModel.ViewModelUser.RatingClient_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.ServiceUser.MusicClient
{
    public interface ImusicClient
    {
        //get all muisc client
        Task<List<MusicGetAll_V>> GetMusicClient(Guid IdUser);

        //like muisc by id user
        Task<PlusLikeMuisc_V> PlusMuiscByIdUser(Guid Iduser, Guid IdMuisc);

        //detail muisc 
        Task<DetailMuiscClient_V> DetailMuisc(Guid IdMuisc);

        //view pdf file with new tap
        Task<byte[]> DisplayPDF(Guid IdMuisc);

        //dowload muisc pdf file
        Task<DowloadMusicPDFfile_V> DowloadMuiscPDFfile(Guid IdMuisc, Guid IdUser);

        //get all comment by id muisc
        Task<List<CommentMuiscClient_V>> GetAllCommentByIdMuisc(Guid IdMuisc);

        //sent comment muisc by id
        Task<List<CommentMuiscClient_V>> SentCommentMuisc(CommentMuiscClient_V request);

        //get all rating by id muisc
        Task<List<RatingMusic_V>> GetAllRatingByIdMuisc(Guid IdMuisc);

        //sent rating muisc by id
        Task<SentRatingMusic_V> SentRatingMuisc(RatingMusic_V request);

        //get all rating by id music for viewer
        Task<List<ViewRatingsClient_V>> ViewRatingMuiscClient(Guid IdMuisc);

        //get total muisc create yesterday
        int TotalMuiscYesteray();
    }
}
