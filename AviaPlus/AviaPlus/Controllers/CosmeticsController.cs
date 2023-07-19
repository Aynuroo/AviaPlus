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
    public class CosmeticsController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;
        public CosmeticsController(AppDbContext db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<Cosmetic> cosmetics = await _db.Cosmetics.ToListAsync();
            return View(cosmetics);
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

        public async Task<IActionResult> Add(Cosmetic cosmetic)
        {
            bool isExist = await _db.Cosmetics.AnyAsync(c => c.Name == cosmetic.Name);
            if (isExist)
            {
                ModelState.AddModelError("Name", "This name is already exist!");
                return View();
            }
            if (cosmetic.Photo == null)
            {
                ModelState.AddModelError("Photo", "Please don't leave it blank!");
                return View();
            }
            if (!cosmetic.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Please select the correct file!");
                return View();
            }
            if (cosmetic.Photo.IsOlder2MB())
            {
                ModelState.AddModelError("Photo", "The size is incorrect! Please choose correctly!");
                return View();
            }
            string folder = Path.Combine(_env.WebRootPath, "assets", "img");
            cosmetic.Image = await cosmetic.Photo.SaveFileAsync(folder);
            await _db.Cosmetics.AddAsync(cosmetic);
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
            Cosmetic cosmetic = await _db.Cosmetics.FirstOrDefaultAsync(c => c.Id == id);
            if (cosmetic == null)
            {
                return BadRequest();
            }
            return View(cosmetic);
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
            Cosmetic dbCosmetic = await _db.Cosmetics.FirstOrDefaultAsync(c => c.Id == id);
            if (dbCosmetic == null)
            {
                return BadRequest();
            }
            return View(dbCosmetic);
        }


        #endregion

        #region Post
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Update(int? id, Cosmetic cosmetic)
        {
            if (id == null)
            {
                return NotFound();
            }
            Cosmetic dbCosmetic = await _db.Cosmetics.FirstOrDefaultAsync(c => c.Id == id);
            if (dbCosmetic == null)
            {
                return BadRequest();
            }
            if (cosmetic.Photo != null)
            {
                if (!cosmetic.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Please select the correct file!");
                    return View(dbCosmetic);
                }
                if (cosmetic.Photo.IsOlder2MB())
                {
                    ModelState.AddModelError("Photo", "The size is incorrect! Please choose correctly!");
                    return View(dbCosmetic);
                }
                string folder = Path.Combine(_env.WebRootPath, "assets", "img");
                if (dbCosmetic.Image != null)
                {
                    Extensions.DeleteFile(folder, dbCosmetic.Image);
                }
                dbCosmetic.Image = await cosmetic.Photo.SaveFileAsync(folder);
            }
            dbCosmetic.Name = cosmetic.Name;
            dbCosmetic.Brand = cosmetic.Brand;
            dbCosmetic.Volume = cosmetic.Volume;
            dbCosmetic.Packing = cosmetic.Packing;
            dbCosmetic.Gender = cosmetic.Gender;
            dbCosmetic.Makeup = cosmetic.Makeup;
            dbCosmetic.Age = cosmetic.Age;
            dbCosmetic.SkinType = cosmetic.SkinType;
            dbCosmetic.Quantity = cosmetic.Quantity;
            dbCosmetic.Price = cosmetic.Price;
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
            Cosmetic dbCosmetic = await _db.Cosmetics.FirstOrDefaultAsync(c => c.Id == id);
            if (dbCosmetic == null)
            {
                return BadRequest();
            }
            if (dbCosmetic.IsCancelled)
            {
                dbCosmetic.IsCancelled = false;
            }
            else
            {
                dbCosmetic.IsCancelled = true;
            }
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        #endregion

    }
}
