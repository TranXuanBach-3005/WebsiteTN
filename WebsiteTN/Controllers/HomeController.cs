using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebsiteTN.Models;
using WebsiteTN.ModelViews;

namespace WebsiteTN.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataDbContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, DataDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            HomeVm homeVm = new HomeVm();
            var products = _context.Products.AsNoTracking()
                                            .Where(x => x.Active == true && x.HomeFlag == true)
                                            .OrderByDescending(x => x.DateCreated).ToList();
            List<ProductHomeVm> productsViews = new List<ProductHomeVm>();
            var categories = _context.Categories.AsNoTracking()
                                                .Where(x => x.Published == true)
                                                .OrderByDescending(x => x.Ordering)
                                                .ToList();
            foreach (var item in categories)
            {
                ProductHomeVm productHome = new ProductHomeVm();
                productHome.category = item;
                productHome.Products = products.Where(x => x.CategoryId == item.CategoryId).ToList();
                productsViews.Add(productHome);
                var advertisement = _context.Advertisements.AsNoTracking()
                                                           .FirstOrDefault(x => x.Active == true);
                var posts = _context.Posts.AsNoTracking()
                                          .Where(x => x.Published == true && x.IsNewfeed == true)
                                          .OrderByDescending(x => x.CreatedDate)
                                          .Take(3)
                                          .ToList();
                homeVm.Products = productsViews;
                homeVm.advertisement = advertisement;
                homeVm.Posts = posts;
                ViewBag.AllProducts = products;
            }
            return View(homeVm);
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
