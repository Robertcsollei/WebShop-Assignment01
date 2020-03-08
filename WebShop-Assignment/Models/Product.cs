using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop_Assignment.Models
{
    public class Product
    {


        public int ProductId { get; }
        public string Title { set;  get; }
        public decimal Price { set; get; }
        public string ImageURL { set; get; }
        public DateTime BirthDay { set; get; }




        public Product() { }
        public Product( string title, decimal price){
           
            Title = title;
            Price = price;
        }

    }
}
