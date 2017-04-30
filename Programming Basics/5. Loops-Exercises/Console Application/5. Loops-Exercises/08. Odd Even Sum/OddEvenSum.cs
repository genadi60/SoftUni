using System;

class OddEvenSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sumEven = 0;
        int sumOdd = 0;
        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 0)
            {
                sumEven += int.Parse(Console.ReadLine());
            }
            else
            {
                sumOdd += int.Parse(Console.ReadLine());
            }
        }
        if (sumEven == sumOdd)
        {
            Console.WriteLine(@"Yes
Sum = " + sumEven);
        }
        else
        {
            Console.WriteLine(@"No
Diff = " + Math.Abs(sumEven - sumOdd));
        }
    }
}