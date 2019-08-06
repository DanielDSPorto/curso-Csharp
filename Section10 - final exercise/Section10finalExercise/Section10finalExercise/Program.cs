using System;
using System.Collections.Generic;
using System.Globalization;
using Section10finalExercise.Entities;

namespace Section10finalExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<TaxPayer>();
            Console.Write("Enter the number of tax payers: ");
            var numberOfTaxPayers = int.Parse(Console.ReadLine());
            for (var i=0; i<numberOfTaxPayers; i++)
            {
                Console.WriteLine($"Tax payer #{i+1} data:");
                Console.Write("Individual or company (i/c)? ");
                var ch = Console.ReadLine();
                Console.Write("Name: ");
                var name = Console.ReadLine();
                Console.Write("Anual income: ");
                var aI = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(ch == "i")
                {
                    Console.Write("Health Expenditures: ");
                    var hE = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, aI, hE));
                }
                else
                {
                    Console.Write("Number of Employees: ");
                    var nOE = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Company(name, aI, nOE));
                }
            }
            Console.WriteLine("TAXES PAID: ");
            var accumulatedValue = 0.0;

            foreach (var taxpayer in list)
            {
                accumulatedValue += taxpayer.Tax();
                Console.WriteLine(taxpayer.ToString());
            }
            Console.WriteLine($"\nTOTAL TAXES: $ {accumulatedValue}");
            Console.ReadLine();
        }
    }
}
