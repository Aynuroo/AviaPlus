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
    public class JewelriesController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;
        public JewelriesController(AppDbContext db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<Jewelry> jewelries = await _db.Jewelries.ToListAsync();
            return View(jewelries);
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

        public async Task<IActionResult> Add(Jewelry jewelry)
        {
            bool isExist = await _db.Jewelries.AnyAsync(j => j.Name == jewelry.Name);
            if (isExist)
            {
                ModelState.AddModelError("Name", "This name is already exist!");
                return View();
            }
            if (jewelry.Photo == null)
            {
                ModelState.AddModelError("Photo", "Please don't leave it blank!");
                return View();
            }
            if (!jewelry.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Please select the correct file!");
                return View();
            }
            if (jewelry.Photo.IsOlder2MB())
            {
                ModelState.AddModelError("Photo", "The size is incorrect! Please choose correctly!");
                return View();
            }
            string folder = Path.Combine(_env.WebRootPath, "assets", "img");
            jewelry.Image = await jewelry.Photo.SaveFileAsync(folder);
            await _db.Jewelries.AddAsync(jewelry);
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
            Jewelry jewelry = await _db.Jewelries.FirstOrDefaultAsync(j => j.Id == id);
            if (jewelry == null)
            {
                return BadRequest();
            }
            return View(jewelry);
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
            Jewelry dbJewelry = await _db.Jewelries.FirstOrDefaultAsync(j => j.Id == id);
            if (dbJewelry == null)
            {
                return BadRequest();
            }
            return View(dbJewelry);
        }


        #endregion

        #region Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Jewelry jewelry)
        {
            if (id == null)
            {
                return NotFound();
            }
            Jewelry dbJewelry = await _db.Jewelries.FirstOrDefaultAsync(j => j.Id == id);
            if (dbJewelry == null)
            {
                return BadRequest();
            }
            if (jewelry.Photo != null)
            {
                if (!jewelry.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Please select the correct file!");
                    return View(dbJewelry);
                }
                if (jewelry.Photo.IsOlder2MB())
                {
                    ModelState.AddModelError("Photo", "The size is incorrect! Please choose correctly!");
                    return View(dbJewelry);
                }
                string folder = Path.Combine(_env.WebRootPath, "assets", "img");
                if (dbJewelry.Image != null)
                {
                    Extensions.DeleteFile(folder, dbJewelry.Image);
                }
                dbJewelry.Image = await jewelry.Photo.SaveFileAsync(folder);
            }
            dbJewelry.Name = jewelry.Name;
            dbJewelry.Brand = jewelry.Brand;
            dbJewelry.ArticleNo = jewelry.ArticleNo;
            dbJewelry.Collection = jewelry.Collection;
            dbJewelry.Description = jewelry.Description;
            dbJewelry.Color = jewelry.Color;
            dbJewelry.MinimumLength = jewelry.MinimumLength;
            dbJewelry.MaximumLength = jewelry.MaximumLength;
            dbJewelry.Quantity = jewelry.Quantity;
            dbJewelry.Price = jewelry.Price;
            dbJewelry.Width = jewelry.Width;
            dbJewelry.Material = jewelry.Material;
            dbJewelry.IsFemale = jewelry.IsFemale;
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
            Jewelry dbJewelry = await _db.Jewelries.FirstOrDefaultAsync(j => j.Id == id);
            if (dbJewelry == null)
            {
                return BadRequest();
            }
            if (dbJewelry.IsCancelled)
            {
                dbJewelry.IsCancelled = false;
            }
            else
            {
                dbJewelry.IsCancelled = true;
            }
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        #endregion

    }
}
