using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Turbo.Data;
using Turbo.Models;
using Turbo.ViewModels;

namespace Turbo.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Advert> adverts = await _context.Adverts.Where(m=>!m.IsDeleted)
                .Include(m => m.Body).Where(m => !m.IsDeleted)
                .Include(m => m.Brand).Where(m => !m.IsDeleted)
                .Include(m => m.City).Where(m => !m.IsDeleted)
                .Include(m => m.Color).Where(m => !m.IsDeleted)
                .Include(m => m.Engine).Where(m => !m.IsDeleted)
                .Include(m => m.Fuel).Where(m => !m.IsDeleted)
                .Include(m => m.Gear).Where(m => !m.IsDeleted)
                .Include(m => m.Model).Where(m => !m.IsDeleted)
                .Include(m => m.Year).ToListAsync();


            HomeVM homeVM = new HomeVM
            {

            };

            return View(adverts);
        }


    }
}
