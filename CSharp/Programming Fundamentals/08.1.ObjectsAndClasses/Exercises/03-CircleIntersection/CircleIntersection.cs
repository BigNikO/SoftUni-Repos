using System;
using System.Linq;

namespace Ex3CircleIntersection
{
    class Circle
    {
        public double Radius { get; set; }
        public Point Center { get; set; }
    }
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
    class CircleIntersection
    {
        static void Main(string[] args)
        {
            double[] circleData = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Point centerOne = ReadCenter(circleData[0],circleData[1]);
            circleData = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Point centerTwo = ReadCenter(circleData[0], circleData[1]);
            double radiusOne = circleData[2];
            double radiusTwo = circleData[2];
            Circle circleOne = ReadCircle(centerOne, radiusOne);
            Circle circleTwo = ReadCircle(centerTwo, radiusTwo);
            if (Intersect(circleOne,circleTwo))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
        static double CalculateDistance(Point centerOne, Point centerTwo)
        {
            double deltaX = centerOne.X - centerTwo.X;
            double deltaY = centerTwo.Y - centerOne.Y;
            double distance = Math.Sqrt(deltaX*deltaX+deltaY*deltaY);
            return distance;

        }
        static Point ReadCenter(double x,double y)
        {
            Point center = new Point();
            center.X = x;
            center.Y = y;
            return center;
        }
        static Circle ReadCircle(Point center, double radius)
        {
            Circle circle = new Circle();
            circle.Radius = radius;
            circle.Center = center;
            return circle;
        }
        static bool Intersect(Circle circleOne, Circle circleTwo)
        {
            bool check = false;
            double distance = CalculateDistance(circleOne.Center, circleTwo.Center);
            if (distance <= circleOne.Radius+circleTwo.Radius)
            {
                check = true;
            }
            return check;
        }
    }
}
