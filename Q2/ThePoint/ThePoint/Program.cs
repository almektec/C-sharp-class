using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePoint
{
    public class Point
    {
        public int X { get; } = 0;
        public int Y { get; } = 0;

        public Point(int x, int y)

        {
            X = x;
            Y = y;
        }

        public Point()
        {
            X = 0;
            Y = 0;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(2, 3);
            Point q = new Point (-4, 0);

            

            Console.WriteLine($"P: {p.ToString()}");
            Console.WriteLine($"P: {q.ToString()}");

            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
        }
    }
}
