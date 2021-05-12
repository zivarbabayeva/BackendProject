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
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM
            {
                Sliders = _context.Sliders.ToList(),
                Caption = _context.Captions.FirstOrDefault()
            };
          
            return View(homeVM);
        }
    }
}