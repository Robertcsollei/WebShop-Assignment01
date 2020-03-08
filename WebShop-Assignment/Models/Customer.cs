using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop_Assignment.Models
{
    public class Customer
    {

        private DateTime birthDate;
       
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public IList<string> PhoneNumbers = new List<string>();

        public IList<Invoice> MyInvocies = new List<Invoice>();

        public int Age(DateTime BirthDate)
        {
            return DateTime.Now.Year - BirthDate.Year;
        }
        public DateTime BirthDate
        {

            set
            {
                if (Age(value) <= 0 || Age(value) >= 120)
                {
                    throw new ArgumentException("Age must be between 0 and 120", "original");
                }else
                {
                    birthDate = value;
                }
                
            }
            get
            {
                return this.birthDate;
            }
        }


        public Customer(int customerId, string firstName, string lastName, string adress, string zip, string city)
        {
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
            Adress = adress;
            Zip = zip;
            City = city;

        }

        public void AddPhone(string phone)
        {
            PhoneNumbers.Add(phone);
        }

        public void Addinvoice(Invoice newInvoice)
        {
            MyInvocies.Add(newInvoice);
        }


    }
}
