using System;
using System.Collections.Generic;
using System.Text;

namespace RectangIntersection
{
    public class Rectangle
    {
        public double LeftCornerX { get; }
        public double LeftCornerY { get; }
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double width, double height, double x, double y)
        {
            Width = width;
            Height = height;
            LeftCornerX = x;
            LeftCornerY = y;
        }

        public bool Intersection(Rectangle rectangle)
        {
            return 
                LeftCornerX + Width < rectangle.LeftCornerX ||
                rectangle.LeftCornerX + rectangle.Width < LeftCornerX ||
                LeftCornerY  + Height < rectangle.LeftCornerY ||
                rectangle.LeftCornerX + rectangle.Height < LeftCornerY;
        }
    }
}
