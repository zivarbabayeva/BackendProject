using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectBackend.DAL;
using ProjectBackend.Models;
using ProjectBackend.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.Controllers
{
    public class CoursesController : Controller
    {
        private readonly AppDbContext _db;
        public CoursesController(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            List<CoursesOffer> coursesOffers = await _db.CoursesOffers.ToListAsync();
            return View(coursesOffers);
        }
        public IActionResult Details(int id)
        {

            CourseDetails detail = _db.CourseDetails.Include(det => det.CoursesOffer).FirstOrDefault(detail => detail.CoursesOfferId == id);

            return View(detail);

        }
           
        }
    }

