using Lab09.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;

namespace Lab09.Controllers
{
    public class CartController : Controller
    {
        private readonly DevXuongMocContext _context;
        private List<Cart> carts = new List<Cart>();

        public CartController(DevXuongMocContext context)
        {
            _context = context;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var cartInSession = HttpContext.Session.GetString("My-Cart");
            if (cartInSession != null)
            {
                carts = JsonConvert.DeserializeObject<List<Cart>>(cartInSession);
            }

            base.OnActionExecuting(context);
        }

        public IActionResult Index()
        {
            float total = 0;
            foreach (var item in carts)
            {
                total += item.Quantity * item.Price;
            }
            ViewBag.Total = total;

            return View(carts);
        }

        public IActionResult Add(int id)
        {
            if(carts.Any(c => c.Id == id))
            {
                carts.Where(c => c.Id == id).First().Quantity += 1;
            }
            else
            {
                var p = _context.Products.Find(id);

                var item = new Cart()
                {
                    Id = p.Id,
                    Name = p.Title,
                    Price = (float)p.PriceNew.Value,
                    Quantity = 1,
                    Image = p.Image,
                    Total = (float)p.PriceNew.Value * 1,
                };
                carts.Add(item);
            }
            HttpContext.Session.SetString("My-Cart", JsonConvert.SerializeObject(carts));
            return RedirectToAction("Index");
        }

        public IActionResult Remove(int id)
        {
            if (carts.Any(c => c.Id == id))
            {
                //tìm sản phẩm trong giỏ hàng
                var item = carts.Where(c => c.Id == id).First();
                //xóa
                carts.Remove(item);
                //lưu vào session
                HttpContext.Session.SetString("My-Cart", JsonConvert.SerializeObject(carts));
            }

            return RedirectToAction("Index");
        }

        public IActionResult Update(int id, int quantity)
        {
            if(carts.Any(c => c.Id == id))
            {
                carts.Where(c => c.Id == id).First().Quantity = quantity;
                HttpContext.Session.SetString("My-Cart", JsonConvert.SerializeObject(carts));
            }
            return RedirectToAction("Index");
        }

        public IActionResult Clear()
        {
            HttpContext.Session.Remove("My-Cart");
            return RedirectToAction("Index");
        }
    }
}
