using System;

class Program
{
    static void Main()
    {
        int year1 = int.Parse(Console.ReadLine());
        int year2 = int.Parse(Console.ReadLine());
        int magicDate = int.Parse(Console.ReadLine());
        DateTime startYear = new DateTime(year1, 1, 1);
        DateTime endYear = new DateTime(year2, 12, 31);
        bool ind = true;
        while(startYear <= endYear)
        {
            int d1 = startYear.Day / 10;
            int d2 = startYear.Day % 10;
            int m1 = startYear.Month / 10;
            int m2 = startYear.Month % 10;
            int y1 = startYear.Year / 1000;
            int y2 = (startYear.Year / 100) % 10;
            int y3 = (startYear.Year / 10) % 10;
            int y4 = startYear.Year % 10;
            int pr = 0;
            int[] digits = new int[] {d1, d2, m1, m2, y1, y2, y3, y4};
            for (int i = 0; i < digits.Length -1; i++)
            {
                for (int j = i + 1; j < digits.Length; j++)
                {
                    pr += digits[i] * digits[j];
                }
            }
            if(pr == magicDate)
            {
                Console.WriteLine("{0:d2}-{1:d2}-{2}", startYear.Day, startYear.Month, startYear.Year);
                ind = false;
            }
            startYear = startYear.AddDays(1);
        }
        if (ind)
        {
            Console.WriteLine("No");
        }
    }
}