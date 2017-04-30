using System;

class EqualPairs
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        decimal firstSum = decimal.Parse(Console.ReadLine()) + decimal.Parse(Console.ReadLine());
        decimal diff = 0m;
        if (n > 1)
        {
            for (int i = 0; i < n - 1; i++)
            {
                decimal nextSum = 0m;
                for (int j = 0; j < 2; j++)
                {
                    nextSum += decimal.Parse(Console.ReadLine());
                }
                if(firstSum != nextSum)
                {
                    if(diff < Math.Abs(firstSum - nextSum))
                    {
                        diff = Math.Abs(firstSum - nextSum);
                    }
                }
                firstSum = nextSum;
            }
        }
        if(diff == 0m)
        {
            Console.WriteLine("Yes, value=" + firstSum);
        }
        else
        {
            Console.WriteLine("No, maxdiff=" + diff);
        }
    }
}