using AviaPlus.DAL;
using AviaPlus.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AviaPlus.Controllers
{
    public class PerfumeriesController : Controller
    {
        private readonly AppDbContext _db;
        public PerfumeriesController(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            List<Perfumery> perfumeries = await _db.Perfumeries.ToListAsync();
            return View(perfumeries);
        }
    }
}
