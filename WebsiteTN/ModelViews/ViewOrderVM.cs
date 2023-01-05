using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebsiteTN.Models;

namespace WebsiteTN.ModelViews
{
    public class ViewOrderVM
    {
        public Order order { get; set; }
        public List<OrderDetail> orderDetails { get; set; }
    }
}
