using System;

class GameOfIntervals
{
    static void Main()
    {
        decimal n = decimal.Parse(Console.ReadLine());
        int interval1 = 0;
        int interval2 = 0;
        int interval3 = 0;
        int interval4 = 0;
        int interval5 = 0;
        int invalidNumber = 0;
        decimal result = 0.00m;

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (number < 0 || number > 50)
            {
                invalidNumber++;
                result /= 2.00m;
            }
            else if (number <= 9)
            {
                interval1++;
                result += number * 0.20m; 
            }
            else if (number <= 19)
            {
                interval2++;
                result += number * 0.30m;
            }
            else if (number <= 29)
            {
                interval3++;
                result += number * 0.40m;
            }
            else if (number <= 39)
            {
                interval4++;
                result += 50.00m;
            }
            else if (number <= 50)
            {
                interval5++;
                result += 100.00m;
            }
        }
        Console.WriteLine("{0:F2}", result);
        Console.WriteLine("From 0 to 9: {0:F2}%", interval1 / n * 100);
        Console.WriteLine("From 10 to 19: {0:F2}%", interval2 / n * 100);
        Console.WriteLine("From 20 to 29: {0:F2}%", interval3 / n * 100);
        Console.WriteLine("From 30 to 39: {0:F2}%", interval4 / n * 100);
        Console.WriteLine("From 40 to 50: {0:F2}%", interval5 / n * 100);
        Console.WriteLine("Invalid numbers: {0:F2}%", invalidNumber / n * 100);
    }
}