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
    public class CustomersController : BaseController
    {
        private readonly DevXuongMocContext _context;

        public CustomersController(DevXuongMocContext context)
        {
            _context = context;
        }

        // GET: Admin/Customers
        public async Task<IActionResult> Index(string name, int page = 1)
        {
            //số bản ghi trên 1 trang
            int limit = 5;

            var account = await _context.Customers.OrderBy(c => c.Id).ToPagedListAsync(page, limit);
            if (!String.IsNullOrEmpty(name))
            {
                account = await _context.Customers.Where(c => c.Name.Contains(name)).OrderBy(c => c.Id).ToPagedListAsync(page, limit);
            }
            ViewBag.keyword = name;
            return View(account);
        }

        // GET: Admin/Customers/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null || _context.Customers == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // GET: Admin/Customers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Username,Password,Address,Email,Phone,Avatar,CreatedDate,UpdateDate,CreatedBy,UpdateBy,Isdelete,Isactive")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                var files = HttpContext.Request.Form.Files;
                if (files.Count() > 0 && files[0].Length > 0)
                {
                    var file = files[0];
                    var FileName = file.FileName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Images", FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(stream);
                        customer.Avatar = "/Images/" + FileName;
                    }
                }

                customer.CreatedDate = DateTime.Now;
                customer.UpdateDate = DateTime.Now;
                var admin = JsonConvert.DeserializeObject<AdminUser>(HttpContext.Session.GetString("AdminLogin"));
                customer.CreatedBy = admin.Id;
                customer.UpdateBy = admin.Id;

                _context.Add(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        // GET: Admin/Customers/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null || _context.Customers == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        // POST: Admin/Customers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Name,Username,Password,Address,Email,Phone,Avatar,CreatedDate,UpdateDate,CreatedBy,UpdateBy,Isdelete,Isactive")] Customer customer)
        {
            if (id != customer.Id)
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
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Images", FileName);
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            file.CopyTo(stream);
                            customer.Avatar = "/Images/" + FileName;
                        }
                    }

                    customer.UpdateDate = DateTime.Now;
                    var admin = JsonConvert.DeserializeObject<AdminUser>(HttpContext.Session.GetString("AdminLogin"));
                    customer.UpdateBy = admin.Id;

                    _context.Update(customer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customer.Id))
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
            return View(customer);
        }

        // GET: Admin/Customers/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            //if (id == null || _context.Customers == null)
            //{
            //    return NotFound();
            //}

            //var customer = await _context.Customers
            //    .FirstOrDefaultAsync(m => m.Id == id);
            //if (customer == null)
            //{
            //    return NotFound();
            //}

            //return View(customer);

            if (_context.Customers == null)
            {
                return Problem("Entity set 'DevXuongMocContext.Customers'  is null.");
            }
            var customer = await _context.Customers.FindAsync(id);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // POST: Admin/Customers/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(long id)
        //{
        //    if (_context.Customers == null)
        //    {
        //        return Problem("Entity set 'DevXuongMocContext.Customers'  is null.");
        //    }
        //    var customer = await _context.Customers.FindAsync(id);
        //    if (customer != null)
        //    {
        //        _context.Customers.Remove(customer);
        //    }
            
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool CustomerExists(long id)
        {
          return (_context.Customers?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
