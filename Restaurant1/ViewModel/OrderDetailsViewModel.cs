using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Restaurant1.ViewModel
{
    public class OrderDetailsViewModel
    {
        public int orderDetailId { get; set; }
        public int itemId { get; set; }
        public decimal unitPrice { get; set; }
        public decimal quantity { get; set; }
        public decimal discount { get; set; }
        public decimal total { get; set; }

    }
}