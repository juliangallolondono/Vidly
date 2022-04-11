using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;
using System;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context;

        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            var customers = _context.Customers.Include(x=> x.MembershipType).ToList();
            return View(customers);
        }

        public ActionResult Details(int Id)
        {
            Customer customer = _context.Customers.Include(x => x.MembershipType).ToList().SingleOrDefault(x => x.Id == Id);

            DateTime fecha = new DateTime(2022, 4, 10);
            string test = fecha.ToString("{0:d}");

            if (customer == null) return new HttpNotFoundResult();

            return View(customer);
        }
    }
}