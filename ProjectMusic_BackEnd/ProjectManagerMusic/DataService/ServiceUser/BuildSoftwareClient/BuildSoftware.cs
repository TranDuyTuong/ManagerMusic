using DataMigration.DataEF;
using DataTable.Table.RequestUser;
using DataViewModel.ViewModelUser.BuildSoftware_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.ServiceUser.BuildSoftwareClient
{
    public class BuildSoftware : IbuildSoftware
    {
        private readonly ContextDB context;
        public BuildSoftware(ContextDB _context)
        {
            context = _context;
        }

        //sent contribute client user 
        public async Task<NotificationSentContribute_V> SentContributeUser(SentContributeUser_V request)
        {
            var result = new NotificationSentContribute_V();
            var GetData = new T_RequestUser()
            {
                IdUser = request.IdUser,
                TitleRequest = "Đánh giá xây dựng ứng dung " + request.DateCreate.ToString("dd/MM/yyyy"),
                ContentRequest = request.Content,
                DateRequest = request.DateCreate,
                IdReceiveRequest = 1
            };
            await context.T_RequestUsers.AddAsync(GetData);
            await context.SaveChangesAsync();
            result.IdStatus = 1;
            result.Status = true;
            return result;
        }


    }
}
