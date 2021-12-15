using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Restaurant1.Models;
using Restaurant1.ViewModel;

namespace Restaurant1.Repositories
{
    public class OrderRepository
    {
        private RestaurantDBEntities restaurantModel1;
        public OrderRepository()
        {
            restaurantModel1 = new RestaurantDBEntities();
        }

        public bool addOrder(OrderViewModel orderViewModel)
        {
            Order objOrder = new Order();
            objOrder.customerId = orderViewModel.customerId;
            objOrder.finalTotal = orderViewModel.finalTotal;
            objOrder.orderDate = DateTime.Now;
            objOrder.orderNumber = String.Format("{0:ddMMyyhhmmss}", DateTime.Now);
            objOrder.paymentTypeId = orderViewModel.paymentTypeId;

            restaurantModel1.Orders.Add(objOrder);
            restaurantModel1.SaveChanges();

            int orderId = objOrder.orderId;

            foreach(var item in orderViewModel.listOfOrderDetailsViewModel)
            {
                orderDetail orderDetail = new orderDetail();
                orderDetail.orderId = orderId;
                orderDetail.discount = item.discount;
                orderDetail.ItemId = item.itemId;
                orderDetail.total = item.total;
                orderDetail.unitPrice = item.unitPrice;
                orderDetail.quantity = item.quantity;
                restaurantModel1.orderDetails.Add(orderDetail);

                restaurantModel1.SaveChanges();

                transaction transaction = new transaction();
                transaction.itemId = item.itemId;
                transaction.quantity = -1 * item.quantity;
                transaction.transactionDate = DateTime.Now;
                transaction.typeId = 2;
                restaurantModel1.transactions.Add(transaction);

                restaurantModel1.SaveChanges();
            }

            
            return true;
        }
    }
}