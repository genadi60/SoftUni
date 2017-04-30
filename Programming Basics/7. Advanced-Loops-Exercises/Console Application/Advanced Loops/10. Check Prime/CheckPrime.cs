using System;

class CheckPrime
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= (int)Math.Sqrt(n); i++)
        {
            if(n % i == 0)
            {
                sum++;
            }
        }
        if(sum == 1 && n >= 2)
        {
            Console.WriteLine("Prime");
        }
        else
        {
            Console.WriteLine("Not Prime");
        }
    }
}