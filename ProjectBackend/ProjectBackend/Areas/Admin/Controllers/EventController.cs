using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
   
    public class EventController : Controller
    {
        private readonly AppDbContext _context;
        public EventController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            //List<Event> events=_context.Events.Where(ev=>ev.IsDeleted==false).Include(ev=>ev.ImageUrl).Include(ev=>ev.Eventdetails).ThenInclude(ev=>ev.EventSpeakers).ToList();
            return View(await _context.Events.ToListAsync());
            //return View(events);
        }


        #region MyRegion
        //Create //

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Event events)
        {
            if (!ModelState.IsValid) return View();
            bool isExist = _context.Events.Any(ev => ev.Title.ToLower().Trim() == events.Title.ToLower().Trim());
            if (isExist)
            {
                ModelState.AddModelError("Title", "Bu adda kurs movcuddur");
                return View();
            }
            await _context.Events.AddAsync(events);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        #endregion


        #region MyRegion
        //detail//

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            Event events = await _context.Events.FirstOrDefaultAsync(ev => ev.Id == id);
            if (events == null) return NotFound();
            return View(events);
        }

        #endregion

        #region MyRegion

        //Delete//
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Event events = await _context.Events.FirstOrDefaultAsync(ev => ev.Id == id);
            if (events == null) return NotFound();
            return View(events);
        }
        #endregion


        #region MyRegion
        //DeletePost//
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            Event events = await _context.Events.FirstOrDefaultAsync(ev => ev.Id == id);
            if (events == null) return NotFound();
            _context.Events.Remove(events);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region MyRegion
        //Update//
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            Event events = await _context.Events.FirstOrDefaultAsync(ev => ev.Id == id);
            if (events == null) return NotFound();
            return View(events);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Event events)
        {
            if (id == null) return NotFound();
            Event eventsView = await _context.Events.FirstOrDefaultAsync(ev => ev.Id == id);
            if (events == null) return NotFound();
            if (!ModelState.IsValid)
            {
                return View(eventsView);
            }
            Event eventsDb = await _context.Events
                .FirstOrDefaultAsync(ev => ev.Title.ToLower().Trim() == events.Title.ToLower().Trim());
            if (eventsDb != null && eventsDb.Id != id)
            {
                ModelState.AddModelError("Title", "This category is already exist");
                return View(eventsView);
            }
            eventsView.ImageUrl = events.ImageUrl;
            eventsView.Title = events.Title;
            eventsView.StartTime = events.StartTime;
            eventsView.EndTime = events.EndTime;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        #endregion
    }
}
