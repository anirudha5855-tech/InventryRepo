using Microsoft.AspNetCore.Mvc;

namespace Inventy_Demo_MVC_Core.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
