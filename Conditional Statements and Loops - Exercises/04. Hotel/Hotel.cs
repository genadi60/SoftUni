using System;

public class Hotel
{
    public static void Main()
    {
        var month = Console.ReadLine();
        var overnights = int.Parse(Console.ReadLine());
        
       
        double pricePerStudio = 0;
        double pricePerDouble = 0;
        double pricePerSuite = 0;
        switch (month)
        {
            case "May":
            case "October":
                pricePerStudio = 50;
                pricePerDouble = 65;
                pricePerSuite = 75;
                break;
            case "June":
            case "September":
                pricePerStudio = 60;
                pricePerDouble = 72;
                pricePerSuite = 82;
                break;
            case "July":
            case "August":
            case "December":
                pricePerStudio = 68;
                pricePerDouble = 77;
                pricePerSuite = 89;
                break;
        }
        if (overnights > 7 && (month == "May" || month == "October"))
        {
            pricePerStudio *= 0.95;
        }
        else if (overnights > 14 && (month == "June" || month == "September"))
        {
            pricePerDouble *= 0.9;
        }
        else if (overnights > 14 && (month == "July" || month == "August" || month == "December"))
        {
            pricePerSuite *= 0.85;
        }
        double priceEndStudio = overnights * pricePerStudio;
        double priceEndDouble = overnights * pricePerDouble;
        double priceEndSuite = overnights * pricePerSuite;

        if (overnights > 7 && (month == "September" || month == "October"))
        {
            priceEndStudio -= pricePerStudio;
        }
        
        Console.WriteLine($"Studio: {priceEndStudio:F2} lv.");
        Console.WriteLine($"Double: {priceEndDouble:F2} lv.");
        Console.WriteLine($"Suite: {priceEndSuite:F2} lv.");
    }
}