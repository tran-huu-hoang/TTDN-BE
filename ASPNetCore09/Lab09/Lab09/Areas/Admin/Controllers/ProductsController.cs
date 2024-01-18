using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lab09.Models;
using X.PagedList;
using Newtonsoft.Json;
using NuGet.Packaging.Signing;

namespace Lab09.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductsController : BaseController
    {
        private readonly DevXuongMocContext _context;

        public ProductsController(DevXuongMocContext context)
        {
            _context = context;
        }

        // GET: Admin/Products
        public async Task<IActionResult> Index(string name, int page = 1)
        {
            //số bản ghi trên 1 trang
            int limit = 5;

            var account = await _context.Products.OrderBy(c => c.Id).ToPagedListAsync(page, limit);
            if (!String.IsNullOrEmpty(name))
            {
                account = await _context.Products.Where(c => c.Title.Contains(name)).OrderBy(c => c.Id).ToPagedListAsync(page, limit);
            }
            ViewBag.keyword = name;
            return View(account);
        }

        // GET: Admin/Products/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Admin/Products/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Cid,Code,Title,Description,Content,Image,MetaTitle,MetaKeyword,MetaDescription,Slug,PriceOld,PriceNew,Size,Views,Likes,Star,Home,Hot,CreatedDate,UpdatedDate,AdminCreated,AdminUpdated,Status,Isdelete")] Product product)
        {
            if (ModelState.IsValid)
            {
                var files = HttpContext.Request.Form.Files;
                if (files.Count() > 0 && files[0].Length > 0)
                {
                    var file = files[0];
                    var FileName = file.FileName;

                    var str = "";
                    if(product.Cid == 7)
                    {
                        str = "phong-khach";
                    }
                    if(product.Cid == 8)
                    {
                        str = "phong-ngu";
                    }
                    if (product.Cid == 10)
                    {
                        str = "phong-bep";
                    }
                    if (product.Cid == 11)
                    {
                        str = "phong-tam";
                    }
                    if (product.Cid == 12)
                    {
                        str = "tre-em";
                    }
                    if (product.Cid == 13)
                    {
                        str = "tre-em";
                    }
                    if (product.Cid == 14)
                    {
                        str = "cau-thang";
                    }
                    if (product.Cid == 15)
                    {
                        str = "do-trang-tri";
                    }

                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Images\\products\\" + str, FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(stream);
                        product.Image = "/Images/products/" + str + FileName;
                    }
                }

                product.CreatedDate = DateTime.Now;
                product.UpdatedDate = DateTime.Now;
                var admin = JsonConvert.DeserializeObject<AdminUser>(HttpContext.Session.GetString("AdminLogin"));
                product.AdminCreated = admin.Account;
                product.AdminUpdated = admin.Account;

                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Admin/Products/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Admin/Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Cid,Code,Title,Description,Content,Image,MetaTitle,MetaKeyword,MetaDescription,Slug,PriceOld,PriceNew,Size,Views,Likes,Star,Home,Hot,CreatedDate,UpdatedDate,AdminCreated,AdminUpdated,Status,Isdelete")] Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id))
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
            return View(product);
        }

        // GET: Admin/Products/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Admin/Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            if (_context.Products == null)
            {
                return Problem("Entity set 'DevXuongMocContext.Products'  is null.");
            }
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                _context.Products.Remove(product);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(long id)
        {
          return (_context.Products?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
