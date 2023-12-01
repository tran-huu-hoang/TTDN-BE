using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lab09.Models;

namespace Lab09.Controllers
{
    public class RegisterController : Controller
    {
        private readonly DevXuongMocContext _context;

        public RegisterController(DevXuongMocContext context)
        {
            _context = context;
        }

        // GET: Register
        public async Task<IActionResult> Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index([Bind("Id,Name,Username,Password,Email")] Customer customer)
        {
            try
            {
                _context.Add(customer);
                await _context.SaveChangesAsync();
                return View("RegisterSuccess");
            }
            catch
            {
                return View();
            }
        }
    }
}
