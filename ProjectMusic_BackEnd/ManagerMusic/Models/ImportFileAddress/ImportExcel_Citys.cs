using Microsoft.AspNetCore.Http;

namespace ManagerMusic.Models.ImportFileAddress
{
    public class ImportExcel_Citys
    {
        public IFormFile FileExcel { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}
