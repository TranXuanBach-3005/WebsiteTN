using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebsiteTN.Models;

namespace WebsiteTN.Controllers
{
    public class PagesController : Controller
    {
        private readonly DataDbContext _context;

        public PagesController(DataDbContext context)
        {
            _context = context;
        }
        [Route("/pages/{Alias}", Name = "PageDetails")]
        public IActionResult Details(string Alias)
        {
            if (string.IsNullOrEmpty(Alias)) return RedirectToAction("Index", "Home");
            var page = _context.Pages.AsNoTracking().SingleOrDefault(x => x.Alias == Alias);
            if(page == null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View(page);
        }
    }
}
