using System;

class AreaOfFigures
{
    static void Main()
    {
        string fig = Console.ReadLine().ToLower();
        switch (fig)
        {
            case "square":
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(side * side, 3));
                break;
            case "circle":
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(Math.PI * radius * radius, 3));
                break;
            case "rectangle":
                var side1 = double.Parse(Console.ReadLine());
                var side2 = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(side1 * side2, 3));
                break;
            case "triangle":
                var kat = double.Parse(Console.ReadLine());
                var h = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(kat * h / 2.0, 3) );
                break;
            default:
                break;
        }
    }
}