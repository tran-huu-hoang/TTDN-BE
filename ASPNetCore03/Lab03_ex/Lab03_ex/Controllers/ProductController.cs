using Lab03_ex.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab03_ex.Controllers
{
    public class ProductController : Controller
    {
        protected Product product = new Product();

        public IActionResult Index()
        {
            var products = product.GetProductList();
            return View(products);
        }

        public PartialViewResult Menu()
        {
            var products = product.GetProductList();
            return PartialView(products);
        }
    }
}
