using Lab09.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Security.Cryptography;
using NuGet.Protocol;

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
        public IActionResult Index(string url)
        {
            ViewBag.UrlAction = url;
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginCustomer model, string urlAction)
        {

            //xử lý logic đăng nhập tại đây
            //var pass = GetSHA26Hash(model.Password);
            var dataLogin = _context.Customers.Where(x => x.Username.Equals(model.UserName) && x.Password.Equals(model.Password)).FirstOrDefault();
            var data = dataLogin.ToJson();
            if (data != null)
            {
                //lưu session khi đăng nhập thành công
                HttpContext.Session.SetString("Member", data);

                if(!string.IsNullOrEmpty(urlAction))
                {
                    return Redirect(urlAction);
                }
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("Member");
            return RedirectToAction("Index", "Product");
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
