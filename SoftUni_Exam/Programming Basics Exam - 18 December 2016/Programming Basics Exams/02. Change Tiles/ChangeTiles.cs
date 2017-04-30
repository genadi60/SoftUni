using System;

class ChangeTiles
{
    static void Main()
    {
        decimal money = decimal.Parse(Console.ReadLine());
        decimal floorWidth = decimal.Parse(Console.ReadLine());
        decimal floorLength = decimal.Parse(Console.ReadLine());
        decimal triangleSide = decimal.Parse(Console.ReadLine());
        decimal triangleHight = decimal.Parse(Console.ReadLine());
        decimal preis = decimal.Parse(Console.ReadLine());
        decimal salary = decimal.Parse(Console.ReadLine());
        decimal floorArea = floorLength * floorWidth;
        decimal triangleArea = triangleSide * triangleHight / 2;
        decimal pieses = Math.Ceiling(floorArea / triangleArea) + 5;
        decimal totalPreis = pieses * preis + salary;
        if(money >= totalPreis)
        {
            Console.WriteLine("{0:F2} lv left.", (money - totalPreis));
        }
        else
        {
            Console.WriteLine("You'll need {0:F2} lv more.", (totalPreis - money));
        }
    }
}