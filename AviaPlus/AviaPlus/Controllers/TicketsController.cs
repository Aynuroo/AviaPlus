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
            List<Ticket> tickets = await _db.Tickets.ToListAsync();
            return View(tickets);
        }

        //#region Create

        //#region Get
        //public IActionResult Create()
        //{
        //    return View();
        //}
        //#endregion

        //#region Post

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create(Ticket ticket)
        //{
        //    bool isExist = await _db.Tickets.AnyAsync(t => t.SeatNumber == ticket.SeatNumber);
        //    if (isExist)
        //    {
        //        ModelState.AddModelError("SeatNumber", "This seat number is already exist!");
        //        return View();
        //    }
        //    await _db.Tickets.AddAsync(ticket);
        //    await _db.SaveChangesAsync();
        //    return RedirectToAction("Index");
        //}
        //#endregion

        //#endregion

        #region Detail

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Ticket ticket = await _db.Tickets.FirstOrDefaultAsync(t => t.Id == id);
            if (ticket == null)
            {
                return BadRequest();
            }
            return View(ticket);
        }

        #endregion

        #region Update

        #region Get

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Ticket dbTicket = await _db.Tickets.FirstOrDefaultAsync(t => t.Id == id);
            if (dbTicket == null)
            {
                return BadRequest();
            }
            return View(dbTicket);
        }

        #endregion

        #region Post

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Ticket ticket)
        {
            if (id == null)
            {
                return NotFound();
            }
            Ticket dbTicket = await _db.Tickets.FirstOrDefaultAsync(t => t.Id == id);
            if (dbTicket == null)
            {
                return BadRequest();
            }

            bool isExist = await _db.Tickets.AnyAsync(t => t.SeatNumber == ticket.SeatNumber && t.Id!=id);
            if (isExist)
            {
                ModelState.AddModelError("SeatNumber", "This seat number is already exist");
                return View();
            }

            dbTicket.FullName = ticket.FullName;
            dbTicket.SeatNumber = ticket.SeatNumber;
            dbTicket.PhoneNumber = ticket.PhoneNumber;
            dbTicket.Email = ticket.Email;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        #endregion

        #endregion

        //#region Activity

        //public async Task<IActionResult> Activity(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }
        //    Ticket dbTicket = await _db.Tickets.FirstOrDefaultAsync(t => t.Id == id);
        //    if (dbTicket == null)
        //    {
        //        return BadRequest();
        //    }
        //    if(dbTicket.IsDeactive)
        //    {
        //        dbTicket.IsDeactive = false;
        //    }
        //    else
        //    {
        //        dbTicket.IsDeactive = true;
        //    }
        //    await _db.SaveChangesAsync();
        //    return RedirectToAction("Index");
        //}

        //#endregion
    }
}
