using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lab09.Models;
using Newtonsoft.Json;
using X.PagedList;

namespace Lab09.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ExtensionsController : Controller
    {
        private readonly DevXuongMocContext _context;

        public ExtensionsController(DevXuongMocContext context)
        {
            _context = context;
        }

        // GET: Admin/Extensions
        public async Task<IActionResult> Index(string name, int page = 1)
        {
            //số bản ghi trên 1 trang
            int limit = 5;

            var account = await _context.Extensions.OrderBy(c => c.Id).ToPagedListAsync(page, limit);
            if (!String.IsNullOrEmpty(name))
            {
                account = await _context.Extensions.Where(c => c.Title.Contains(name)).OrderBy(c => c.Id).ToPagedListAsync(page, limit);
            }
            ViewBag.keyword = name;
            return View(account);
        }

        // GET: Admin/Extensions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Extensions == null)
            {
                return NotFound();
            }

            var extension = await _context.Extensions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (extension == null)
            {
                return NotFound();
            }

            return View(extension);
        }

        // GET: Admin/Extensions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Extensions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Icon,MetaTitle,MetaKeyword,MetaDescription,Slug,Orders,Parentid,CreatedDate,UpdatedDate,AdminCreated,AdminUpdated,Notes,Status,Isdelete")] Extension extension)
        {
            if (ModelState.IsValid)
            {
                var files = HttpContext.Request.Form.Files;
                if (files.Count() > 0 && files[0].Length > 0)
                {
                    var file = files[0];
                    var FileName = file.FileName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Content\\Uploads\\images\\extension", FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(stream);
                        extension.Icon = "/Content/Uploads/images/extension/" + FileName;
                    }
                }

                extension.CreatedDate = DateTime.Now;
                extension.UpdatedDate = DateTime.Now;
                var admin = JsonConvert.DeserializeObject<AdminUser>(HttpContext.Session.GetString("AdminLogin"));
                extension.AdminCreated = admin.Account;
                extension.AdminUpdated = admin.Account;

                _context.Add(extension);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(extension);
        }

        // GET: Admin/Extensions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Extensions == null)
            {
                return NotFound();
            }

            var extension = await _context.Extensions.FindAsync(id);
            if (extension == null)
            {
                return NotFound();
            }
            return View(extension);
        }

        // POST: Admin/Extensions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Icon,MetaTitle,MetaKeyword,MetaDescription,Slug,Orders,Parentid,CreatedDate,UpdatedDate,AdminCreated,AdminUpdated,Notes,Status,Isdelete")] Extension extension)
        {
            if (id != extension.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var files = HttpContext.Request.Form.Files;
                    if (files.Count() > 0 && files[0].Length > 0)
                    {
                        var file = files[0];
                        var FileName = file.FileName;
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Content\\Uploads\\images\\extension", FileName);
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            file.CopyTo(stream);
                            extension.Icon = "/Content/Uploads/images/extension/" + FileName;
                        }
                    }

                    extension.UpdatedDate = DateTime.Now;
                    var admin = JsonConvert.DeserializeObject<AdminUser>(HttpContext.Session.GetString("AdminLogin"));
                    extension.AdminUpdated = admin.Account;

                    _context.Update(extension);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExtensionExists(extension.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(extension);
        }

        // GET: Admin/Extensions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            //if (id == null || _context.Extensions == null)
            //{
            //    return NotFound();
            //}

            //var extension = await _context.Extensions
            //    .FirstOrDefaultAsync(m => m.Id == id);
            //if (extension == null)
            //{
            //    return NotFound();
            //}

            //return View(extension);

            if (_context.Extensions == null)
            {
                return Problem("Entity set 'DevXuongMocContext.Extensions'  is null.");
            }
            var extension = await _context.Extensions.FindAsync(id);
            if (extension != null)
            {
                _context.Extensions.Remove(extension);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // POST: Admin/Extensions/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    if (_context.Extensions == null)
        //    {
        //        return Problem("Entity set 'DevXuongMocContext.Extensions'  is null.");
        //    }
        //    var extension = await _context.Extensions.FindAsync(id);
        //    if (extension != null)
        //    {
        //        _context.Extensions.Remove(extension);
        //    }
            
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool ExtensionExists(int id)
        {
          return (_context.Extensions?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
