using Lab02_ex.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Principal;

namespace Lab02_ex.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            List<Category> categories = new List<Category>()
            {
                new Category
                {
                    Id = 1,
                    Name = "Áo cà sa mạ vàng 24k chất lượng cao",
                    Image = Url.Content("~/images/anh2.jfif"),
                    Price = 100,
                    SalePrice = 80,
                    CategoryId = 1,
                    Decription = "Mặc vào trông cực kì chói mắt",
                    Status = 1,
                    CreateAt = new DateTime(2000,4,5),
                },
                new Category
                {
                    Id = 2,
                    Name = "Giày trượt băng",
                    Image = Url.Content("~/images/anh4.jfif"),
                    Price = 400,
                    SalePrice = 320,
                    CategoryId = 2,
                    Decription = "Giày chất lượng cao không chống trượt",
                    Status = 0,
                    CreateAt = new DateTime(2000,4,5),
                },
                new Category
                {
                    Id = 3,
                    Name = "Áo cái bang nâng cao khí chất",
                    Image = Url.Content("~/images/anh1.jfif"),
                    Price = 999,
                    SalePrice = 1299,
                    CategoryId = 1,
                    Decription = "Áo có điểm nổi bật là không cần giặt",
                    Status = 0,
                    CreateAt = new DateTime(2000,4,5),
                },
                new Category
                {
                    Id = 4,
                    Name = "Long bào của vua Càn Long",
                    Image = Url.Content("~/images/anh3.jfif"),
                    Price = 769,
                    SalePrice = 129,
                    CategoryId = 1,
                    Decription = "Bộ long bào cổ có niên đại 1876 phút",
                    Status = 1,
                    CreateAt = new DateTime(2000,4,5),
                },
                new Category
                {
                    Id = 5,
                    Name = "Giày trượt patin",
                    Image = Url.Content("~/images/anh5.jfif"),
                    Price = 579,
                    SalePrice = 259,
                    CategoryId = 2,
                    Decription = "Giày trang bị động cơ lên tới 1.500 mã lực",
                    Status = 0,
                    CreateAt = new DateTime(2000,4,5),
                },
            };

            ViewBag.categories = categories;
            return View();
        }

        [Route("san-pham", Name = "filter-category")]
        public IActionResult FilterProduct(int id)
        {
            List<Category> categories = new List<Category>()
            {
                new Category
                {
                    Id = 1,
                    Name = "Áo cà sa mạ vàng 24k chất lượng cao",
                    Image = Url.Content("~/images/anh2.jfif"),
                    Price = 100,
                    SalePrice = 80,
                    CategoryId = 1,
                    Decription = "Mặc vào trông cực kì chói mắt",
                    Status = 1,
                    CreateAt = new DateTime(2000,4,5),
                },
                new Category
                {
                    Id = 2,
                    Name = "Giày trượt băng",
                    Image = Url.Content("~/images/anh4.jfif"),
                    Price = 400,
                    SalePrice = 320,
                    CategoryId = 2,
                    Decription = "Giày chất lượng cao không chống trượt",
                    Status = 0,
                    CreateAt = new DateTime(2000,4,5),
                },
                new Category
                {
                    Id = 3,
                    Name = "Áo cái bang nâng cao khí chất",
                    Image = Url.Content("~/images/anh1.jfif"),
                    Price = 999,
                    SalePrice = 1299,
                    CategoryId = 1,
                    Decription = "Áo có điểm nổi bật là không cần giặt",
                    Status = 0,
                    CreateAt = new DateTime(2000,4,5),
                },
                new Category
                {
                    Id = 4,
                    Name = "Long bào của vua Càn Long",
                    Image = Url.Content("~/images/anh3.jfif"),
                    Price = 769,
                    SalePrice = 129,
                    CategoryId = 1,
                    Decription = "Bộ long bào cổ có niên đại 1876 phút",
                    Status = 1,
                    CreateAt = new DateTime(2000,4,5),
                },
                new Category
                {
                    Id = 5,
                    Name = "Giày trượt patin",
                    Image = Url.Content("~/images/anh5.jfif"),
                    Price = 579,
                    SalePrice = 259,
                    CategoryId = 2,
                    Decription = "Giày trang bị động cơ lên tới 1.500 mã lực",
                    Status = 0,
                    CreateAt = new DateTime(2000,4,5),
                },
            };


            var category = categories.Where(x => x.CategoryId == id);
            ViewBag.categories = category;
            return View();
        }

        [Route("chi-tiet-san-pham", Name = "profile")]
        public IActionResult Profile(int id)
        {
            List<Category> categories = new List<Category>()
            {
                new Category
                {
                    Id = 1,
                    Name = "Áo cà sa mạ vàng 24k chất lượng cao",
                    Image = Url.Content("~/images/anh2.jfif"),
                    Price = 100,
                    SalePrice = 80,
                    CategoryId = 1,
                    Decription = "Mặc vào trông cực kì chói mắt",
                    Status = 1,
                    CreateAt = new DateTime(2000,4,5),
                },
                new Category
                {
                    Id = 2,
                    Name = "Giày trượt băng",
                    Image = Url.Content("~/images/anh4.jfif"),
                    Price = 400,
                    SalePrice = 320,
                    CategoryId = 2,
                    Decription = "Giày chất lượng cao không chống trượt",
                    Status = 0,
                    CreateAt = new DateTime(2000,4,5),
                },
                new Category
                {
                    Id = 3,
                    Name = "Áo cái bang nâng cao khí chất",
                    Image = Url.Content("~/images/anh1.jfif"),
                    Price = 999,
                    SalePrice = 1299,
                    CategoryId = 1,
                    Decription = "Áo có điểm nổi bật là không cần giặt",
                    Status = 0,
                    CreateAt = new DateTime(2000,4,5),
                },
                new Category
                {
                    Id = 4,
                    Name = "Long bào của vua Càn Long",
                    Image = Url.Content("~/images/anh3.jfif"),
                    Price = 769,
                    SalePrice = 129,
                    CategoryId = 1,
                    Decription = "Bộ long bào cổ có niên đại 1876 phút",
                    Status = 1,
                    CreateAt = new DateTime(2000,4,5),
                },
                new Category
                {
                    Id = 5,
                    Name = "Giày trượt patin",
                    Image = Url.Content("~/images/anh5.jfif"),
                    Price = 579,
                    SalePrice = 259,
                    CategoryId = 2,
                    Decription = "Giày trang bị động cơ lên tới 1.500 mã lực",
                    Status = 0,
                    CreateAt = new DateTime(2000,4,5),
                },
            };

            Category category = categories.FirstOrDefault(x => x.Id == id);
            ViewBag.categories = category;
            return View();
        }
    }
}
