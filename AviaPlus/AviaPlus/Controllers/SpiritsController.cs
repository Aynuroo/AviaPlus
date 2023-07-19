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
    public class SpiritsController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;
        public SpiritsController(AppDbContext db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<Spirit> spirits = await _db.Spirits.ToListAsync();
            return View(spirits);
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

        public async Task<IActionResult> Add(Spirit spirit)
        {
            bool isExist = await _db.Spirits.AnyAsync(s => s.Name == spirit.Name);
            if (isExist)
            {
                ModelState.AddModelError("Name", "This name is already exist!");
                return View();
            }
            if (spirit.Photo == null)
            {
                ModelState.AddModelError("Photo", "Please don't leave it blank!");
                return View();
            }
            if (!spirit.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Please select the correct file!");
                return View();
            }
            if (spirit.Photo.IsOlder2MB())
            {
                ModelState.AddModelError("Photo", "The size is incorrect! Please choose correctly!");
                return View();
            }
            string folder = Path.Combine(_env.WebRootPath, "assets", "img");
            spirit.Image = await spirit.Photo.SaveFileAsync(folder);
            await _db.Spirits.AddAsync(spirit);
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
            Spirit spirit = await _db.Spirits.FirstOrDefaultAsync(s => s.Id == id);
            if (spirit == null)
            {
                return BadRequest();
            }
            return View(spirit);
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
            Spirit dbSpirit = await _db.Spirits.FirstOrDefaultAsync(s => s.Id == id);
            if (dbSpirit == null)
            {
                return BadRequest();
            }
            return View(dbSpirit);
        }


        #endregion

        #region Post
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Update(int? id, Spirit spirit)
        {
            if (id == null)
            {
                return NotFound();
            }
            Spirit dbSpirit = await _db.Spirits.FirstOrDefaultAsync(s => s.Id == id);
            if (dbSpirit == null)
            {
                return BadRequest();
            }
            if (spirit.Photo != null)
            {
                if (!spirit.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Please select the correct file!");
                    return View(dbSpirit);
                }
                if (spirit.Photo.IsOlder2MB())
                {
                    ModelState.AddModelError("Photo", "The size is incorrect! Please choose correctly!");
                    return View(dbSpirit);
                }
                string folder = Path.Combine(_env.WebRootPath, "assets", "img");
                if (dbSpirit.Image != null)
                {
                    Extensions.DeleteFile(folder, dbSpirit.Image);
                }
                dbSpirit.Image = await spirit.Photo.SaveFileAsync(folder);
            }
            dbSpirit.Name = spirit.Name;
            dbSpirit.Brand = spirit.Brand;
            dbSpirit.Volume = spirit.Volume;
            dbSpirit.Packing = spirit.Packing;
            dbSpirit.Manufacturer = spirit.Manufacturer;
            dbSpirit.DrinkType = spirit.DrinkType;
            dbSpirit.Quantity = spirit.Quantity;
            dbSpirit.Price = spirit.Price;
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
            Spirit dbSpirit = await _db.Spirits.FirstOrDefaultAsync(s => s.Id == id);
            if (dbSpirit == null)
            {
                return BadRequest();
            }
            if (dbSpirit.IsCancelled)
            {
                dbSpirit.IsCancelled = false;
            }
            else
            {
                dbSpirit.IsCancelled = true;
            }
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        #endregion

    }
}
