using Microsoft.AspNetCore.Mvc;

namespace Lab01_ex.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
