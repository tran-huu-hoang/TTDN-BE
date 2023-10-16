using Lab03_ex.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab03_ex.ViewComponents
{
    public class ProductViewComponent : ViewComponent
    {
        protected Product product = new Product();

        public IViewComponentResult Invoke()
        {
            var products = product.GetProductList();
            return View(products);
        }
    }
}
