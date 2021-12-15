using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Restaurant1.Models;

namespace Restaurant1.Repositories
{
    
    public class PaymentTypeRepository
    {
        private RestaurantDBEntities restaurantModel1;
        public PaymentTypeRepository()
        {
            restaurantModel1 = new RestaurantDBEntities();
        }

        public IEnumerable<SelectListItem> getAllPaymentTypes() {
            IEnumerable<SelectListItem> objSelectListItems = new List<SelectListItem>();
            objSelectListItems = (from obj in restaurantModel1.PaymentTypes.ToList()
                                  select new SelectListItem
                                  {
                                      Text = obj.PaymentTypeName,
                                      Value = obj.PaymentTypeId.ToString(),
                                      Selected = true
                                  }).ToList();
            return objSelectListItems;

        }
        
    }
}