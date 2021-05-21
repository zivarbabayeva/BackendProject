using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectBackend.DAL;
using ProjectBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CoursesController : Controller
    {
        private readonly AppDbContext _context;
        public CoursesController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.CoursesOffers.ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CoursesOffer courses)
        {
            if (!ModelState.IsValid) return View();
            bool isExist = _context.CoursesOffers.Any(cr => cr.SubTitle.ToLower().Trim() == courses.SubTitle.ToLower().Trim());
            if (isExist)
            {
                ModelState.AddModelError("SubTitle", "Bu adda kurs movcuddur");
                return View();
            }     
            await _context.CoursesOffers.AddAsync(courses);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Detail (int? id)
        {
            if (id == null) return NotFound();
            CoursesOffer courses =await _context.CoursesOffers.FirstOrDefaultAsync(cr => cr.Id == id);
            if (courses == null) return NotFound();
            return View(courses);
        }
        public async Task<IActionResult>Delete(int? id)
        {
            if (id == null) return NotFound();
            CoursesOffer courses = await _context.CoursesOffers.FirstOrDefaultAsync(cr => cr.Id == id);
            if (courses == null) return NotFound();
            return View(courses);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            CoursesOffer courses = await _context.CoursesOffers.FirstOrDefaultAsync(cr => cr.Id == id);
            if (courses == null) return NotFound();
            _context.CoursesOffers.Remove(courses);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            CoursesOffer courses = await _context.CoursesOffers.FirstOrDefaultAsync(cr => cr.Id == id);
            if (courses == null) return NotFound();
            return View(courses);
        }
    }
}
