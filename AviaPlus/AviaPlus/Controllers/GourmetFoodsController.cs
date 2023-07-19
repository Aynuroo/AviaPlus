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
    public class GourmetFoodsController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;
        public GourmetFoodsController(AppDbContext db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<GourmetFood> gourmetFoods = await _db.GourmetFoods.ToListAsync();
            return View(gourmetFoods);
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

        public async Task<IActionResult> Add(GourmetFood gourmetFood)
        {
            bool isExist = await _db.GourmetFoods.AnyAsync(g => g.Name == gourmetFood.Name);
            if (isExist)
            {
                ModelState.AddModelError("Name", "This name is already exist!");
                return View();
            }
            if (gourmetFood.Photo == null)
            {
                ModelState.AddModelError("Photo", "Please don't leave it blank!");
                return View();
            }
            if (!gourmetFood.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Please select the correct file!");
                return View();
            }
            if (gourmetFood.Photo.IsOlder2MB())
            {
                ModelState.AddModelError("Photo", "The size is incorrect! Please choose correctly!");
                return View();
            }
            string folder = Path.Combine(_env.WebRootPath, "assets", "img");
            gourmetFood.Image = await gourmetFood.Photo.SaveFileAsync(folder);
            await _db.GourmetFoods.AddAsync(gourmetFood);
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
            GourmetFood gourmetFood = await _db.GourmetFoods.FirstOrDefaultAsync(g => g.Id == id);
            if (gourmetFood == null)
            {
                return BadRequest();
            }
            return View(gourmetFood);
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
            GourmetFood dbGourmetFood = await _db.GourmetFoods.FirstOrDefaultAsync(g => g.Id == id);
            if (dbGourmetFood == null)
            {
                return BadRequest();
            }
            return View(dbGourmetFood);
        }


        #endregion

        #region Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, GourmetFood gourmetFood)
        {
            if (id == null)
            {
                return NotFound();
            }
            GourmetFood dbGourmetFood = await _db.GourmetFoods.FirstOrDefaultAsync(g => g.Id == id);
            if (dbGourmetFood == null)
            {
                return BadRequest();
            }
            if (gourmetFood.Photo != null)
            {
                if (!gourmetFood.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Please select the correct file!");
                    return View(dbGourmetFood);
                }
                if (gourmetFood.Photo.IsOlder2MB())
                {
                    ModelState.AddModelError("Photo", "The size is incorrect! Please choose correctly!");
                    return View(dbGourmetFood);
                }
                string folder = Path.Combine(_env.WebRootPath, "assets", "img");
                if (dbGourmetFood.Image != null)
                {
                    Extensions.DeleteFile(folder, dbGourmetFood.Image);
                }
                dbGourmetFood.Image = await gourmetFood.Photo.SaveFileAsync(folder);
            }
            dbGourmetFood.Name = gourmetFood.Name;
            dbGourmetFood.Brand = gourmetFood.Brand;
            dbGourmetFood.Weight = gourmetFood.Weight;
            dbGourmetFood.Packing = gourmetFood.Packing;
            dbGourmetFood.Foods = gourmetFood.Foods;
            dbGourmetFood.Quantity = gourmetFood.Quantity;
            dbGourmetFood.Price = gourmetFood.Price;
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
            GourmetFood dbGourmetFood = await _db.GourmetFoods.FirstOrDefaultAsync(g => g.Id == id);
            if (dbGourmetFood == null)
            {
                return BadRequest();
            }
            if (dbGourmetFood.IsCancelled)
            {
                dbGourmetFood.IsCancelled = false;
            }
            else
            {
                dbGourmetFood.IsCancelled = true;
            }
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        #endregion

    }
}
