using DataService.ServiceUser.MusicClient;
using DataViewModel.ViewModelUser.Muisc_Vm;
using DataViewModel.ViewModelUser.RatingClient_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.ApplicationUser.ApplicationHome.MusicClient
{
    public class MusicClient_App : ImusicClient_App
    {
        private readonly ImusicClient context;
        public MusicClient_App(ImusicClient _context)
        {
            context = _context;
        }

        //detaio muisc client
        public async Task<DetailMuiscClient_V> DetailMuiscClient(Guid IdMuisc)
        {
            var result = await context.DetailMuisc(IdMuisc);
            return result;
        }

        //view display pdf new tap
        public async Task<byte[]> DisplayPDF(Guid IdMuisc)
        {
            var result = await context.DisplayPDF(IdMuisc);
            return result;
        }

        //dowload muisc with pdf file
        public async Task<DowloadMusicPDFfile_V> DowloadMusicPDFfile(Guid IdMuisc, Guid IdUser)
        {
            var result = await context.DowloadMuiscPDFfile(IdMuisc, IdUser);
            return result;
        }

        //get music client
        public async Task<List<MusicGetAll_V>> GetMusicClient(Guid IdUser)
        {
            var result = await context.GetMusicClient(IdUser);
            return result;
        }

        //plus like muisc by id user
        public async Task<PlusLikeMuisc_V> PlusLikeMuiscIdUser(Guid IdMuisc, Guid IdUser)
        {
            var result = await context.PlusMuiscByIdUser(IdUser, IdMuisc);
            return result;
        }

        //get all comment by id muisc
        public async Task<List<CommentMuiscClient_V>> GetCommentMuiscByIdMuisc(Guid IdMuisc)
        {
            var result = await context.GetAllCommentByIdMuisc(IdMuisc);
            return result;
        }

        //sent comment muisc by id user
        public async Task<List<CommentMuiscClient_V>> SentCommentMuisc(CommentMuiscClient_V request)
        {
            var result = await context.SentCommentMuisc(request);
            return result;
        }

        //get all rating by id muisc
        public async Task<List<RatingMusic_V>> GetRatingMuiscByIdMuisc(Guid IdMuisc)
        {
            var result = await context.GetAllRatingByIdMuisc(IdMuisc);
            return result;
        }

        //sent rating by id muisc
        public async Task<SentRatingMusic_V> SentRatingMuisc(RatingMusic_V request)
        {
            var result = await context.SentRatingMuisc(request);
            return result;
        }

        //view all rating muisc by id muisc
        public async Task<List<ViewRatingsClient_V>> ViewRatingMuiscById(Guid IdMuisc)
        {
            var result = await context.ViewRatingMuiscClient(IdMuisc);
            return result;
        }

        //total muisc create yesterday
        public int TotalMuiscYesterday()
        {
            var resutl = context.TotalMuiscYesteray();
            return resutl;
        }
    }
}
