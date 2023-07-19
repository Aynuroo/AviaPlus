using AviaPlus.DAL;
using AviaPlus.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using static AviaPlus.Helpers.Helper;

namespace AviaPlus.Controllers
{
    //[Authorize(Roles = "Admin,ConManager")]
    public class FlightsController : Controller
    {
        private readonly AppDbContext _db;
        public FlightsController(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            List<Flight> flights = await _db.Flights.ToListAsync();
            return View(flights);
        }

        #region Add

        #region Get
        public IActionResult Add()
        {
            return View();
        }

        #endregion

        #region Post

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Add(Flight flight)
        {
            await _db.Flights.AddAsync(flight);
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
            Flight flight = await _db.Flights.FirstOrDefaultAsync(f => f.Id == id);
            if (flight == null)
            {
                return BadRequest();
            }
            return View(flight);
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
            Flight dbFlight = await _db.Flights.FirstOrDefaultAsync(f => f.Id == id);
            if (dbFlight == null)
            {
                return BadRequest();
            }
            return View(dbFlight);
        }

        #endregion

        #region Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        
        public async Task<IActionResult> Update(int? id,Flight flight)
        {
            if (id == null)
            {
                return NotFound();
            }
            Flight dbFlight = await _db.Flights.FirstOrDefaultAsync(f => f.Id == id);
            if (dbFlight == null)
            {
                return BadRequest();
            }
            dbFlight.FlightNumber = flight.FlightNumber;
            dbFlight.DepartureTime = flight.DepartureTime;
            dbFlight.ArrivalTime = flight.ArrivalTime;
            dbFlight.Departure = flight.Departure;
            dbFlight.Gate = flight.Gate;
            dbFlight.Carousel = flight.Carousel;
            dbFlight.Price = flight.Price;
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
            Flight dbFlight = await _db.Flights.FirstOrDefaultAsync(f => f.Id == id);
            if (dbFlight == null)
            {
                return BadRequest();
            }
            if (dbFlight.IsCancelled)
            {
                dbFlight.IsCancelled = false;
            }
            else
            {
                dbFlight.IsCancelled = true;
            }
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        #endregion
    }
}
