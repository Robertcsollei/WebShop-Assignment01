﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebShop_Assignment.Models
{
    public class Book : Product
    {
        public string Author { set; get; }
        public string Publisher { set; get; }
        public short Published { set; get; }
        public string ISBN { set; get; }


        public Book(string author, string title, decimal price, short published) : base(title, price)
        {

            Author = author;
            Published = published;

        
        }


    }
}
