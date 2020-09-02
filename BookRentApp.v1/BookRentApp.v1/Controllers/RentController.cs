using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BookRentApp.v1.Controllers
{
    public class RentController : Controller
    {
        public IActionResult Index()
        {
            return View(StaticDB.Rentals[0]);
        }
    }
}
