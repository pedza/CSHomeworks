using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.Internal;
using SEDC.PizzaApp.v1.Models.DomainModels;
using SEDC.PizzaApp.v1.Models.Enums;
using SEDC.PizzaApp.v1.Models.ViewModels;

namespace SEDC.PizzaApp.v1.Controllers
{
    public class OrderController : Controller
    {
        [HttpGet]
        public IActionResult Menu()
        {

            var menuDetail = StaticDB.Menu;



            //maping

            var menuView = new MenuViewModel()
            {
                Pizzas = menuDetail
            };
            return View(menuView);
        }

        [HttpGet]
        public IActionResult Order()
        {
            var menu = StaticDB.Menu;

            var pizzaNames = new List<string>();

            foreach (var pizza in menu)
            {
                pizzaNames.Add(pizza.Name);
            }

            var filteredPizzaNames = pizzaNames.Distinct().ToList();

            var viewModel = new MakeOrderViewModel()
            {
                PizzaName = filteredPizzaNames
            };

            return View(viewModel);

        }

        [HttpPost]
        public IActionResult Order(MakeOrderViewModel model)
        {
            var pizza = StaticDB.Menu.FirstOrDefault(x => x.Name == model.Pizzas && x.Size == model.Size);

            var lastPizzaId = StaticDB.Menu.Last().Id;


            var user = new User()
            {
                Id = lastPizzaId += 1,

                FirstName = model.FirstName,

                LastName = model.LastName,

                Address = model.Address,

                PhoneNumber = model.Phone
            };

            var lastOrderId = StaticDB.Orders.Last().Id;

            var order = new Order()
            {
               Id = lastOrderId += 1,
               IsDelivered = false,
               Price = pizza.Price + 1.5,
               User = user,
               Pizzas = new List<Pizza>() { pizza }
            };

            StaticDB.Users.Add(user);
            StaticDB.Orders.Add(order);

            return View(model);
        }

        [HttpGet]
        public IActionResult Orders()
        {
            var dbOrders = StaticDB.Orders;

            var orders = new List<OrderViewModel>();

            foreach (var order in dbOrders)
            {
                var tempOrder = new OrderViewModel()
                {
                    Id = order.Id,
                    FullName = order.User.FirstName + "" + order.User.LastName,
                    Address = order.User.Address,
                    Contact = order.User.PhoneNumber,
                    Price = order.Price,
                    IsDelivered = order.IsDelivered,
                    Pizzas = order.Pizzas

                };
                orders.Add(tempOrder);
            }

            var ordersViewModel = new OrdersViewModel()
            {
                FirstPerson = dbOrders[0].User.FirstName,
                FirstPizza = dbOrders[0].Pizzas[0].Name,
                NumberOfOrders = dbOrders.Count,
                Orders = orders

            };
            return View(ordersViewModel);
        }
        [HttpGet]
        public IActionResult Index()
        {
            ViewData.Add("Title", "OrderPizza");

            User person = new User()
            {
                FirstName = "Pedza",
                LastName = "Jons",
                Address = "ulBr",
                PhoneNumber = 13254
            };

            Pizza pizza = new Pizza()
            {
                Name = "Capri",
                Size = PizzaSize.Family,
                Price = 12.5
            };

            Order order = new Order()
            {
                Id = 10,
                User = person,
                Price = pizza.Price + 3,
                IsDelivered = true,
                Pizzas = new List<Pizza>() {pizza},

            };

            ViewData.Add("UserName", person.FirstName);

            //viewBag
            ViewBag.Greeting = "We have the best pizza";
            ViewBag.Pizza = pizza;

            return View(StaticDB.Orders[0]);
        }
        [HttpGet]
        public IActionResult Details(int? id)
        {
            var order = StaticDB.Orders.FirstOrDefault(x => x.Id == id);

            if(order == null)
            {
                return RedirectToAction("Index");
            }

            //mapping
            var orderDetail = new OrderViewModel() 
            { 
                Id = order.Id,
                FullName = order.User.FirstName + " " + order.User.LastName,
                Address = order.User.Address,
                Contact = order.User.PhoneNumber,
                Price = order.Price,
                IsDelivered = order.IsDelivered,
                Pizzas = order.Pizzas
            };
            

            return View(orderDetail);
        }
    }
}
