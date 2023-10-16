using handMadeShop.ViewModels.Utilities.Slides;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace handMadeShop.ApiIntegration
{
    public interface ISlideApiClient
    {
        Task<List<SlideVm>> GetAll();
    }
}