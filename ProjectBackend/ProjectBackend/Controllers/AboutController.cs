using Microsoft.AspNetCore.Mvc;
using ProjectBackend.DAL;
using ProjectBackend.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.Controllers

{
    public class AboutController : Controller
    {

        private readonly AppDbContext _db;
        public AboutController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
        
            AboutVM aboutVM = new AboutVM
            {
                About = _db.Abouts.FirstOrDefault(),
                Testimonial = _db.Testimonial.FirstOrDefault(),
                NoticeBoard = _db.NoticeBoards.ToList(),
                VideoTour = _db.VideoTour.FirstOrDefault()

            };
            return View(aboutVM);
        }

    }
}
