using System;
using System.Collections.Generic;
using System.Globalization;
using section10example2.Entities;
using section10example2.Entities.Enum;

namespace section10example2
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Shape>();
            Console.Write("Enter the number of shapes: ");
            var amountOfShapes = int.Parse(Console.ReadLine());
            for (int i=0; i< amountOfShapes; i++)
            {
                Console.WriteLine($"Shape #{i+1} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                string shape = Console.ReadLine();
                Console.Write("Color (Black/Blue/Red): ");
                Color color = (Color)Enum.Parse(typeof(Color), Console.ReadLine());
                if (shape == "c")
                {
                    Console.Write("Radius: ");
                    var r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(r, color));
                }
                else
                {
                    Console.Write("Width: ");
                    var w = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    var h = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(w, h, color));
                }
            }
            Console.WriteLine("SHAPE AREAS:");
            foreach(var shape in list)
                Console.WriteLine(shape.Area());
            Console.ReadLine();
        }
    }
}
