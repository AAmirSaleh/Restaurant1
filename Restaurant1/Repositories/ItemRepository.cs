using Restaurant1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restaurant1.Repositories
{
    public class ItemRepository
    {
        private RestaurantDBEntities restaurantModel1;
        public ItemRepository()
        {
            restaurantModel1 = new RestaurantDBEntities();
        }

        public IEnumerable<SelectListItem> getAllItems()
        {
            IEnumerable<SelectListItem> objSelectListItems = new List<SelectListItem>();
            objSelectListItems = (from obj in restaurantModel1.items.ToList()
                                  select new SelectListItem
                                  {
                                      Text = obj.itemName,
                                      Value = obj.itemId.ToString(),
                                      Selected = false
                                  }).ToList();
            return objSelectListItems;

        }
    }
}