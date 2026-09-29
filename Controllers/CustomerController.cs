using Inventy_Demo_MVC_Core.models;
using Inventy_Demo_MVC_Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Inventy_Demo_MVC_Core.Controllers
{
    public class CustomerController : Controller
    {
        private ICustomerService customerService;
        public CustomerController(ICustomerService _customerService)
        {
            this.customerService = _customerService;
        }
        public async Task<IActionResult> Index()
        {
            List<TblCustomer> lst = await customerService.GetCustomers();
            ViewData["CustLst"] = lst;
            TblCustomer c = new TblCustomer();

            return View(c);
        }
        [HttpPost]
        public async Task<IActionResult> Index(TblCustomer cust)
        {
            await customerService.AddCustomer(cust);
            ModelState.Clear();
            List<TblCustomer> lst = await customerService.GetCustomers();
            ViewData["CustLst"] = lst;
            return View();
        }

        public async Task<JsonResult> GetCustomers()
        {
            List<TblCustomer> lst = await customerService.GetCustomers();
            return Json(lst);
        }
    }
}
