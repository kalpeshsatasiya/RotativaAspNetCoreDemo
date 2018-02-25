using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DemoRotativa.Models;
using Rotativa.AspNetCore;

namespace DemoRotativa.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var customers = GetCustomers();
            return new ViewAsPdf("Index", customers);
        }

        private List<Customer> GetCustomers()
        {
            return new List<Customer>()
            {
                new Customer(){ Name="Kalpesh", City="Ahmedabad"},
                new Customer(){ Name="Vijay", City="Surat"},
                new Customer(){ Name="John", City="New York"},
                new Customer(){ Name="Smith", City="Parth"},
            };
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
