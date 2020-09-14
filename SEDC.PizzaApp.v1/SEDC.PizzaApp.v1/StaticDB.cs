using Microsoft.IdentityModel.Tokens;
using SEDC.PizzaApp.v1.Models.DomainModels;
using SEDC.PizzaApp.v1.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.v1
{
    public static class StaticDB
    {
        public static List<User> Users { get; set; }

        public static List<Order> Orders { get; set; }

        public static List<Pizza> Menu { get; set; }

        static StaticDB()
        {
            //users
            Users = new List<User>()
            {
                new User()
                {
                    Id = 1,
                    FirstName="Vesna",
                    LastName = "Janevska",
                    Address = "usBr",
                    PhoneNumber = 123476

                },

                new User()
                {
                    Id = 2,
                    FirstName = "Pedza",
                    LastName = "Janevski",
                    Address = "usBr",
                    PhoneNumber = 15468

                }
            };
            //menu
            Menu = new List<Pizza>()
            {
                new Pizza()
                {
                    Id=1,
                    Name="Kapri",
                    Price = 9.50,
                    Size = PizzaSize.Medium
                },

                new Pizza()
                {
                    Id=2,
                    Name="Kapri",
                    Price = 11.50,
                    Size = PizzaSize.Large
                },

                 new Pizza()
                 {
                    Id=3,
                    Name="Kapri",
                    Price = 9.50,
                    Size = PizzaSize.Family
                 },
                 new Pizza()
                 {
                    Id=4,
                    Name="Peperoni",
                    Price = 8.50,
                    Size = PizzaSize.Medium
                 },
                 new Pizza()
                 {
                    Id=5,
                    Name="Peperoni",
                    Price = 10.50,
                    Size = PizzaSize.Large
                 },
                 new Pizza()
                 {
                    Id=6,
                    Name="Peperoni",
                    Price = 15.50,
                    Size = PizzaSize.Family
                 },
                 new Pizza()
                 {
                    Id=7,
                    Name="Margarita",
                    Price = 7.50,
                    Size = PizzaSize.Medium
                 },
                 new Pizza()
                 {
                    Id=8,
                    Name="Margarita",
                    Price = 11.50,
                    Size = PizzaSize.Large
                 },
                 new Pizza()
                 {
                    Id=9,
                    Name="Margarita",
                    Price = 14.50,
                    Size = PizzaSize.Family
                 },
                 new Pizza()
                 {
                    Id=10,
                    Name="Siciliana",
                    Price = 8.50,
                    Size = PizzaSize.Medium
                 },
                 new Pizza()
                 {
                    Id=11,
                    Name="Siciliana",
                    Price = 10.00,
                    Size = PizzaSize.Large
                 },
                 new Pizza()
                 {
                    Id=12,
                    Name="Siciliana",
                    Price = 12.50,
                    Size = PizzaSize.Family
                 }
            };

            //orders

            Orders = new List<Order>();
            var order1 = new Order()
            {
                Id = 1,
                User = Users[0],
                Pizzas = new List<Pizza>()
                {
                    Menu[0],
                    Menu[2],
                    Menu[4]
                },
                IsDelivered = true
            };

            Orders = new List<Order>();
            var order2 = new Order()
            {
                Id = 2,
                User = Users[1],
                Pizzas = new List<Pizza>()
                {
                    Menu[1],
                    Menu[3],
                    Menu[4],
                    Menu[4]
                },
                IsDelivered = true
            };
            var order3 = new Order()
            {
                Id = 3,
                User = Users[1],
                Pizzas = new List<Pizza>()
                {
                    Menu[5],
                    Menu[4]
                },
                IsDelivered = true
            };

            order1.Price = PriceCalculator(order1.Pizzas);
            order2.Price = PriceCalculator(order1.Pizzas);
            order3.Price = PriceCalculator(order1.Pizzas);
            Orders.Add(order1);
            Orders.Add(order2);
            Orders.Add(order3);

        }

        private static double PriceCalculator(List<Pizza> pizzas)
        {
            //1.5 is delivery expense
            var sum = 1.5;
            foreach (var pizza in pizzas)
            {
                sum += pizza.Price;
            }
            return sum;
        }
    }
}
