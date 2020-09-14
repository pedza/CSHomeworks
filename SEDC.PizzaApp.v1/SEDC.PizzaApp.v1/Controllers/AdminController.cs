using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Scaffolding;
using Microsoft.Web.Helpers;
using Remotion.Linq.Parsing.Structure.IntermediateModel;
using SEDC.PizzaApp.v1.Models.DomainModels;
using SEDC.PizzaApp.v1.Models.ViewModels;

namespace SEDC.PizzaApp.v1.Controllers
{
    public class AdminController : Controller
    {
        [HttpGet]
        public IActionResult Entries()
        {

            var viewModel = new MakeEntryViewModel()
            {

            };

            return View(viewModel);
        }
        [HttpPost]
        public IActionResult Entries(MakeEntryViewModel model)
        {

            var path = "C:/Users/Pedza/source/repos/SEDC.PizzaApp.v1/SEDC.PizzaApp.v1/wwwroot/img/pizza/";

            var menu = StaticDB.Menu;

            var pizzaNames = new List<string>();

            foreach (var pizza in menu)
            {
                pizzaNames.Add(pizza.Name);
            }

            var filteredPizzaNames = pizzaNames.Distinct().ToList();

            foreach (var pizza in filteredPizzaNames)
            {
                if(pizza == model.PizzaName)
                {
                   
                    return View("_Error");
                }
                else
                {
                    var lastPizzaId = StaticDB.Menu.Last().Id;

                    var pizzaModel = new Pizza()
                    {
                        Id = lastPizzaId + 1,
                        Name = model.PizzaName,
                        Price = model.Price,
                        Size = model.Size
                     };

                    StaticDB.Menu.Add(pizzaModel);

                   
                    return View("_AddedPizza");
                }
            }

           

                return new EmptyResult();
            
        }

    }
}
