using System;
using System.Globalization;
using System.Collections.Generic;
using ShapeAreas.Entities;
using ShapeAreas.Entities.Enums;

namespace ShapeAreas
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            char shape;
            double width, height, radius;
            Color color;
            List<Shape> shapeList = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Shape #{i+1} data: ");
                Console.Write("Reactangle or Circle (r/c)? ");
                shape = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                color = Enum.Parse<Color>(Console.ReadLine());
                if(shape == 'r' || shape == 'R')
                {
                    Console.Write("Width: ");
                    width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapeList.Add(new Reactangle(color, width, height));
                }
                else
                {
                    Console.Write("Radius: ");
                    radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapeList.Add(new Circle(color, radius));
                }
            }
            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS: ");
            foreach(Shape s in shapeList)
            {
                Console.WriteLine(s.Area().ToString("f2", CultureInfo.InvariantCulture));
            }
        }
    }
}
