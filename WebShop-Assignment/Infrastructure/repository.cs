using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop_Assignment.Models;


namespace WebShop_Assignment.Infrastructure
{
    public static class repository
    {

        public static IList<Product> Products { get; } = new List<Product>();
        public static IList<Invoice> Invoices { get; } = new List<Invoice>();




        static repository()
        {

            TimeSpan time = new TimeSpan(5, 15, 15);
            DateTime randomDate = new DateTime(2019, 12, 31);

            MusicCD John = new MusicCD("System of a down", "Mezmerize", 15, 123);
            John.AddTrack("Question", "Daron Malakian", time);
            John.AddTrack("B.Y.O.B.", "Daron Malakian", time);
            John.AddTrack("Violent Pornography", "Daron Malakian", time);
            John.AddTrack("Lost in Hollywood", "Daron Malakian", time);
            
            Book OnTheRoad = new Book("Jack Kerouac", "On The Road", 15M, 1957);
            Book BladeRunner = new Book("Philip K. Dick", "Do Androids Dream Of Electric Sheep", 15M, 1968);

            Movie Annihilation = new Movie("Annihilation", 20, "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcS1RJJUBGRZFEzfSmdG4biDlXDAhsrpvgwLWkO-wSIfyePuZJAj", "Alex Garland");

            John.ImageURL = "https://i.pinimg.com/originals/81/6a/8f/816a8f315b46181231d4f42524322a5f.jpg";

            OnTheRoad.ImageURL = "https://i.pinimg.com/originals/92/b6/c0/92b6c06203fedad753fdebefa2c62624.jpg";
            BladeRunner.ImageURL = "https://pictures.abebooks.com/BIBLIOSOPHER/22778546150.jpg";

            Products.Add(John);
            Products.Add(OnTheRoad);
            Products.Add(BladeRunner);
            Products.Add(Annihilation);

            Customer Neo = new Customer(1, "Neo", "The One", "Chicago", "0000", "Zion" );
            Customer Shephard = new Customer(1, "John", "Sephard", "Mindoir", "999999", "N7" );

            OrderId newMusic = new OrderId(John, 22);
            OrderId newBook = new OrderId(OnTheRoad, 4);
            OrderId newBookTwo = new OrderId(BladeRunner, 6);
            OrderId newMovie = new OrderId(Annihilation, 2);

            OrderId otherBook = new OrderId(BladeRunner, 1);
            OrderId otherMovie = new OrderId(Annihilation, 4);

            Invoice newInvoice = new Invoice(1, randomDate , Neo );
            newInvoice.AddOrderItem(newMusic.Product, newMusic.Quantity);
            newInvoice.AddOrderItem(newBook.Product, newBook.Quantity);
            newInvoice.AddOrderItem(newBookTwo.Product, newBookTwo.Quantity);
            newInvoice.AddOrderItem(newMovie.Product, newMovie.Quantity);

            Invoice otherInvoice = new Invoice(2, randomDate, Shephard);
            otherInvoice.AddOrderItem(otherBook.Product, otherBook.Quantity);
            otherInvoice.AddOrderItem(otherMovie.Product, otherMovie.Quantity);



            Invoices.Add(newInvoice);
            Invoices.Add(otherInvoice);

        }

    }
}
