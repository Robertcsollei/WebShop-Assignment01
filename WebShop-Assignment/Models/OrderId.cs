using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop_Assignment.Models
{
    public class OrderId
    {
        


        public int OrderItemId { get; set; }
        public int ProductId{ get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; }

        public OrderId(Product product, int quantity)
        {
            Product = product;
            
            Quantity = quantity;
            TotalPrice = product.Price * quantity;
        }

    }
}
