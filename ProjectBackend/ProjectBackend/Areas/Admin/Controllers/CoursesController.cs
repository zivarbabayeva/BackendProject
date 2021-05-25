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
        //Create //
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
            await _context.AddRangeAsync(courses,courses.CourseDetails);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        //detail//
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            CoursesOffer courses = await _context.CoursesOffers.FirstOrDefaultAsync(cr => cr.Id == id);
            if (courses == null) return NotFound();
            return View(courses);
        }
        //Delete//
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            CoursesOffer courses = await _context.CoursesOffers.FirstOrDefaultAsync(cr => cr.Id == id);
            if (courses == null) return NotFound();
            return View(courses);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        //DeletePost//
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            CoursesOffer courses = await _context.CoursesOffers.FirstOrDefaultAsync(cr => cr.Id == id);
            if (courses == null) return NotFound();
            _context.CoursesOffers.Remove(courses);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        //Update//
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            CoursesOffer courses = await _context.CoursesOffers.FirstOrDefaultAsync(cr => cr.Id == id);
            if (courses == null) return NotFound();
            return View(courses);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, CoursesOffer courses)
        {
            if (id == null) return NotFound();
            CoursesOffer coursesView = await _context.CoursesOffers.FirstOrDefaultAsync(cr => cr.Id == id);
            if (courses == null) return NotFound();
            if (!ModelState.IsValid)
            {
                return View(coursesView);
            }
            CoursesOffer coursesDb = await _context.CoursesOffers
                .FirstOrDefaultAsync(cr => cr.SubTitle.ToLower().Trim() == courses.SubTitle.ToLower().Trim());
            if (coursesDb != null && coursesDb.Id != id)
            {
                ModelState.AddModelError("SubTitle", "This category is already exist");
                return View(coursesView);
            }
            coursesView.SubTitle = courses.SubTitle;
            coursesView.Description = courses.Description;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

       


    }
    }
