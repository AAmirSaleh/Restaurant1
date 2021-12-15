using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Restaurant1.Repositories;
using Restaurant1.Models;
using Restaurant1.ViewModel;

namespace Restaurant1.Controllers
{
    public class HomeController : Controller
    {
        private RestaurantDBEntities restaurantModel1;
        public HomeController()
        {
            restaurantModel1 = new RestaurantDBEntities();
        }
        public ActionResult Index()
        {
            CustomerRepository objCustomerRepository = new CustomerRepository();
            ItemRepository objItemRepository = new ItemRepository();
            PaymentTypeRepository objPaymentTypeRepository = new PaymentTypeRepository();

            var objMultipleModels = new Tuple<IEnumerable<SelectListItem>, IEnumerable<SelectListItem>, IEnumerable<SelectListItem>>
                (objCustomerRepository.getAllPaymentTypes(), objItemRepository.getAllItems(), objPaymentTypeRepository.getAllPaymentTypes());
            
                return View(objMultipleModels);
        }

        [HttpGet]
        public JsonResult getItemUnitPrice(int itemId)
        {
            decimal unitPrice = (decimal)restaurantModel1.items.Single(model => model.itemId == itemId).itemPrice;
            return Json(unitPrice, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult index(OrderViewModel orderViewModel)
        {
            OrderRepository orderRepository = new OrderRepository();
            orderRepository.addOrder(orderViewModel);

            return Json("Order has been Successfully Placed.", JsonRequestBehavior.AllowGet);
        }

    }
}