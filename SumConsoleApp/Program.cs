using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumConsoleApp
{
    class Rectangle
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public double CalArea()
        {
            return length * width;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Rectangle a = new Rectangle(4, 5);
            double A1 = a.CalArea();

            Rectangle b = new Rectangle(3, 4);
            double A2 = b.CalArea();

            double totalArea = A1 + A2;
            Console.WriteLine("Total Area: " + totalArea);
            Console.ReadLine();
        }
    }
}
