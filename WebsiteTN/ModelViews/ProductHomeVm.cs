using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebsiteTN.Models;

namespace WebsiteTN.ModelViews
{
    public class ProductHomeVm
    {
        public Category category { get; set; }
        public List<Product> Products { get; set; }
    }
}
