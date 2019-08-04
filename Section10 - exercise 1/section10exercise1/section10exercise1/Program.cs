using System;
using System.Collections.Generic;
using section10exercise1.Entities;
using System.Globalization;

namespace section10exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Product>();
            Console.Write("Enter the number of products: ");
            var number = int.Parse(Console.ReadLine());
            for (var i=0; i<number; i++)
            {
                Console.WriteLine($"Product #{i+1} data :");
                Console.Write("Common, used or imported (c/u/i)? ");
                string option = Console.ReadLine();
                Console.Write("Name: ");
                var name = Console.ReadLine();
                Console.Write("Price: ");
                var price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                switch (option)
                {
                    case "u":
                        Console.Write("Manufacture date (DD/MM/YYYY): ");
                        var Date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        list.Add(new UsedProduct(name, price, Date));
                        break;
                    case "i":
                        Console.Write("Customs fee: ");
                        var cf = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        list.Add(new ImportedProduct(name, price, cf));
                        break;
                    default:
                        list.Add(new Product(name, price));
                        break;
                }
            }
            Console.WriteLine("PRICE TAGS:");
            foreach (var product in list)
            {
                Console.WriteLine(product.PriceTag());
            }
            Console.ReadLine();
        }
    }
}