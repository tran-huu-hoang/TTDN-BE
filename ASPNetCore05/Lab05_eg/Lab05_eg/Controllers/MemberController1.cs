using Lab05_eg.Models.DataModel;
using Lab05_eg.Models.ModelViews;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab05_eg.Controllers
{
    public class MemberController1 : Controller
    {
        public static List<Member> _members = new List<Member>();
        // GET: MemberController1
        public ActionResult Index()
        {
            List<MemberView> list = new List<MemberView>();
            foreach(var item in _members)
            {
                var model = new MemberView()
                {
                    
                };
            }
            return View(list);
        }

        // GET: MemberController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MemberController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MemberController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MemberView member)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MemberController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MemberController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MemberController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MemberController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
