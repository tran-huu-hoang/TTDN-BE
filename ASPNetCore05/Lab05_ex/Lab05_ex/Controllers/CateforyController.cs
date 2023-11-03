using Lab05_ex.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab05_ex.Controllers
{
    public class CateforyController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            var categories = DataLocal.GetCategory();
            return View(categories);
        }

        // GET: Category/Details/5
        public ActionResult Details(int id)
        {
            var categories = DataLocal.categories.FirstOrDefault(c => c.Id == id);
            return View(categories);
        }

        // GET: Category/Create
        public ActionResult Create()
        {
            Category category = new Category();
            var Id = DataLocal.categories.Max(x => x.Id);
            ViewBag.Id = Id + 1;
            return View();
        }

        // POST: Category/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category item)
        {
            try
            {
                item.CreateDate = DateTime.Now;
                item.CreateBy = "Hoàng";

                DataLocal.categories.Add(item);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Category/Edit/5
        public ActionResult Edit(int id)
        {
            var categories = DataLocal.categories.FirstOrDefault(x => x.Id == id);
            return View(categories);
        }

        // POST: Category/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Category item)
        {
            try
            {
                for (int i = 0; i < DataLocal.categories.Count; i++)
                {
                    if (DataLocal.categories[i].Id == id)
                    {
                        DataLocal.categories[i] = item;
                        break;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Category/Delete/5
        public ActionResult Delete(int id)
        {
            var categories = DataLocal.categories.FirstOrDefault(x => x.Id == id);
            return View(categories);
        }

        // POST: Category/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Category item)
        {
            try
            {
                for (int i = 0; i < DataLocal.categories.Count; i++)
                {
                    if (DataLocal.categories[i].Id == id)
                    {
                        DataLocal.categories.Remove(DataLocal.categories[i]);
                        break;
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
