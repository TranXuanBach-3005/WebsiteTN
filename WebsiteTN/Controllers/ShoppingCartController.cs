using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebsiteTN.Extension;
using WebsiteTN.Models;
using WebsiteTN.ModelViews;

namespace WebsiteTN.Areas.Admin.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly DataDbContext _context;
        private readonly INotyfService _notyfService;

        public ShoppingCartController(DataDbContext context, INotyfService notyfService)
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
        [HttpPost]
        [Route("api/cart/add")]
        public IActionResult AddToCart(int productId, int? quantity)
        {
            var product = _context.Products.Where(x => x.ProductId == productId).FirstOrDefault();
            if (product == null)
            {
                return NotFound("Không có sản phẩm");
            }
            List<CartItem> cart = cartItems;
            try
            {
                CartItem cartItem = cart.Find(x => x.product.ProductId == productId);
                if (cartItem != null)
                {
                    cartItem.quantity++;
                }
                else
                {
                    cart.Add(new CartItem()
                    {
                        quantity = quantity.HasValue ? quantity.Value : 1,
                        product = product
                    });
                }
                HttpContext.Session.Set<List<CartItem>>("keyCart", cart);
                _notyfService.Success("Thêm sản phẩm thành công");
                return Json(new { success = true });
            }
            catch
            {
                return Json(new { success = false });
            }
        }
        [HttpPost]
        [Route("api/cart/update")]
        public IActionResult UpdateCart(int productId, int quantity)
        {
            var cart = HttpContext.Session.Get<List<CartItem>>("keyCart");
            try
            {
                if (cart != null)
                {
                    CartItem cartItem = cart.Find(x => x.product.ProductId == productId);
                    {
                        if(cartItem != null)
                        {
                            cartItem.quantity = quantity;
                        }
                        HttpContext.Session.Set<List<CartItem>>("keyCart", cart);
                    }
                }
                return Json(new { success = true });
            }
            catch
            {
                return Json(new { success = false });
            }
        }
        [HttpPost]
        [Route("api/cart/remove")]
        public IActionResult RemoveCart(int productId)
        {
            try
            {
                List<CartItem> carts = cartItems;
                CartItem cartItem = carts.Find(x => x.product.ProductId == productId);
                if(cartItem != null)
                {
                    carts.Remove(cartItem);
                }
                HttpContext.Session.Set<List<CartItem>>("keyCart", carts);
                return Json(new { success = true });
            }
            catch
            {
                return Json(new { success = false });
            }
        }
        [Route("cart.html", Name = "Cart")]
        public IActionResult Index()
        {
            return View(cartItems);
        }
    }
}
