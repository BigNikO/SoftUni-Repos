using System;
using System.Collections.Generic;
using System.Linq;

namespace RectangIntersection
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int numberOfRectangles = int.Parse(input[0]);
            int numberOfCompares = int.Parse(input[1]);
            Dictionary<string, Rectangle> rectangles = new Dictionary<string, Rectangle>();

            for (int i = 0; i < numberOfRectangles; i++)
            {
                string[] rectangleInfo = Console.ReadLine().Split();

                Rectangle rectangle = new Rectangle(double.Parse(rectangleInfo[1]),
                    double.Parse(rectangleInfo[2]), double.Parse(rectangleInfo[3]), double.Parse(rectangleInfo[4]));
                rectangles[rectangleInfo[0]] = rectangle;
            }

            for (int i = 0; i < numberOfCompares; i++)
            {
                string[] compareIds = Console.ReadLine().Split();
                Rectangle firstRect = rectangles[compareIds[0]];
                Rectangle secondRect = rectangles[compareIds[1]];
                Console.WriteLine((!firstRect.Intersection(secondRect)).ToString().ToLower());
            }
        }
    }
}
