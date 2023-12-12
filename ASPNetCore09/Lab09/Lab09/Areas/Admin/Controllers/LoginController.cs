using Lab09.Areas.Admin.Models;
using Lab09.Models;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;
using System.Security.Cryptography;
using System.Text;

namespace Lab09.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        private readonly DevXuongMocContext _context;
        public LoginController(DevXuongMocContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Login model) {
            if(!ModelState.IsValid)
            {
                return View(model); //trả về trạng thái lỗi
            }

            //xử lý logic đăng nhập tại đây
            var pass = GetSHA26Hash(model.Password);
            var dataLogin = _context.AdminUsers.Where(x => x.Email.Equals(model.Email) && x.Password.Equals(pass)).FirstOrDefault();
            var data = dataLogin.ToJson();
            if (dataLogin != null)
            {
                //lưu session khi đăng nhập thành công
                HttpContext.Session.SetString("AdminLogin", data);

                return RedirectToAction("Index", "Dashboard");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("AdminLogin");
            return RedirectToAction("Index");
        }

        static string GetSHA26Hash(string input)
        {
            string hash = "";
            using(var sha256 = new SHA256Managed())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                hash = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
            return hash;
        }
    }
}
