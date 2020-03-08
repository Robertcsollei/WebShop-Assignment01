using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop_Assignment.Models
{
    public class Movie : Product
    {
        public string Director { get; set; }
        public short Released { get; set; }

        public Movie(string title, int price) {

            Title = title;
            Price = price;

        }
    
        public Movie(string title, decimal price, string imageURL, string director) {

            Title = title;
            Price = price;
            ImageURL = imageURL;
            Director = director;

        }
    }
}
