using Microsoft.AspNetCore.Mvc;

namespace Inventy_Demo_MVC_Core.Controllers
{
    public class InvoiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
