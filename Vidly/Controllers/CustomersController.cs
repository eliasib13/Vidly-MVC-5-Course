using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private readonly List<Customer> _customers = new List<Customer>
        {
            new Customer {Name = "Vincent Vega", Id = 1},
            new Customer {Name = "John Smith", Id = 2}
        };
        // GET: Customers
        public ActionResult Index()
        {
            var customers = new CustomerViewModel
            {
                Customers = _customers,
                ViewHeader = "Customers"
            };

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = _customers.SingleOrDefault(x => x.Id == id);

            if (customer == null)
            {
                return HttpNotFound();
            }

            return View(customer);
        }
    }
}