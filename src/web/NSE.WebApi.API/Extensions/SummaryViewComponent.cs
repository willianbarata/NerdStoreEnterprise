using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace NSE.WebApi.API.Extensions
{
    public class SummaryViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
