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
            public async Task<IActionResult> Create(Teacher teachs)
            {
                if (!ModelState.IsValid) return View();
                bool isExist = _context.Teacher.Any(tc => tc.Name.ToLower().Trim() == teachs.Name.ToLower().Trim());
                if (isExist)
                {
                    ModelState.AddModelError("SubTitle", "Bu adda muellim movcuddur");
                    return View();
                }
                await _context.Teacher.AddAsync(teachs);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            //detail//
            public async Task<IActionResult> Detail(int? id)
            {
                if (id == null) return NotFound();
                Teacher teachs = await _context.Teacher.FirstOrDefaultAsync(tc => tc.Id == id);
                if (teachs == null) return NotFound();
                return View(teachs);
            }
            //Delete//
            public async Task<IActionResult> Delete(int? id)
            {
                if (id == null) return NotFound();
                Teacher teachs = await _context.Teacher.FirstOrDefaultAsync(tc => tc.Id == id);
                if (teachs == null) return NotFound();
                return View(teachs);
            }
            [HttpPost]
            [ValidateAntiForgeryToken]
            [ActionName("Delete")]
            //DeletePost//
            public async Task<IActionResult> DeletePost(int? id)
            {
                if (id == null) return NotFound();
                Teacher teachs = await _context.Teacher.FirstOrDefaultAsync(tc => tc.Id == id);
                if (teachs == null) return NotFound();
                _context.Teacher.Remove(teachs);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            //Update//
            public async Task<IActionResult> Update(int? id)
            {
                if (id == null) return NotFound();
                Teacher teachs = await _context.Teacher.FirstOrDefaultAsync(tc => tc.Id == id);
                if (teachs == null) return NotFound();
                return View(teachs);
            }
            public async Task<IActionResult> Update(int? id, Teacher teachs)
            {
                if (id == null) return NotFound();
                Teacher teachsView = await _context.Teacher.FirstOrDefaultAsync(tc => tc.Id == id);
                if (teachs == null) return NotFound();
                if (!ModelState.IsValid)
                {
                    return View(teachsView);
                }
                Teacher teachsDb = await _context.Teacher
                    .FirstOrDefaultAsync(tc => tc.Name.ToLower().Trim() == teachs.Name.ToLower().Trim());
                if (teachsDb != null && teachsDb.Id != id)
                {
                    ModelState.AddModelError("SubTitle", "This category is already exist");
                    return View(teachsView);
                }
                teachsView.Name = teachs.Name;
                teachsView.Qualification = teachs.Qualification;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
        }
    }


