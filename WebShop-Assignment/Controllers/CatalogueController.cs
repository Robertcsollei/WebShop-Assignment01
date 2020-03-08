using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebShop_Assignment.Infrastructure;

namespace WebShop_Assignment.Controllers
{
    public class CatalogueController : Controller
    {
        public IActionResult Index()
        {

            ViewBag.products = repository.Products;


            return View();
        }
    }
}