using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop_Assignment.Models;

namespace WebShop_Assignment.Models
{
    public class Invoice 
    {
        private decimal totalPrice;

        //Preventing duplicate values when the page refreshes
        private decimal holder;
        private int counter = 0;
        //
        private decimal caches(decimal a) {

            return holder += a ;
        }

        public int InvoiceId { set; get; }
        public DateTime OrderDate { set; get; }
        public Customer Customer { set; get; }
        public IList<OrderId> OrderItem { set; get; } = new List<OrderId>();

        public decimal TotalPrice {
            get
            {
                foreach (var item in this.OrderItem)
                {
                    this.caches(item.TotalPrice);
                }
                this.counter++;
                return this.totalPrice = holder / counter;


            }
        }

        public void AddOrderItem(Product product, int quantity)
        {
            OrderId newItem = new OrderId(product, quantity);
            OrderItem.Add(newItem);
        }

        public Invoice(int invoiceId, DateTime orderDate, Customer customer)
        {
            InvoiceId = invoiceId;
            OrderDate = orderDate;
            Customer = customer;

        }
    }
}
