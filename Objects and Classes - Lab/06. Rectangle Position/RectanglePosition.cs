using System;
using System.Dynamic;
using System.Linq;

public class RectanglePosition
{
    class Rectangle
    {
        public double Left { get; set; }
        public double Top { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Area { get; set; }
        public double Right { get; set; }
        public double Bottom { get; set; }
    }
    public static void Main()
    {
        var firstRectangle = Console.ReadLine()
            .Split()
            .Select(double.Parse)
            .ToArray();
        
        var secondRectangle = Console.ReadLine()
            .Split()
            .Select(double.Parse)
            .ToArray();
        var rectangle1 = createRectangle(firstRectangle);
        var rectangle2 = createRectangle(secondRectangle);
        bool isInside = calculatePositionTwoRectangles(rectangle1, rectangle2);
        var status = string.Empty;
        if (isInside)
        {
            status = "Inside";
        }
        else
        {
            status = "Not inside";
        }
        Console.WriteLine(status);
    }

    private static bool calculatePositionTwoRectangles(Rectangle r1, Rectangle r2)
    {
        return ((r1.Left >= r2.Left) && (r1.Right <= r2.Right) && (r1.Top >= r2.Top) && (r1.Bottom <= r2.Bottom)) ||
               ((r1.Left <= r2.Left) && (r1.Right >= r2.Right) && (r1.Top <= r2.Top) && (r1.Bottom >= r2.Bottom));
    }

    static Rectangle createRectangle(double[] parameters)
    {
       var rectangle = new Rectangle();
        rectangle.Left = parameters[0];
        rectangle.Top = parameters[1];
        rectangle.Width = parameters[2];
        rectangle.Height = parameters[3];
        rectangle.Area = rectangle.Width * rectangle.Height;
        rectangle.Right = rectangle.Left + rectangle.Width;
        rectangle.Bottom = rectangle.Top + rectangle.Height;
        return rectangle;
    }
}