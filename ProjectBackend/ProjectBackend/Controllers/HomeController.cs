using Microsoft.AspNetCore.Mvc;
using ProjectBackend.DAL;
using ProjectBackend.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new HomeVM
            
            {
                Sliders = _db.Sliders.ToList(),
                NoticeBoards = _db.NoticeBoards.ToList(),
                NoticeTwos= _db.NoticeTwos.ToList(),
                WhyChooses= _db.WhyChooses.FirstOrDefault(),
                Upcomming = _db.Upcomming.Take(4).ToList(),
                Testimonial= _db.Testimonial.FirstOrDefault()

            };
          
          
            return View(homeVM);
        }
    }
}