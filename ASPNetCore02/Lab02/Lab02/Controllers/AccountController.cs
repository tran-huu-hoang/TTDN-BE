using Lab02.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab02.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            List<Account> accounts = new List<Account>()
            {
                new Account()
                {
                    Id = 1,
                    Name = "Hoang",
                    Email = "hoang@gmail.com",
                    Phone = "0123345456",
                    Address = "Ha Noi",
                    Avatar = Url.Content("~/avatar/avatar1.jfif"),
                    Gender = 1,
                    Bio = "I am vip",
                    Birthday = new DateTime(2003,7,14),
                },
                new Account()
                {
                    Id = 2,
                    Name = "Hoang",
                    Email = "hoang@gmail.com",
                    Phone = "0123345456",
                    Address = "Ha Noi",
                    Avatar = Url.Content("~/avatar/avatar1.jfif"),
                    Gender = 1,
                    Bio = "I am pro",
                    Birthday = new DateTime(2003,7,14),
                },
                new Account()
                {
                    Id = 3,
                    Name = "Hoang",
                    Email = "hoang@gmail.com",
                    Phone = "0123345456",
                    Address = "Ha Noi",
                    Avatar = Url.Content("~/avatar/avatar1.jfif"),
                    Gender = 1,
                    Bio = "I am noob",
                    Birthday = new DateTime(2003,7,14),
                },
                new Account()
                {
                    Id = 4,
                    Name = "Hoang",
                    Email = "hoang@gmail.com",
                    Phone = "0123345456",
                    Address = "Ha Noi",
                    Avatar = Url.Content("~/avatar/avatar1.jfif"),
                    Gender = 1,
                    Bio = "I am ...",
                    Birthday = new DateTime(2003,7,14),
                },
            };

            ViewBag.accounts = accounts;
            return View();
        }

        [Route("my-profile", Name = "profile")]
        public IActionResult Profile(int id)
        {
            List<Account> accounts = new List<Account>()
            {
                new Account()
                {
                    Id = 1,
                    Name = "Hoang",
                    Email = "hoang@gmail.com",
                    Phone = "0123345456",
                    Address = "Ha Noi",
                    Avatar = Url.Content("~/avatar/avatar1.jfif"),
                    Gender = 1,
                    Bio = "I am vip",
                    Birthday = new DateTime(2003,7,14),
                },
                new Account()
                {
                    Id = 2,
                    Name = "Hoang",
                    Email = "hoang@gmail.com",
                    Phone = "0123345456",
                    Address = "Ha Noi",
                    Avatar = Url.Content("~/avatar/avatar1.jfif"),
                    Gender = 1,
                    Bio = "I am pro",
                    Birthday = new DateTime(2003,7,14),
                },
                new Account()
                {
                    Id = 3,
                    Name = "Hoang",
                    Email = "hoang@gmail.com",
                    Phone = "0123345456",
                    Address = "Ha Noi",
                    Avatar = Url.Content("~/avatar/avatar1.jfif"),
                    Gender = 1,
                    Bio = "I am noob",
                    Birthday = new DateTime(2003,7,14),
                },
                new Account()
                {
                    Id = 4,
                    Name = "Hoang",
                    Email = "hoang@gmail.com",
                    Phone = "0123345456",
                    Address = "Ha Noi",
                    Avatar = Url.Content("~/avatar/avatar1.jfif"),
                    Gender = 1,
                    Bio = "I am ...",
                    Birthday = new DateTime(2003,7,14),
                },
            };

            Account account = accounts.FirstOrDefault(x => x.Id == id);

            ViewBag.account = account;
            return View();
        }
    }
}
