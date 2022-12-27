using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebsiteTN.Models;

namespace WebsiteTN.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SearchsController : Controller
    {
        private readonly DataDbContext _context;

        public SearchsController(DataDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult FindProduct(string keyword)
        {
            List<Product> products = new List<Product>();
            if(string.IsNullOrEmpty(keyword) || keyword.Length < 1 || keyword == null)
            {
                return PartialView("ListProductsSearchPartial", null);
            }
            products = _context.Products.AsNoTracking()
                                        .Include(x => x.Category)
                                        .Where(x => x.ProductName.Contains(keyword))
                                        .OrderByDescending(x => x.ProductName)
                                        .Take(10)
                                        .ToList();
            if(products == null)
            {
                return PartialView("ListProductsSearchPartial", null);
            }
            else
            {
                return PartialView("ListProductsSearchPartial", products);
            }
        }
    }
}
