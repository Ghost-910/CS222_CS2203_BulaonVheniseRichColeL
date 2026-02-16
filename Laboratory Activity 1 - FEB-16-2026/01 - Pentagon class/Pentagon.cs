using System;

namespace PentagonApp
{
    class Pentagon
    {
        
        private double side;

        public Pentagon()
        {
            side = 0;
        }

        public Pentagon(double sideLength)
        {
            side = sideLength;
        }

        public double GetPerimeter()
        {
            return 5 * side;
        }

        public double GetArea()
        {
            return (Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * Math.Pow(side, 2)) / 4;
        }

        public void Display(string name)
        {
            Console.WriteLine($"Pentagon {name}");
            Console.WriteLine("------------------------");
            Console.WriteLine($"Side length: {side}");
            Console.WriteLine($"Perimeter: {GetPerimeter():F3}");
            Console.WriteLine($"Area: {GetArea():F3}");
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pentagon p1 = new Pentagon();
            p1.Display("p1");

            Pentagon p2 = new Pentagon(5);
            p2.Display("p2");

            Console.ReadLine();
        }
    }
}