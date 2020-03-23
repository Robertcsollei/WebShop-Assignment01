using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebShop_Assignment.Infrastructure;
using WebShop_Assignment.Models;

namespace WebShop_Assignment.Controllers
{
    public class InvoicesController : Controller
    {

        public List<SelectListItem> customers = new List<SelectListItem>();

        public IActionResult Index()
        {


            foreach(Invoice invoice in repository.Invoices){
                customers.Add(new SelectListItem {
                    Text = invoice.Customer.FirstName + " " + invoice.Customer.LastName, 
                    Value = invoice.Customer.CustomerId.ToString() });
            };


            customers = customers.GroupBy(x => x.Value).Select(y => y.First()).OrderBy(z => z.Text).ToList<SelectListItem>();



            ViewData["Customers"] = customers;
            ViewBag.Invoices = null;
            ViewBag.count = null;

            return View();
    }

        [HttpPost]
        public IActionResult Index(int? customer) {

            if (customer != null)
            {
                List<Invoice> invoices = repository.Invoices.Where(r => r.Customer.CustomerId== customer).ToList();
                foreach (Invoice invoice in repository.Invoices)
                {
                    if (invoice.Customer.CustomerId == customer)
                    {
                        customers.Add(new SelectListItem
                        {
                            Text = invoice.Customer.FirstName + " " + invoice.Customer.LastName,
                            Value = invoice.Customer.CustomerId.ToString(),
                            Selected = true,
                        });
                    }
                    else {
                        customers.Add(new SelectListItem
                        {
                            Text = invoice.Customer.FirstName + " " + invoice.Customer.LastName,
                            Value = invoice.Customer.CustomerId.ToString()
                        });
                    }
                };
                ViewBag.Invoices = invoices;
            }       

           
            ViewBag.count = repository.Invoices.Count;
            ViewData["Customers"] = customers;
            return View();
        }

    }
}