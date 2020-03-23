using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop_Assignment.Models
{
    public class BreakfastOrder
    {
        [Display(Name = "Full name")]
        public string FullName { set; get; }
        [Display(Name = "Room number")]
        public int? RoomNumber { set; get; }

        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime Delivery { set; get; } = DateTime.Now;  

        public IList<BreakfastFood> BreakFastFoods { set; get; } = new List<BreakfastFood>();

        public void AddBreakfastFood(BreakfastFood food)
        {
            BreakFastFoods.Add(food);
        }


    }
}
