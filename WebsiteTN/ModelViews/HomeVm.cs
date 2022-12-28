using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebsiteTN.Models;

namespace WebsiteTN.ModelViews
{
    public class HomeVm
    {
        public List<Post> Posts { get; set; }
        public List<ProductHomeVm> Products { get; set; }
        public Advertisement advertisement { get; set; }
    }
}
