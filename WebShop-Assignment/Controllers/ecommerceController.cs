using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebShop_Assignment.Models;
using WebShop_Assignment.Infrastructure;

namespace WebShop_Assignment.Controllers
{
    public class ecommerceController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
    }
}