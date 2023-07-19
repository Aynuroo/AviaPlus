using AviaPlus.DAL;
using AviaPlus.Models;
using AviaPlus.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using static AviaPlus.Helpers.Helper;

namespace AviaPlus.Controllers
{
    //[Authorize(Roles = "Admin,ConManager")]
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public async Task<IActionResult> GlobalSearch(string key)
        {
            GlobalSearchVM globalSearchVM = new GlobalSearchVM
            {
                Flights = await _db.Flights.Where(x => x.Departure.ToLower().Contains(key.ToLower())).OrderByDescending(x => x.Id).Take(3).ToListAsync(),
                Tickets = await _db.Tickets.Where(x => x.FullName.ToLower().Contains(key.ToLower())).OrderByDescending(x => x.Id).Take(3).ToListAsync(),
                Perfumeries = await _db.Perfumeries.Where(x => x.Name.ToLower().Contains(key.ToLower())).OrderByDescending(x => x.Id).Take(3).ToListAsync(),
                Cosmetics = await _db.Cosmetics.Where(x => x.Name.ToLower().Contains(key.ToLower())).OrderByDescending(x => x.Id).Take(3).ToListAsync(),
                Spirits = await _db.Spirits.Where(x => x.Name.ToLower().Contains(key.ToLower())).OrderByDescending(x => x.Id).Take(3).ToListAsync(),
                GourmetFoods = await _db.GourmetFoods.Where(x => x.Name.ToLower().Contains(key.ToLower())).OrderByDescending(x => x.Id).Take(3).ToListAsync(),
                Foods = await _db.Foods.Where(x => x.Name.ToLower().Contains(key.ToLower())).OrderByDescending(x => x.Id).Take(3).ToListAsync(),
                Beverages = await _db.Beverages.Where(x => x.Name.ToLower().Contains(key.ToLower())).OrderByDescending(x => x.Id).Take(3).ToListAsync(),
                Jewelries = await _db.Jewelries.Where(x => x.Name.ToLower().Contains(key.ToLower())).OrderByDescending(x => x.Id).Take(3).ToListAsync(),
                Clothes = await _db.Clothes.Where(x => x.Name.ToLower().Contains(key.ToLower())).OrderByDescending(x => x.Id).Take(3).ToListAsync(),
            };
            return PartialView("_GlobalSearchPartial", globalSearchVM);
        }
    }
}
