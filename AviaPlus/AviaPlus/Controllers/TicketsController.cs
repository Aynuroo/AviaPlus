using AviaPlus.DAL;
using AviaPlus.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AviaPlus.Controllers
{
    public class TicketsController : Controller
    {
        private readonly AppDbContext _db;
        public TicketsController(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            List<Ticket> tickets = await  _db.Tickets.ToListAsync();
            return View(tickets);
        }
    }
}
