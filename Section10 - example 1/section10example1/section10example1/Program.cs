using System;
using section10example1.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace section10example1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the number of employees: ");
            int numberEmployees = int.Parse(Console.ReadLine());
            List<Employee> list = new List<Employee>();
            for(int i=0; i< numberEmployees; i++)
            {
                Console.WriteLine($"Employee #{i+1}");
                Console.Write("Is he an outsourced employee? (y/n): ");
                string outsourced = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double vph = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(outsourced == "y")
                {
                    Console.Write("Additional charge: ");
                    double ac = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, vph, ac));
                } 
                else
                {
                    list.Add(new Employee(name, hours, vph));
                }
            }
            Console.WriteLine("\nPAYMENTS:");
            foreach (var emp in list)
                Console.WriteLine(emp.ToString());
            Console.ReadLine();
        }
    }
}