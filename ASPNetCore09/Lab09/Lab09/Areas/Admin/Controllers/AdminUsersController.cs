using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lab09.Models;
using X.PagedList;

namespace Lab09.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminUsersController : Controller
    {
        private readonly DevXuongMocContext _context;

        public AdminUsersController(DevXuongMocContext context)
        {
            _context = context;
        }

        // GET: Admin/AdminUsers
        public async Task<IActionResult> Index(string name, int page = 1)
        {
            //số bản ghi trên 1 trang
            int limit = 5;

            var account = await _context.AdminUsers.OrderBy(c => c.Id).ToPagedListAsync(page, limit);
            if (!String.IsNullOrEmpty(name))
            {
                account = await _context.AdminUsers.Where(c => c.Account.Contains(name)).OrderBy(c => c.Id).ToPagedListAsync(page, limit);
            }
            ViewBag.keyword = name;
            return View(account);
        }

        // GET: Admin/AdminUsers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.AdminUsers == null)
            {
                return NotFound();
            }

            var adminUser = await _context.AdminUsers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (adminUser == null)
            {
                return NotFound();
            }

            return View(adminUser);
        }

        // GET: Admin/AdminUsers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/AdminUsers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Account,Password,MaNhanSu,Name,Phone,Email,Avatar,IdPhongBan,NgayTao,NguoiTao,NgayCapNhat,NguoiCapNhat,SessionToken,Salt,IsAdmin,TrangThai,IsDelete")] AdminUser adminUser)
        {
            if (ModelState.IsValid)
            {
                adminUser.NgayTao = DateTime.Now;
                adminUser.NgayCapNhat = DateTime.Now;

                _context.Add(adminUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(adminUser);
        }

        // GET: Admin/AdminUsers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.AdminUsers == null)
            {
                return NotFound();
            }

            var adminUser = await _context.AdminUsers.FindAsync(id);
            if (adminUser == null)
            {
                return NotFound();
            }
            return View(adminUser);
        }

        // POST: Admin/AdminUsers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Account,Password,MaNhanSu,Name,Phone,Email,Avatar,IdPhongBan,NgayTao,NguoiTao,NgayCapNhat,NguoiCapNhat,SessionToken,Salt,IsAdmin,TrangThai,IsDelete")] AdminUser adminUser)
        {
            if (id != adminUser.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    adminUser.NgayCapNhat = DateTime.Now;

                    _context.Update(adminUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdminUserExists(adminUser.Id))
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
            return View(adminUser);
        }

        // GET: Admin/AdminUsers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            //if (id == null || _context.AdminUsers == null)
            //{
            //    return NotFound();
            //}

            //var adminUser = await _context.AdminUsers
            //    .FirstOrDefaultAsync(m => m.Id == id);
            //if (adminUser == null)
            //{
            //    return NotFound();
            //}

            //return View(adminUser);

            if (_context.AdminUsers == null)
            {
                return Problem("Entity set 'DevXuongMocContext.AdminUsers'  is null.");
            }
            var adminUser = await _context.AdminUsers.FindAsync(id);
            if (adminUser != null)
            {
                _context.AdminUsers.Remove(adminUser);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // POST: Admin/AdminUsers/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    if (_context.AdminUsers == null)
        //    {
        //        return Problem("Entity set 'DevXuongMocContext.AdminUsers'  is null.");
        //    }
        //    var adminUser = await _context.AdminUsers.FindAsync(id);
        //    if (adminUser != null)
        //    {
        //        _context.AdminUsers.Remove(adminUser);
        //    }
            
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool AdminUserExists(int id)
        {
          return (_context.AdminUsers?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
