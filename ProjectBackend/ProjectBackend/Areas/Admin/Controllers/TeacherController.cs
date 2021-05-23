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
    public class TeacherController : Controller
    {
            private readonly AppDbContext _context;
            public TeacherController(AppDbContext context)
            {
                _context = context;
            }
            public async Task<IActionResult> Index()
            {
                return View(await _context.Teacher.ToListAsync());
            }
        //Create //
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Teacher teach)
        {
            if (!ModelState.IsValid) return View();
            bool isExist = _context.Teacher.Any(tc => tc.Name.ToLower().Trim() == teach.Name.ToLower().Trim());
            if (isExist)
            {
                ModelState.AddModelError("Name", "Bu adda muellim movcuddur");
                return View();
            }
            await _context.Teacher.AddAsync(teach);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        //detail//
        public async Task<IActionResult> Detail(int? id)
            {
                if (id == null) return NotFound();
                Teacher teach = await _context.Teacher.FirstOrDefaultAsync(tc => tc.Id == id);
                if (teach == null) return NotFound();
                return View(teach);
            }
            //Delete//
            public async Task<IActionResult> Delete(int? id)
            {
                if (id == null) return NotFound();
                Teacher teach = await _context.Teacher.FirstOrDefaultAsync(tc => tc.Id == id);
                if (teach == null) return NotFound();
                return View(teach);
            }
            [HttpPost]
            [ValidateAntiForgeryToken]
            [ActionName("Delete")]
            //DeletePost//
            public async Task<IActionResult> DeletePost(int? id)
            {
                if (id == null) return NotFound();
                Teacher teach = await _context.Teacher.FirstOrDefaultAsync(tc => tc.Id == id);
                if (teach == null) return NotFound();
                _context.Teacher.Remove(teach);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            //Update//
            public async Task<IActionResult> Update(int? id)
            {
                if (id == null) return NotFound();
                Teacher teach = await _context.Teacher.FirstOrDefaultAsync(tc => tc.Id == id);
                if (teach == null) return NotFound();
                return View(teach);
            }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Teacher teach)
            {
                if (id == null) return NotFound();
                Teacher teachView = await _context.Teacher.FirstOrDefaultAsync(tc => tc.Id == id);
                if (teach == null) return NotFound();
                if (!ModelState.IsValid)
                {
                    return View(teachView);
                }
                Teacher teachDb = await _context.Teacher
                    .FirstOrDefaultAsync(tc => tc.Name.ToLower().Trim() == teach.Name.ToLower().Trim());
                if (teachDb != null && teachDb.Id != id)
                {
                    ModelState.AddModelError("Name", "This teacher is already exist");
                    return View(teachView);
                }
                teachView.Name = teach.Name;
                teachView.Qualification = teach.Qualification;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
        }
    }


