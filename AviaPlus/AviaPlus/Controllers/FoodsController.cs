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
    public class FoodsController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;
        public FoodsController(AppDbContext db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<Food> foods = await _db.Foods.ToListAsync();
            return View(foods);
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

        public async Task<IActionResult> Add(Food food)
        {
            bool isExist = await _db.Foods.AnyAsync(g => g.Name == food.Name);
            if (isExist)
            {
                ModelState.AddModelError("Name", "This name is already exist!");
                return View();
            }
            if (food.Photo == null)
            {
                ModelState.AddModelError("Photo", "Please don't leave it blank!");
                return View();
            }
            if (!food.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Please select the correct file!");
                return View();
            }
            if (food.Photo.IsOlder2MB())
            {
                ModelState.AddModelError("Photo", "The size is incorrect! Please choose correctly!");
                return View();
            }
            string folder = Path.Combine(_env.WebRootPath, "assets", "img");
            food.Image = await food.Photo.SaveFileAsync(folder);
            await _db.Foods.AddAsync(food);
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
            Food food = await _db.Foods.FirstOrDefaultAsync(f => f.Id == id);
            if (food == null)
            {
                return BadRequest();
            }
            return View(food);
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
            Food dbFood = await _db.Foods.FirstOrDefaultAsync(f => f.Id == id);
            if (dbFood == null)
            {
                return BadRequest();
            }
            return View(dbFood);
        }


        #endregion

        #region Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Food food)
        {
            if (id == null)
            {
                return NotFound();
            }
            Food dbFood = await _db.Foods.FirstOrDefaultAsync(f => f.Id == id);
            if (dbFood == null)
            {
                return BadRequest();
            }
            if (food.Photo != null)
            {
                if (!food.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Please select the correct file!");
                    return View(dbFood);
                }
                if (food.Photo.IsOlder2MB())
                {
                    ModelState.AddModelError("Photo", "The size is incorrect! Please choose correctly!");
                    return View(dbFood);
                }
                string folder = Path.Combine(_env.WebRootPath, "assets", "img");
                if (dbFood.Image != null)
                {
                    Extensions.DeleteFile(folder, dbFood.Image);
                }
                dbFood.Image = await food.Photo.SaveFileAsync(folder);
            }
            dbFood.Name = food.Name;
            dbFood.Brand = food.Brand;
            dbFood.Calories = food.Calories;
            dbFood.Packing = food.Packing;
            dbFood.Description = food.Description;
            dbFood.Quantity = food.Quantity;
            dbFood.Price = food.Price;
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
            Food dbFood = await _db.Foods.FirstOrDefaultAsync(f => f.Id == id);
            if (dbFood == null)
            {
                return BadRequest();
            }
            if (dbFood.IsCancelled)
            {
                dbFood.IsCancelled = false;
            }
            else
            {
                dbFood.IsCancelled = true;
            }
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        #endregion

    }
}
