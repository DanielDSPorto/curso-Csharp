using System;
using System.Globalization;
using section9Exam.Entities;
using section9Exam.Entities.Enum;

namespace section9Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter client data:");
            Console.Write("Name : ");
            var name = Console.ReadLine();
            Console.Write("Email: ");
            var email = Console.ReadLine();
            Console.Write("Birth date (dd/mm/yyyy): ");
            var birthDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            var client = new Client(name,email,birthDate);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Okay, now I need you to enter some information on his/her order");
            Console.Write("Order Status (PendingPayment / Processing / Shipped / Delivered): ");
            var status = (OrderStatus) Enum.Parse(typeof(OrderStatus),Console.ReadLine());
            var order = new Order(status, client);
            Console.Write("How many different items are there in this order ? : ");
            var items = int.Parse(Console.ReadLine());
            for (int i=1; i<= items; i++)
            {
                Console.WriteLine($"Enter #{i} data : ");
                Console.Write("Product Name : ");
                name = Console.ReadLine();
                Console.Write("Product price : ");
                var price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write($"And how many of {name} would you like to add to the order ? : " );
                var amount = int.Parse(Console.ReadLine());
                order.AddItem(new OrderItem(amount, price, name));
            }
            Console.WriteLine("\n");
            Console.WriteLine(order.ToString());
            Console.ReadLine();
        }
    }
}