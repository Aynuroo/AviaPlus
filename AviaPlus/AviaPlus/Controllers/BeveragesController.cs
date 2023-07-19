using AviaPlus.DAL;
using AviaPlus.Helpers;
using AviaPlus.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using static AviaPlus.Helpers.Helper;

namespace AviaPlus.Controllers
{
    //[Authorize(Roles = "Admin,ConManager")]
    public class BeveragesController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;
        public BeveragesController(AppDbContext db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<Beverage> beverages = await _db.Beverages.ToListAsync();
            return View(beverages);
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

        public async Task<IActionResult> Add(Beverage beverage)
        {
            bool isExist = await _db.Beverages.AnyAsync(b => b.Name == beverage.Name);
            if (isExist)
            {
                ModelState.AddModelError("Name", "This name is already exist!");
                return View();
            }
            if (beverage.Photo == null)
            {
                ModelState.AddModelError("Photo", "Please don't leave it blank!");
                return View();
            }
            if (!beverage.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Please select the correct file!");
                return View();
            }
            if (beverage.Photo.IsOlder2MB())
            {
                ModelState.AddModelError("Photo", "The size is incorrect! Please choose correctly!");
                return View();
            }
            string folder = Path.Combine(_env.WebRootPath, "assets", "img");
            beverage.Image = await beverage.Photo.SaveFileAsync(folder);
            await _db.Beverages.AddAsync(beverage);
            await _db.SaveChangesAsync();
            return Redirect("Index");
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
            Beverage beverage = await _db.Beverages.FirstOrDefaultAsync(b => b.Id == id);
            if (beverage == null)
            {
                return BadRequest();
            }
            return View(beverage);
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
            Beverage dbBeverage = await _db.Beverages.FirstOrDefaultAsync(b => b.Id == id);
            if (dbBeverage == null)
            {
                return BadRequest();
            }
            return View(dbBeverage);
        }


        #endregion

        #region Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Beverage beverage)
        {
            if (id == null)
            {
                return NotFound();
            }
            Beverage dbBeverage = await _db.Beverages.FirstOrDefaultAsync(b => b.Id == id);
            if (dbBeverage == null)
            {
                return BadRequest();
            }
            if (beverage.Photo != null)
            {
                if (!beverage.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Please select the correct file!");
                    return View(dbBeverage);
                }
                if (beverage.Photo.IsOlder2MB())
                {
                    ModelState.AddModelError("Photo", "The size is incorrect! Please choose correctly!");
                    return View(dbBeverage);
                }
                string folder = Path.Combine(_env.WebRootPath, "assets", "img");
                if (dbBeverage.Image != null)
                {
                    Extensions.DeleteFile(folder, dbBeverage.Image);
                }
                dbBeverage.Image = await beverage.Photo.SaveFileAsync(folder);
            }
            dbBeverage.Name = beverage.Name;
            dbBeverage.Brand = beverage.Brand;
            dbBeverage.Calories = beverage.Calories;
            dbBeverage.Packing = beverage.Packing;
            dbBeverage.Description = beverage.Description;
            dbBeverage.IsHot = beverage.IsHot;
            dbBeverage.Quantity = beverage.Quantity;
            dbBeverage.Price = beverage.Price;
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
            Beverage dbBeverage = await _db.Beverages.FirstOrDefaultAsync(b => b.Id == id);
            if (dbBeverage == null)
            {
                return BadRequest();
            }
            if (dbBeverage.IsCancelled)
            {
                dbBeverage.IsCancelled = false;
            }
            else
            {
                dbBeverage.IsCancelled = true;
            }
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        #endregion

    }
}
