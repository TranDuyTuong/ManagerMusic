using DataViewModel.ViewModelUser.Muisc_Vm;
using DataViewModel.ViewModelUser.RatingClient_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.ApplicationUser.ApplicationHome.MusicClient
{
    public interface ImusicClient_App
    {
        //get all muisc client
        Task<List<MusicGetAll_V>> GetMusicClient(Guid IdUser);

        //plus like music by id user
        Task<PlusLikeMuisc_V> PlusLikeMuiscIdUser(Guid IdMuisc, Guid IdUser);

        //detail music client
        Task<DetailMuiscClient_V> DetailMuiscClient(Guid IdMuisc);

        //view display pdf with new tap
        Task<byte[]> DisplayPDF(Guid IdMuisc);

        //dowload muisic file pdf
        Task<DowloadMusicPDFfile_V> DowloadMusicPDFfile(Guid IdMuisc, Guid IdUser);

        //get all comment by id music
        Task<List<CommentMuiscClient_V>> GetCommentMuiscByIdMuisc(Guid IdMuisc);

        //sent comment muisc by id user
        Task<List<CommentMuiscClient_V>> SentCommentMuisc(CommentMuiscClient_V request);

        //get all rating by id muisc
        Task<List<RatingMusic_V>> GetRatingMuiscByIdMuisc(Guid IdMuisc);

        //sent rating muisc by id user
        Task<SentRatingMusic_V> SentRatingMuisc(RatingMusic_V request);

        //get all rating for viewer by id music
        Task<List<ViewRatingsClient_V>> ViewRatingMuiscById(Guid IdMuisc);

        //total muisc create yesterday
        int TotalMuiscYesterday();
    }
}
