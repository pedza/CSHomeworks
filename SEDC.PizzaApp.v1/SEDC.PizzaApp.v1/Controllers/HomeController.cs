using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace SEDC.PizzaApp.v1.Controllers
{
    //[Route("App/[Action]")] //default route
    //[Route("App")]
    public class HomeController : Controller
    {
        public IConfiguration Configuration { get; }

        public HomeController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        [HttpGet]
        //[Route("Start")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        //[HttpGet("CallMe")]
        [HttpGet]
        public IActionResult About()
        {
            return View();
        }

        //view result
        public IActionResult Test()
        {
            return View("Contact");
        }

        //empty result

        public IActionResult Alert()
        {
            return new EmptyResult();
        }

        //redirect result

        public IActionResult Order(int? id)
        {
            if (id.HasValue)
            {
                return View("Contact");
            }

            return new RedirectResult("Index");
        }

        //json result
        public IActionResult OrderData()
        {
            var order = new { Id = 12, Delivery = false };
            

            return new JsonResult(order);
        }

        //retrieve data from app setting.json
        public IActionResult Email()
        {
            var contactEmail = Configuration.GetSection
                ("emailAddress").GetValue<string>("email1");
            var customerSupport = Configuration.GetSection
                ("emailAddress").GetValue<string>("email2");

            var emails = new { email1 = contactEmail, email2=customerSupport };

            return new JsonResult(emails);
        }
    }
}
