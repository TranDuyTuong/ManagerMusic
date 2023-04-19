using DataViewModel.ViewModelAdmin.Address_Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.ApplicationAdmin.ApplicationAddress.Address_App
{
    public interface IaddressApplication
    {
        /// <summary>
        /// GetAllCitys
        /// </summary>
        PadingCity_Vm GetAllCitys(int pageIndex, int pageSize, int orderBy, string seach);
    }
}
