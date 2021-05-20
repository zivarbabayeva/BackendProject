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
    public class EventController : Controller
    {
        private readonly AppDbContext _db;
        public EventController(AppDbContext db)
        {

            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            List<Event> events = await _db.Events.ToListAsync();
            return View(events);
        }
        public IActionResult Details(int id)
        {

            Eventdetails detail = _db.Eventdetails.Include(det => det.Event).Include(x=>x.EventSpeakers).ThenInclude(x=>x.Speakers).FirstOrDefault(detail => detail.EventId == id);

            return View(detail);

        }
    }
}
