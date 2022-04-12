using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PizzaPointApplication.Models;
using PizzaPointApplication.Models.Component;
using PizzaPointApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPointApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IOrder _order;
       

        public HomeController(ILogger<HomeController> logger,IOrder order)
        {
            _logger = logger;
            _order = order;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(PizzaAndToppingInputFromCustomer pizzaAndToppingInputFromCustomer)
        {
            AbstractPizza pizzaTypeOrdered, toppingTypeOrdered;
            try 
            { 
                pizzaTypeOrdered = _order.GetPizzaType(pizzaAndToppingInputFromCustomer.pizzaType);
                toppingTypeOrdered = _order.GetToppingOptedByUser(pizzaAndToppingInputFromCustomer.toppingType, pizzaTypeOrdered);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return RedirectToAction("Error");
            }
            

            var overallOrderDetails = new OrderedPizzaWithTopping
            {
                Description = toppingTypeOrdered.GetDescription(),
                Price = toppingTypeOrdered.GetPrice()
            };
            return View("Display",overallOrderDetails);
        }

        [HttpGet]
        public IActionResult Topping()
        {
            return View();
        }

        /*[HttpPost]
        public IActionResult Topping(ToppingInputTypeFromCustomer toppingInputTypeFromCustomer)
        {
            Console.WriteLine(pizzaTypeOrdered.GetDescription());
            toppingTypeOrdered = _order.GetToppingOptedByUser(toppingInputTypeFromCustomer.toppingType,pizzaTypeOrdered);
            return RedirectToAction("Display");
        }

        [HttpGet]
        public IActionResult Display()
        {
            var overallOrderDetails = new OrderedPizzaWithTopping
            {
                Description = toppingTypeOrdered.GetDescription(),
                Price = toppingTypeOrdered.GetPrice()
            };
            return View(overallOrderDetails);
        }
*/
        /*
        public IActionResult Privacy()
        {
            return View();
        }*/

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
