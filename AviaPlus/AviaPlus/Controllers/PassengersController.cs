using AviaPlus.DAL;
using AviaPlus.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AviaPlus.Controllers
{
    public class PassengersController : Controller
    {
        private readonly AppDbContext _db;
        public PassengersController(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            List<Passenger> passengers = await _db.Passengers.ToListAsync();
            return View(passengers);
        }

        #region Create

        #region Get
        public IActionResult Create()
        {
            return View();
        }
        #endregion

        #region Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Passenger passenger)
        {
            bool isExist = await _db.Passengers.AnyAsync(p => p.SeatNumber == passenger.SeatNumber);
            if (isExist)
            {
                ModelState.AddModelError("SeatNumber", "This seat number is already exist");
                return View();
            }
            await _db.Passengers.AddAsync(passenger);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        #endregion

        #endregion

        #region Detail

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Passenger passenger = await _db.Passengers.FirstOrDefaultAsync(p => p.Id == id);
            if (passenger == null)
            {
                return BadRequest();
            }
            return View(passenger);
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
            Passenger dbPassenger = await _db.Passengers.FirstOrDefaultAsync(p => p.Id == id);
            if (dbPassenger == null)
            {
                return BadRequest();
            }
            return View(dbPassenger);
        }

        #endregion

        #region Post

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Passenger passenger)
        {
            if (id == null)
            {
                return NotFound();
            }
            Passenger dbPassenger = await _db.Passengers.FirstOrDefaultAsync(p => p.Id == id);
            if (dbPassenger == null)
            {
                return BadRequest();
            }

            bool isExist = await _db.Passengers.AnyAsync(p => p.SeatNumber == passenger.SeatNumber && p.Id!=id);
            if (isExist)
            {
                ModelState.AddModelError("SeatNumber", "This seat number is already exist");
                return View();
            }

            dbPassenger.FullName = passenger.FullName;
            dbPassenger.SeatNumber = passenger.SeatNumber;
            dbPassenger.PhoneNumber = passenger.PhoneNumber;
            dbPassenger.Email = passenger.Email;
            dbPassenger.Ticket = passenger.Ticket;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        #endregion

        #endregion

        #region Activity

        public async Task<IActionResult> Activity(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Passenger dbPassenger = await _db.Passengers.FirstOrDefaultAsync(p => p.Id == id);
            if (dbPassenger == null)
            {
                return BadRequest();
            }
            if(dbPassenger.IsDeactive)
            {
                dbPassenger.IsDeactive = false;
            }
            else
            {
                dbPassenger.IsDeactive = true;
            }
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        #endregion
    }
}
