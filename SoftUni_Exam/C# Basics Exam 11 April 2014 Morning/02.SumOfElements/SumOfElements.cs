using System;

class SumOfElements
{
    static void Main()
    {
         string[] secOfInt = Console.ReadLine().Split(' ');
         long[] numbers = new long[secOfInt.Length];
         long sum = 0L;
         long max = 0L;
         
         for (int i = 0; i < secOfInt.Length; i++)
         {
             numbers[i] = long.Parse(secOfInt[i]);
             sum += numbers[i];
             max = Math.Max(max, numbers[i]);
         }
        long minDiff = sum;
        if ((sum - max) == max)
         {
             Console.WriteLine("Yes, sum={0}", max);
         }
         else
         {
             for (int i = 0; i < numbers.Length; i++)
             {
                 minDiff = Math.Min(minDiff,(sum - 2 * numbers[i]));
             }
             Console.WriteLine("No, diff={0}", Math.Abs(minDiff));
         }
    }
}