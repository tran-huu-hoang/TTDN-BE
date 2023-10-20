using Lab04.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace Lab04.Controllers
{
    public class PeopleController : Controller
    {
        // GET: PeopleController
        public ActionResult Index()
        {
            var peoples = DataLocal.GetPeoples();
            return View(peoples);
        }

        // GET: PeopleController/Details/5
        public ActionResult Details(int id)
        {
            var people = DataLocal.GetPeoplesById(id);
            return View(people);
        }

        // GET: PeopleController/Create
        public ActionResult Create()
        {
            People people = new People();
            return View(people);
        }

        // POST: PeopleController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(People model)
        {
            try
            {
                var files = HttpContext.Request.Form.Files;
                if(files.Count() > 0 && files[0].Length > 0)
                {
                    var file = files[0];
                    var FileName = file.FileName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(stream);
                        model.Avatar = "images/" + FileName;
                    }
                }

                DataLocal.peoples.Add(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PeopleController/Edit/5
        public ActionResult Edit(int id)
        {
            var people = DataLocal.GetPeoplesById(id);
            return View(people);
        }

        // POST: PeopleController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, People model)
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
                        model.Avatar = "images/" + FileName;
                    }
                }

                for(int i=0; i < DataLocal.peoples.Count; i++)
                {
                    if (DataLocal.peoples[i].Id == id)
                    {
                        DataLocal.peoples[i] = model;
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

        // GET: PeopleController/Delete/5
        public ActionResult Delete(int id)
        {
            var people = DataLocal.GetPeoplesById(id);
            return View(people);
        }

        // POST: PeopleController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, People model)
        {
            try
            {
                for(int i=0; i<DataLocal.peoples.Count; i++)
                {
                    if (DataLocal.peoples[i].Id == id)
                    {
                        DataLocal.peoples.RemoveAt(i);
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
