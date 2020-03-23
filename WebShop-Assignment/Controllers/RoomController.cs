using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebShop_Assignment.Models;

namespace WebShop_Assignment.Controllers
{
    public class RoomController : Controller
    {
        public IActionResult Index()
        {

            BreakfastOrder room101 = new BreakfastOrder();

            room101.AddBreakfastFood(new BreakfastFood { BreakfastFoodId = 1, Name = "Cornflakes", Price = 36, Selected = false});

            return View(room101);
        }
    }
}