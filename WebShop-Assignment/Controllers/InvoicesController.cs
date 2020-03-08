using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebShop_Assignment.Infrastructure;

namespace WebShop_Assignment.Controllers
{
    public class InvoicesController : Controller
    {
        public IActionResult Index()
        {

            ViewBag.Invoices = repository.Invoices;
            ViewBag.count = repository.Invoices.Count;



            return View();
        }
    }
}