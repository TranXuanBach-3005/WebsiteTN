using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebsiteTN.Models;

namespace WebsiteTN.Controllers
{
    public class ProductsController : Controller
    {
        private readonly DataDbContext _dbContext;

        public ProductsController(DataDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(int id)
        {
            var product = _dbContext.Products.Include(x => x.Category).FirstOrDefault(x => x.ProductId == id);
            if(product == null)
            {
                return RedirectToAction("Index");
            }

            return View(product);
        }
    }
}
