using System;

class HotelRoom
{
    static void Main()
    {
        string visitMonth = Console.ReadLine();
        int night = int.Parse(Console.ReadLine());
        
        string[] month = new string[] { "May", "June", "July", "August", "September", "October" };
        decimal[] studio = new decimal[] { 50.00m, 75.20m, 76.00m, 76.00m, 75.20m, 50.00m };
        decimal[] aparth = new decimal[] { 65.00m, 68.70m, 77.00m, 77.00m, 68.70m, 65.00m };
        int index = Array.IndexOf(month, visitMonth);
        decimal sumStudio = 0.00m;
        decimal sumApartment = 0.00m;

        if (night > 7 && night <= 14 && (visitMonth == "May" || visitMonth == "October"))
        {
            sumStudio += night * studio[index] * 0.95m;
            sumApartment += night * aparth[index];
        }

        else if (night > 14)
        {
            if (visitMonth == "May" || visitMonth == "October")
            {
                sumStudio += night * studio[index] * 0.70m;
            }
            else if (visitMonth == "June" || visitMonth == "September")
            {
                sumStudio += night * studio[index] * 0.80m;
            }
            else
            {
                sumStudio += night * studio[index];
            }
            sumApartment += night * aparth[index] * 0.90m;
        }
        
        else
        {
            sumStudio += night * studio[index];
            sumApartment += night * aparth[index];
        }

        Console.WriteLine("Apartment: {0:F2} lv.", sumApartment);
        Console.WriteLine("Studio: {0:F2} lv.", sumStudio);
    }
}