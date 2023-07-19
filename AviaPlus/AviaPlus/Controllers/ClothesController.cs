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
    public class ClothesController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;
        public ClothesController(AppDbContext db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<Clothes> clothes = await _db.Clothes.ToListAsync();
            return View(clothes);
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

        public async Task<IActionResult> Add(Clothes clothes)
        {
            bool isExist = await _db.Clothes.AnyAsync(c => c.Name == clothes.Name);
            if (isExist)
            {
                ModelState.AddModelError("Name", "This name is already exist!");
                return View();
            }
            if (clothes.Photo == null)
            {
                ModelState.AddModelError("Photo", "Please don't leave it blank!");
                return View();
            }
            if (!clothes.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Please select the correct file!");
                return View();
            }
            if (clothes.Photo.IsOlder2MB())
            {
                ModelState.AddModelError("Photo", "The size is incorrect! Please choose correctly!");
                return View();
            }
            string folder = Path.Combine(_env.WebRootPath, "assets", "img");
            clothes.Image = await clothes.Photo.SaveFileAsync(folder);
            await _db.Clothes.AddAsync(clothes);
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
            Clothes clothes = await _db.Clothes.FirstOrDefaultAsync(c => c.Id == id);
            if (clothes == null)
            {
                return BadRequest();
            }
            return View(clothes);
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
            Clothes dbClothes = await _db.Clothes.FirstOrDefaultAsync(c => c.Id == id);
            if (dbClothes == null)
            {
                return BadRequest();
            }
            return View(dbClothes);
        }


        #endregion

        #region Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Clothes clothes)
        {
            if (id == null)
            {
                return NotFound();
            }
            Clothes dbClothes = await _db.Clothes.FirstOrDefaultAsync(c => c.Id == id);
            if (dbClothes == null)
            {
                return BadRequest();
            }
            if (clothes.Photo != null)
            {
                if (!clothes.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Please select the correct file!");
                    return View(dbClothes);
                }
                if (clothes.Photo.IsOlder2MB())
                {
                    ModelState.AddModelError("Photo", "The size is incorrect! Please choose correctly!");
                    return View(dbClothes);
                }
                string folder = Path.Combine(_env.WebRootPath, "assets", "img");
                if (dbClothes.Image != null)
                {
                    Extensions.DeleteFile(folder, dbClothes.Image);
                }
                dbClothes.Image = await clothes.Photo.SaveFileAsync(folder);
            }
            dbClothes.Name = clothes.Name;
            dbClothes.Brand = clothes.Brand;
            dbClothes.MainFabric = clothes.MainFabric;
            dbClothes.Size = clothes.Size;
            dbClothes.Description = clothes.Description;
            dbClothes.Color = clothes.Color;
            dbClothes.Quantity = clothes.Quantity;
            dbClothes.Price = clothes.Price;
            dbClothes.IsFemale = clothes.IsFemale;
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
            Clothes dbClothes = await _db.Clothes.FirstOrDefaultAsync(c => c.Id == id);
            if (dbClothes == null)
            {
                return BadRequest();
            }
            if (dbClothes.IsCancelled)
            {
                dbClothes.IsCancelled = false;
            }
            else
            {
                dbClothes.IsCancelled = true;
            }
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        #endregion

    }
}
