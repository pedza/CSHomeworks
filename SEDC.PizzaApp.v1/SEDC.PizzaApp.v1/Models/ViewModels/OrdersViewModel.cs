using SEDC.PizzaApp.v1.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.v1.Models.ViewModels
{
    public class OrdersViewModel
    {
        public string FirstPerson { get; set; }
        public string FirstPizza { get; set; }
        public int NumberOfOrders { get; set; }
        public List<OrderViewModel> Orders { get; set; }
    }
}
