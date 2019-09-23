//  --------------------------------------------------------------------------------------
// AspNetCore.ViewComponents.Mvc.LocalViewComponent.cs
// 2018/02/25
//  --------------------------------------------------------------------------------------

using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.ViewComponents.Mvc.ViewComponents
{
    public class LocalViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(object param)
        {
            return await Task.FromResult(View(param));
        }
    }
}