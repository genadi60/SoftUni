using System;

class Cinema
{
    static void Main()
    {
        string mode = Console.ReadLine().ToLower();
        int audience = int.Parse(Console.ReadLine()) * int.Parse(Console.ReadLine());
        decimal prise = 0m;
        switch (mode)
        {
            case "premiere":
                prise = 12.00m;
                break;
            case "normal":
                prise = 7.50m;
                break;
            case "discount":
                prise = 5.00m;
                break;
            default:
                break;
        }
        Console.WriteLine("{0:F2} leva", audience * prise);
    }
}