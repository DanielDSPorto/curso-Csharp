using System;
using System.Collections.Generic;
using System.Text;

namespace section9Exam.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {

        }
        public OrderItem(int quantity, double price, string productName)
        {
            Quantity = quantity;
            Price = price;
            Product = new Product(productName, price);
        }
        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return $"{Product.Name}, ${Price}, Quantity: {Quantity}, Subtotal: ${SubTotal()}";
        }
    }
}
