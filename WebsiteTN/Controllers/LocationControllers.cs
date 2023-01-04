using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebsiteTN.Models;

namespace WebsiteTN.Controllers
{
    public class LocationControllers : Controller
    {
        private readonly DataDbContext _context;

        public LocationControllers(DataDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListDistrict(int LocationId)
        {
            var Districts = _context.Locations.OrderBy(x => x.LocationId)
                                              .Where(x => x.Parent == LocationId && x.Levels == 2)
                                              .OrderBy(x => x.NameWithType)
                                              .ToList();
            return Json(Districts);
        }
        public IActionResult ListWard(int LocationId)
        {
            var Wards = _context.Locations.OrderBy(x => x.LocationId)
                                              .Where(x => x.Parent == LocationId && x.Levels == 3)
                                              .OrderBy(x => x.NameWithType)
                                              .ToList();
            return Json(Wards);
        }
    }
}
