using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectBackend.DAL;
using ProjectBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _db;
        public BlogController(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            List<Blog> blogs = await _db.Blog.ToListAsync();
            return View(blogs);
        }
        public IActionResult Details(int id)
        {
           
            Blogdetails detail = _db.Blogdetails.Include(det => det.Blog).FirstOrDefault(detail => detail.BlogId == id);

            return View(detail);
        }
        public async Task<IActionResult> Search(string search)
        {

            List<Blog> blogs = await _db.Blog.Where(x => x.Title.Contains(search)).ToListAsync();
            return View(blogs);
        }
    }
}

