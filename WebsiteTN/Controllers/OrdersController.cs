using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebsiteTN.Models;
using WebsiteTN.ModelViews;

namespace WebsiteTN.Controllers
{
    public class OrdersController : Controller
    {
        private readonly DataDbContext _context;
        private readonly INotyfService _notyfService;
        public OrdersController(DataDbContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(int? orderId)
        {
            if(orderId == null)
            {
                return NotFound();
            }
            try
            {
                var accountId = HttpContext.Session.GetString("CustomerId");
                if(string.IsNullOrEmpty(accountId))
                {
                    return RedirectToAction("Login", "Accounts");
                }
                var customer = _context.Customers.AsNoTracking()
                                                   .FirstOrDefault(x => x.CustomerId == Convert.ToInt32(accountId));
                if (customer == null)
                {
                    return NotFound();
                }
                var order = _context.Orders.Include(x => x.TransactStatus)
                                           .FirstOrDefault(x => x.OrderId == orderId && Convert.ToInt32(accountId) == x.CustomerId);
                if(order == null)
                {
                    return NotFound();
                }
                var orderDetails = _context.OrderDetails.Include(x => x.Product)
                                                       .AsNoTracking()
                                                       .Where(x => x.OrderId == orderId)
                                                       .OrderBy(x => x.OrderDetailId)
                                                       .ToList();
                ViewOrderVM viewOrder = new ViewOrderVM();
                viewOrder.order = order;
                viewOrder.orderDetails = orderDetails;
                return PartialView("Details", viewOrder);
            }
            catch
            {
                return NotFound();
            }
        }
    }
}
