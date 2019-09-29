using System;
using System.Linq;

namespace Lab4DistanceBetweenTwoPoints
{
    class Point
    {
        public Double X;
        public Double Y;
        public Point(double X, double Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }
    class DistanceBetweenTwoPoints
    {

    
        static void Main(string[] args)
        {
            Point point1 = ReadPoint();
            Point point2 = ReadPoint();
            Distance(point1,point2);
        }
        static Point ReadPoint()
        {
            
            double[] points = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Point point = new Point(points[0],points[1]);
            return point;
        }
        static void Distance(Point p1, Point p2)
        {
            double a = p1.X - p2.X;
            double b = p1.Y - p2.Y;
            double distance = Math.Sqrt(a * a + b * b);
            Console.WriteLine($"{distance:F3}");
        }
    }

    
}
