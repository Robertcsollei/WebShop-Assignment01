using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop_Assignment.Models
{
    public class track 
    {
        public TimeSpan Length { set;  get; }
        public string Title { set; get; }
        public string Composer { set;  get; }




        public track(string title, string composer, TimeSpan length) {

            Title = title;
            Composer = composer;
            Length = length;

        }
    }
}
