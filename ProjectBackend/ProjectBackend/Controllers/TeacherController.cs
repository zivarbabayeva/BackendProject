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
    public class TeacherController : Controller
    {
        private readonly AppDbContext _db;
        public TeacherController(AppDbContext db)
        {

            _db = db;
        }
       
        public async Task<IActionResult> Index()
        {
            List<Teacher> teachers = await _db.Teacher.ToListAsync();
            return View(teachers);
        }
        public IActionResult Details(int id)
        {

            TeacherDetails detail = _db.TeacherDetails.Include(det => det.Teacher).FirstOrDefault(detail => detail.TeacherId == id);

            return View(detail);

        }

    }
    }

