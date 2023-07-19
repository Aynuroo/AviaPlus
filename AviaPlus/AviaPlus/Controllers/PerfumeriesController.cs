using AviaPlus.DAL;
using AviaPlus.Helpers;
using AviaPlus.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Threading.Tasks;
using static AviaPlus.Helpers.Helper;

namespace AviaPlus.Controllers
{
    //[Authorize(Roles = "Admin,ConManager")]
    public class PerfumeriesController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;
        public PerfumeriesController(AppDbContext db,IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<Perfumery> perfumeries = await _db.Perfumeries.ToListAsync();
            return View(perfumeries);
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

        public async Task<IActionResult> Add(Perfumery perfumery)
        {
            bool isExist = await _db.Perfumeries.AnyAsync(p => p.Name == perfumery.Name);
            if (isExist)
            {
                ModelState.AddModelError("Name", "This name is already exist!");
                return View();
            }
            if (perfumery.Photo == null)
            {
                ModelState.AddModelError("Photo", "Please don't leave it blank!");
                return View();
            }
            if(!perfumery.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Please select the correct file!");
                return View();
            }
            if (perfumery.Photo.IsOlder2MB())
            {
                ModelState.AddModelError("Photo", "The size is incorrect! Please choose correctly!");
                return View();
            }
            string folder = Path.Combine(_env.WebRootPath, "assets","img");
            perfumery.Image = await perfumery.Photo.SaveFileAsync(folder);
            await _db.Perfumeries.AddAsync(perfumery);
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
            Perfumery perfumery = await _db.Perfumeries.FirstOrDefaultAsync(p => p.Id == id);
            if (perfumery == null)
            {
                return BadRequest();
            }
            return View(perfumery);
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
            Perfumery dbPerfumery = await _db.Perfumeries.FirstOrDefaultAsync(p => p.Id == id);
            if(dbPerfumery == null)
            {
                return BadRequest();
            }
            return View(dbPerfumery);
        }


        #endregion

        #region Post
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Update(int? id, Perfumery perfumery)
        {
            if (id == null)
            {
                return NotFound();
            }
            Perfumery dbPerfumery = await _db.Perfumeries.FirstOrDefaultAsync(p => p.Id == id);
            if (dbPerfumery == null)
            {
                return BadRequest();
            }
            if (perfumery.Photo != null)
            {
                if (!perfumery.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Please select the correct file!");
                    return View(dbPerfumery);
                }
                if (perfumery.Photo.IsOlder2MB())
                {
                    ModelState.AddModelError("Photo", "The size is incorrect! Please choose correctly!");
                    return View(dbPerfumery);
                }
                string folder = Path.Combine(_env.WebRootPath, "assets", "img");
                if (dbPerfumery.Image != null)
                {
                    Extensions.DeleteFile(folder, dbPerfumery.Image);
                }
                dbPerfumery.Image = await perfumery.Photo.SaveFileAsync(folder);
            }
            dbPerfumery.Name = perfumery.Name;
            dbPerfumery.Brand = perfumery.Brand;
            dbPerfumery.Volume = perfumery.Volume;
            dbPerfumery.Packing = perfumery.Packing;
            dbPerfumery.Gender = perfumery.Gender;
            dbPerfumery.Manufacturer = perfumery.Manufacturer;
            dbPerfumery.FragrantNote = perfumery.FragrantNote;
            dbPerfumery.Quantity = perfumery.Quantity;
            dbPerfumery.Price = perfumery.Price;
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
            Perfumery dbPerfumery = await _db.Perfumeries.FirstOrDefaultAsync(p => p.Id == id);
            if (dbPerfumery == null)
            {
                return BadRequest();
            }
            if (dbPerfumery.IsCancelled)
            {
                dbPerfumery.IsCancelled = false;
            }
            else
            {
                dbPerfumery.IsCancelled = true;
            }
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        #endregion

    }
}
