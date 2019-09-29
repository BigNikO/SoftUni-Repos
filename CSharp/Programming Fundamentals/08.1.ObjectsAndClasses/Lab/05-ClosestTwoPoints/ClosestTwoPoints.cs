using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab5ClosestTwoPoints
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
    class ClosestTwoPoints
    {
        static void Main(string[] args)
        {
            int numberOfPoints = int.Parse(Console.ReadLine());
            List<Point> points = new List<Point>();
            for (int i = 0; i < numberOfPoints; i++)
            {
                Point point = ReadPoint();
                points.Add(point);
            }
            ClosestTwoPoints(points);
            
        }
        static Point ReadPoint()
        {

            double[] points = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Point point = new Point(points[0], points[1]);
            return point;
        }
        static double Distance(Point p1, Point p2)
        {
            double a = p1.X - p2.X;
            double b = p1.Y - p2.Y;
            double distance = Math.Sqrt(a * a + b * b);
            return distance;
        }
        static void ClosestTwoPoints(List<Point> points)
        {
            double minDistance = double.MaxValue;
            Point firstPoint = null;
            Point secondPoint = null;
            for (int index1 = 0; index1 < points.Count; index1++)
            {
                for (int index2 = 0; index2 < points.Count; index2++)
                {
                    if (index1 != index2)
                    {
                        double currentDistance = Distance(points[index1], points[index2]);
                        if (currentDistance < minDistance)
                        {
                            minDistance = currentDistance;
                            firstPoint = points[index1];
                            secondPoint = points[index2];
                        }
                    }
                }
            }
            Console.WriteLine($"{minDistance:f3}");
            Console.WriteLine($"({firstPoint.X}, {firstPoint.Y})");
            Console.WriteLine($"({secondPoint.X}, {secondPoint.Y})");    

        }
    }
}
