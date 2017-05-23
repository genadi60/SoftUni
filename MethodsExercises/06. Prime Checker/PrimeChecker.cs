using System;

class PrimeChecker
{
    static void Main()
    {
        long checkedNumber;
        if (long.TryParse(Console.ReadLine(), out checkedNumber))
        {
            if (checkedNumber >= 0)
            {
                Console.WriteLine(IsPrime(checkedNumber));
            }
        }
    }

    static bool IsPrime(long a)
    {
        bool result = true;
        int count = 0;

        if (a == 0 || a == 1)
        {
            count++;
        }

        for (int i = 2; i <= Math.Sqrt(a); i++)
        {
            if (a % i == 0)
            {
                count++;
            }
        }

        if (count != 0)
        {
            result = false;
        }

        return result;
    }
}