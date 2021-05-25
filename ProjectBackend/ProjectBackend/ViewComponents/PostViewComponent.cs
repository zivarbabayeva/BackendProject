using Microsoft.AspNetCore.Mvc;
using ProjectBackend.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.ViewComponents
{
    public class PostViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;
        public PostViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {

            return View();
        }
    }
}
