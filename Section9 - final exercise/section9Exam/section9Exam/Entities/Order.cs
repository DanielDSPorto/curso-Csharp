using System;
using System.Collections.Generic;
using System.Text;
using section9Exam.Entities.Enum;

namespace section9Exam.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Customer { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public void AddItem(OrderItem orderItem)
        {
            OrderItems.Add(orderItem);
        }
        public void RemoveItem(OrderItem orderItem)
        {
            OrderItems.Remove(orderItem);
        }
        public double Total()
        {
            var totalValue = 0.0;
            foreach (OrderItem item in OrderItems)
                totalValue += item.SubTotal();
            return totalValue;
        }
        public Order()
        {

        }
        public Order(OrderStatus status, Client customer)
        {
            Moment = DateTime.Now;
            Status = status;
            Customer = customer;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"ORDER SUMMARY:\nOrder moment: {Moment}\nOrder status: {Status}\n{Customer.ToString()}\nOrder items:\n");
            foreach (OrderItem o in OrderItems)
                sb.AppendLine(o.ToString());
            sb.Append($"Total price: ${Total()}");
            return sb.ToString();
            
        }
    }
}
