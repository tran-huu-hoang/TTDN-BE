using Lab09.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Text;

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

        public IActionResult Orders()
        {
            if(HttpContext.Session.GetString("Member") == null)
            {
                //return RedirectToAction("Index", "LoginCustomer");
                return Redirect("/logincustomer/index/?url=/cart/orders");
            }
            else
            {
                var dataMember = JsonConvert.DeserializeObject<Customer>(HttpContext.Session.GetString("Member"));
                ViewBag.Customer = dataMember;
                float total = 0;
                foreach (var item in carts)
                {
                    total += item.Quantity * item.Price;
                }
                ViewBag.Total = total;

                var dataPay = _context.PaymentMethods.ToList();
                ViewData["IdPayment"] = new SelectList(dataPay, "Id", "Name", 1);
            }
            return View(carts);
        }

        public async Task<IActionResult> OrderPay(IFormCollection form)
        {
            try
            {
                var order = new Order();
                order.NameReciver = form["NameReciver"];
                order.Email = form["Email"];
                order.Phone = form["Phone"];
                order.Address = form["Address"];
                order.Notes = form["Notes"];
                order.Idpayment = long.Parse(form["Idpayment"]);
                order.OrdersDate = DateTime.Now;

                var dataMember = JsonConvert.DeserializeObject<Customer>(HttpContext.Session.GetString("Member"));
                order.Idcustomer = dataMember.Id;

                decimal total = 0;
                foreach (var item in carts)
                {
                    total += item.Quantity * (decimal)item.Price;
                }
                order.TotalMoney = total;

                var strOrderId = "DH";

                string timestamp = DateTime.Now.ToString("yyyy-MM-dd.HH-mm-ss.fff");
                strOrderId += "." + timestamp;
                order.Idorders = strOrderId;

                _context.Add(order);
                await _context.SaveChangesAsync();

                var dataOrder = _context.Orders.OrderByDescending(x => x.Id).FirstOrDefault();

                foreach(var item in carts)
                {
                    Orderdetail od = new Orderdetail();
                    od.Idord = dataOrder.Id;
                    od.Idproduct = item.Id;
                    od.Qty = item.Quantity;
                    od.Price = (decimal)item.Price;
                    od.Total = (decimal)item.Total;
                    od.ReturnQty = 0;

                    _context.Add(od);
                    await _context.SaveChangesAsync();
                }
                HttpContext.Session.Remove("My-Cart");
            }
            catch(Exception ex)
            {
                throw;
            }
            return View();
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

        public IActionResult Add(long id)
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

        public IActionResult Remove(long id)
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

        public IActionResult Update(long id, int quantity)
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
