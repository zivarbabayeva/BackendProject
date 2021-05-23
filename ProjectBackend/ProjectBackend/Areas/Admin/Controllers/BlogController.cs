using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectBackend.DAL;
using ProjectBackend.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Blog.ToListAsync());
        }
        //Create //
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Blog blogs)
        {
            if (!ModelState.IsValid) return View();
            bool isExist = _context.Blog.Any(bl => bl.Title.ToLower().Trim() == blogs.Title.ToLower().Trim());
            if (isExist)
            {
                ModelState.AddModelError("Title", "Bu adda kurs movcuddur");
                return View();
            }
            await _context.Blog.AddAsync(blogs);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        //detail//
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            Blog blogs = await _context.Blog.FirstOrDefaultAsync(bl => bl.Id == id);
            if (blogs == null) return NotFound();
            return View(blogs);
        }
        //Delete//
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Blog blogs = await _context.Blog.FirstOrDefaultAsync(bl => bl.Id == id);
            if (blogs == null) return NotFound();
            return View(blogs);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        //DeletePost//
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            Blog blogs = await _context.Blog.FirstOrDefaultAsync(bl => bl.Id == id);
            if (blogs == null) return NotFound();
            _context.Blog.Remove(blogs);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        //Update//
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            Blog blogs = await _context.Blog.FirstOrDefaultAsync(bl => bl.Id == id);
            if (blogs == null) return NotFound();
            return View(blogs);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Blog blogs)
        {
            if (id == null) return NotFound();
            Blog blogsView = await _context.Blog.FirstOrDefaultAsync(bl => bl.Id == id);
            if (blogs == null) return NotFound();
            if (!ModelState.IsValid)
            {
                return View(blogsView);
            }
            Blog blogsDb = await _context.Blog
                .FirstOrDefaultAsync(bl => bl.Title.ToLower().Trim() == blogs.Title.ToLower().Trim());
            if (blogsDb != null && blogsDb.Id != id)
            {
                ModelState.AddModelError("Title", "This category is already exist");
                return View(blogsView);
            }
            blogsView.Title = blogs.Title;
            blogsView.ImageUrl = blogs.ImageUrl;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
