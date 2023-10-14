using handMadeShop.ViewModels.Common;
using handMadeShop.ViewModels.System.Languages;
using handMadeShop.ViewModels.System.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace handMadeShop.Application.System.Languages
{
    public interface ILanguageService
    {
        Task<ApiResult<List<LanguageVm>>> GetAll();
    }
}