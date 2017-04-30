using System;

class OddEvenSum
{
    static void Main()
    {
        int countOfNumbers = int.Parse(Console.ReadLine());
        int sumOdd = 0;
        int sumEven = 0;
        for (int i = 1; i <= countOfNumbers*2; i++)
        {
            if(i%2 == 1)
            {
                sumOdd += int.Parse(Console.ReadLine());
            }
            else
            {
                sumEven += int.Parse(Console.ReadLine());
            }
        }
        if(sumOdd == sumEven)
        {
            Console.WriteLine("Yes, sum={0}", sumOdd);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(sumOdd - sumEven));
        }
    }
}