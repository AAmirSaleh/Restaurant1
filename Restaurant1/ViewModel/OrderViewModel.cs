using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Restaurant1.ViewModel
{
    public class OrderViewModel
    {
        public int orderId { get; set; }
        public int paymentTypeId { get; set; }
        public int  customerId { get; set; }
        public string orderNumber { get; set; }
        public DateTime orderDate { get; set; }
        public decimal finalTotal { get; set; }

        public IEnumerable<OrderDetailsViewModel> listOfOrderDetailsViewModel { get; set; }

    }
}