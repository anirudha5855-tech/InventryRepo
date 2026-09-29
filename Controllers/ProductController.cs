using Inventy_Demo_MVC_Core.models;
using Inventy_Demo_MVC_Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Inventy_Demo_MVC_Core.Controllers
{
    public class ProductController : Controller
    {
        IProductService productService;

        public ProductController(IProductService _productService)
        {
            this.productService = _productService;
        }
        public async Task<IActionResult> Index()
        {
            
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> Index([FromBody]TblProduct product)
        {
            await productService.AddProduct(product);
                   
            return Json(product);
        }

        public async Task<JsonResult> GetProducts()
        {
           List<TblProduct> lst= await productService.GetProducts();
            return Json(lst);
        }
    }
}
