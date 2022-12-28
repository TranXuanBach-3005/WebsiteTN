using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
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

        public IActionResult Index(int ? page)
        {
            try
            {
                var pageNumber = page == null || page <= 0 ? 1 : page.Value;
                var pageSize = 10;
                var products = _dbContext.Products.AsNoTracking().OrderBy(x => x.DateCreated);
                Product product = new Product();
                var productSelling = _dbContext.Products.AsNoTracking().Where(x => x.BestSellers==true && x.Active == true).ToList();
                PagedList<Product> models = new PagedList<Product>(products, pageNumber, pageSize);
                ViewBag.CurentPage = pageNumber;
                ViewBag.ProductSelling = productSelling;
                return View(models);
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Home");
            }
        }
        [Route("/{Alias}-{id}.html", Name =("ProductDetails"))]
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
