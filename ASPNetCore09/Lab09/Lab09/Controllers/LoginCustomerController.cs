using Lab09.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Security.Cryptography;

namespace Lab09.Controllers
{
    public class LoginCustomerController : Controller
    {
        private readonly DevXuongMocContext _context;
        public LoginCustomerController(DevXuongMocContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginCustomer model)
        {
            if (!ModelState.IsValid)
            {
                return View(model); //trả về trạng thái lỗi
            }

            //xử lý logic đăng nhập tại đây
            //var pass = GetSHA26Hash(model.Password);
            var dataLogin = _context.Customers.Where(x => x.Username.Equals(model.UserName) && x.Password.Equals(model.Password)).FirstOrDefault();
            if (dataLogin != null)
            {
                //lưu session khi đăng nhập thành công
                HttpContext.Session.SetString("AdminLogin", model.UserName);

                return RedirectToAction("Index", "Product");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("AdminLogin");
            return RedirectToAction("Index");
        }

        //static string GetSHA26Hash(string input)
        //{
        //    string hash = "";
        //    using (var sha256 = new SHA256Managed())
        //    {
        //        var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
        //        hash = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
        //    }
        //    return hash;
        //}
    }
}
