using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookRentApp.v1.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BookRentApp.v1.Controllers
{
    public class RentController : Controller
    {
        public IActionResult Index()
        {
            return View(StaticDB.Rentals[0]);
        }

        public IActionResult Library()
        {
            var dbBooks = StaticDB.Library;

            var libraryView = new LibraryViewModel()
            {
                Books = dbBooks
            };

            return View(libraryView);
        }




    }
}
