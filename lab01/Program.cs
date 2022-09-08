using System;
using lab01Lib;

namespace lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1
            Console.WriteLine($"min from byte: {byte.MinValue}, max from byte: {byte.MaxValue}");
            Console.WriteLine($"min from sbyte: {sbyte.MinValue}, max from sbyte: {sbyte.MaxValue}");
            Console.WriteLine($"min from short: {short.MinValue}, max from short: {short.MaxValue}");
            Console.WriteLine($"min from int: {int.MinValue}, max from int: {int.MaxValue}");
            Console.WriteLine($"min from long: {long.MinValue}, max from long: {long.MaxValue}");
            Console.WriteLine($"min from ushort: {ushort.MinValue}, max from ushort: {ushort.MaxValue}");
            Console.WriteLine($"min from uint: {uint.MinValue}, max from uint: {uint.MaxValue}");
            Console.WriteLine($"min from ulong: {ulong.MinValue}, max from ulong: {ulong.MaxValue}");
            Console.WriteLine($"min from float: {float.MinValue}, max from float: {float.MaxValue}");
            Console.WriteLine($"min from double: {double.MinValue}, max from double: {double.MaxValue}");
            Console.WriteLine($"min from char: {char.MinValue}, max from char: {char.MaxValue}");

            //Task2
            double side1;
            side1 = Convert.ToDouble(Console.ReadLine());
            double side2;
            side2 = Convert.ToDouble(Console.ReadLine());
            Rectangle rectangle;
            rectangle = new(side1, side2);

            Console.WriteLine($"Perimeter: {rectangle.Perimeter}");
            Console.WriteLine($"Area: {rectangle.Area}");

            //Task3
            Point p1 = new(0, 3);
            Point p2 = new(4, 0);
            Point p3 = new(0, 0);

            Figure fig1 = new(p1, p2, p3);
            Console.WriteLine($"Figure is {fig1.GetName}, his Perimetr is {fig1.GetPerimeter}");
        }
    }
}


