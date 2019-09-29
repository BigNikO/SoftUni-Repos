using System;
using System.Linq;

namespace Lab6RectAnglePosition
{
    class Rectangle
    {
        public int Top { get; set; }
        public int Left { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Bottom
        {
            get
            {
                return Top + Height;
            }
        }
        public int Right
        {
            get
            {
                return Left + Width;
            }
        }
        public bool IsInside(Rectangle r)
        {
            return (r.Left <= Left) && (r.Right >= Right) && (r.Top <= Top) && (r.Bottom >= Bottom);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle firstRectangle = ReadRect();
            Rectangle secondRectangle = ReadRect();
            if (firstRectangle.IsInside(secondRectangle))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }
        static Rectangle ReadRect()
        {
            Rectangle resultRect = new Rectangle();
            int[] recangle = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int left = recangle[0];
            int top = recangle[1];
            int width = recangle[2];
            int heigth = recangle[3];
            resultRect.Left = left;
            resultRect.Top = top;
            resultRect.Width = width;
            resultRect.Height = heigth;
            return resultRect;
        }
    }
}
