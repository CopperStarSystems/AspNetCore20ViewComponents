//  --------------------------------------------------------------------------------------
// AspNetCore.ViewComponents.ExternalComponents.ExternalViewComponent.cs
// 2018/02/25
//  --------------------------------------------------------------------------------------

using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.ViewComponents.ExternalComponents
{
    public class ExternalViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(object param)
        {
            return View(param);
        }
    }
}