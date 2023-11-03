using Lab05_ex.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lab05_ex.Controllers
{
    public class ProductController : Controller
    {
        // GET: ProductController
        public ActionResult Index()
        {
            var products = DataLocal.GetProducts();
            return View(products);
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            var product = DataLocal.GetProductById(id);
            return View(product);
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            ViewBag.Categories = DataLocal.GetCategory();
            var Id = DataLocal.products.Max(x => x.Id);
            ViewBag.Id = Id + 1;

            //tạo dữ liệu cho combobox
            ViewBag.Categories = new SelectList(DataLocal.categories, "Id", "Name", 1);

            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product model)
        {
            try
            {
                model.CreateDate = DateTime.Now;

                var files = HttpContext.Request.Form.Files;
                if (files.Count() > 0 && files[0].Length > 0)
                {
                    var file = files[0];
                    var FileName = file.FileName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(stream);
                        model.Image = "images/" + FileName;
                    }
                }

                DataLocal.products.Add(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            var product = DataLocal.GetProductById(id);
            ViewBag.Categories = DataLocal.GetCategory();

            //tạo dữ liệu cho combobox
            ViewBag.Categories = new SelectList(DataLocal.categories, "Id", "Name", product.CategoryId);

            return View(product);
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Product model)
        {
            try
            {
                var files = HttpContext.Request.Form.Files;
                if (files.Count() > 0 && files[0].Length > 0)
                {
                    var file = files[0];
                    var FileName = file.FileName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(stream);
                        model.Image = "images/" + FileName;
                    }
                }

                for (int i = 0; i < DataLocal.products.Count; i++)
                {
                    if (DataLocal.products[i].Id == id)
                    {
                        DataLocal.products[i] = model;
                    }
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            var product = DataLocal.GetProductById(id);
            return View(product);
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                for (int i = 0; i < DataLocal.products.Count; i++)
                {
                    if (DataLocal.products[i].Id == id)
                    {
                        DataLocal.products.RemoveAt(i);
                    }
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
