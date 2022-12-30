using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebsiteTN.Extension;
using WebsiteTN.ModelViews;

namespace WebsiteTN.Areas.Admin.Controllers.Components
{
    public class NumberCartViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var cart = HttpContext.Session.Get<List<CartItem>>("keyCart");
            return View(cart);
        }
    }
}
