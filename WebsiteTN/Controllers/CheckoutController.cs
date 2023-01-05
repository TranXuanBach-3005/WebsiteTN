using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebsiteTN.Extension;
using WebsiteTN.Helpper;
using WebsiteTN.Models;
using WebsiteTN.ModelViews;

namespace WebsiteTN.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly DataDbContext _context;
        private readonly INotyfService _notyfService;
        public CheckoutController(DataDbContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }
        public List<CartItem> cartItems
        {
            get
            {
                var cart = HttpContext.Session.Get<List<CartItem>>("keyCart");
                if (cart == default(List<CartItem>))
                {
                    cart = new List<CartItem>();
                }
                return cart;
            }
        }
        [Route("checkout.html", Name = "Checkout")]
        public IActionResult Index(string returnUrl = null)
        {
            var cart = HttpContext.Session.Get<List<CartItem>>("keyCart");
            var accountId = HttpContext.Session.GetString("CustomerId");
            OrderViewModel viewModel = new OrderViewModel();
            if (accountId != null)
            {
                var customer = _context.Customers.AsNoTracking().FirstOrDefault(x => x.CustomerId == Convert.ToInt32(accountId));
                viewModel.CustomerId = customer.CustomerId;
                viewModel.FullName = customer.FullName;
                viewModel.Email = customer.Email;
                viewModel.Phone = customer.Phone;
                viewModel.Address = customer.Address;
            }
            ViewData["ListProvince"] = new SelectList(_context.Locations.Where(x => x.Levels == 1).OrderBy(x => x.Type).ToList(), "Location", "Name");
            ViewBag.Cart = cart;
            return View(viewModel);
        }
        [HttpPost]
        [Route("checkout.html", Name = "Checkout")]
        public IActionResult Index(OrderViewModel viewModel)
        {
            var cart = HttpContext.Session.Get<List<CartItem>>("keyCart");
            var accountId = HttpContext.Session.GetString("CustomerId");
            OrderViewModel model = new OrderViewModel();
            if (accountId != null)
            {
                var customer = _context.Customers.AsNoTracking().FirstOrDefault(x => x.CustomerId == Convert.ToInt32(accountId));
                model.CustomerId = customer.CustomerId;
                model.FullName = customer.FullName;
                model.Email = customer.Email;
                model.Phone = customer.Phone;
                model.Address = customer.Address;

                customer.LocationId = viewModel.Province;
                customer.District = viewModel.District;
                customer.Ward = viewModel.Ward;
                customer.Address = viewModel.Address;
                _context.Update(customer);
                _context.SaveChanges();
            }
            try
            {
                if (ModelState.IsValid)
                {
                    //khởi tạo đơn hàng
                    Order order = new Order();
                    order.CustomerId = model.CustomerId;
                    order.Address = model.Address;
                    order.LocationId = model.Province;
                    order.District = model.District;
                    order.Ward = model.Ward;

                    order.OrderDate = DateTime.Now;
                    order.TransactStatusId = 1;// đơn hàng mới
                    order.Deleted = false;
                    order.Paid = false;
                    order.Note = Utilities.StripHTML(model.Note);
                    order.TotalMoney = Convert.ToInt32(cart.Sum(x => x.TotalMoney));
                    _context.Add(order);
                    _context.SaveChanges();
                    //tạo danh sách đơn hàng
                    foreach (var item in cart)
                    {
                        OrderDetail orderDetail = new OrderDetail();
                        orderDetail.OrderId = order.OrderId;
                        orderDetail.ProductId = item.product.ProductId;
                        orderDetail.Quantity = item.quantity;
                        orderDetail.TotalMoney = order.TotalMoney;
                        orderDetail.Price = item.product.Price;
                        orderDetail.CreateDate = DateTime.Now;
                        _context.Add(orderDetail);
                    }
                    _context.SaveChanges();
                    //xóa giỏ hàng
                    HttpContext.Session.Remove("keyCart");
                    _notyfService.Success("Đơn hàng đặt thàng công");
                    return RedirectToAction("Success");
                }
            }
            catch
            {
                ViewData["ListProvince"] = new SelectList(_context.Locations.Where(x => x.Levels == 1).OrderBy(x => x.Type).ToList(), "Location", "Name");
                ViewBag.Cart = cart;
                return View(viewModel);
            }
            ViewData["ListProvince"] = new SelectList(_context.Locations.Where(x => x.Levels == 1).OrderBy(x => x.Type).ToList(), "Location", "Name");
            ViewBag.Cart = cart;
            return View(viewModel);
        }
        [Route("thanh-cong.html",Name ="Success")]
        public IActionResult Success()
        {
            try
            {
                var accountId = HttpContext.Session.GetString("CustomerId");
                if (string.IsNullOrEmpty(accountId))
                {
                    return RedirectToAction("Login", "Accounts", new { returnUrl = "/thanh-cong.html" });
                }
                var customer = _context.Customers.AsNoTracking().FirstOrDefault(x => x.CustomerId == Convert.ToInt32(accountId));
                var order = _context.Orders.Where(x => x.CustomerId == Convert.ToInt32(accountId))
                                           .OrderByDescending(x => x.OrderDate)
                                           .FirstOrDefault();
                OrderSuccessViewModel viewModel = new OrderSuccessViewModel();
                viewModel.FullName = customer.FullName;
                viewModel.OrderId = order.OrderId;
                viewModel.Phone = customer.Phone;
                viewModel.Address = customer.Address;
                viewModel.District = GetNameLocation(order.District.Value);
                viewModel.Ward = GetNameLocation(order.Ward.Value);
                return View(viewModel);
            }
            catch
            {
                return View();
            }
        }
        public string GetNameLocation(int idLocation)
        {
            try
            {
                var location = _context.Locations.AsNoTracking().FirstOrDefault(x => x.LocationId == idLocation);
                if(location != null)
                {
                    return location.NameWithType;
                }
            }
            catch
            {
                return string.Empty;
            }
            return string.Empty;
        }
    }
}
