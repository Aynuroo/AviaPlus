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
        public async Task<IActionResult> Create(Passenger passenger)
        {
            //bool isExist = await _db.Passengers.AnyAsync(p => p.FullName == passenger.FullName);
            //if (isExist)
            //{
            //    ModelState.AddModelError("FullName", "This service is already exist");
            //    return View();
            //}
            await _db.Passengers.AddAsync(passenger);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        #endregion

        #endregion

    }
}
