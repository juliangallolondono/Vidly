using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        List<Customer> customers = new List<Customer>();
            //{
            //    new Customer() { Name = "Julian Gallo" , Id=1},
            //    new Customer() { Name = "Tatiana Berrio" , Id = 2}
            //};
        // GET: Customers
        public ActionResult Index()
        {
            
            return View(customers);
        }

        public ActionResult Details(int Id)
        {
            Customer customer = customers.Find(x => x.Id == Id);

            if (customer == null) return new HttpNotFoundResult();

            return View(customer);
        }
    }
}