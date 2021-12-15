using Restaurant1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Restaurant1.Repositories
{
    public class CustomerRepository
    {
        private RestaurantDBEntities restaurantModel1;
        public CustomerRepository()
        {
            restaurantModel1 = new RestaurantDBEntities();
        }

        public IEnumerable<SelectListItem> getAllPaymentTypes()
        {
            IEnumerable<SelectListItem> objSelectListItems = new List<SelectListItem>();
            objSelectListItems = (from obj in restaurantModel1.customers.ToList()
                                  select new SelectListItem()
                                  {
                                      Text = obj.customerName,
                                      Value =obj.customerId.ToString(),
                                      Selected = true
                                  }).ToList();
            return objSelectListItems;

        }
    }
}