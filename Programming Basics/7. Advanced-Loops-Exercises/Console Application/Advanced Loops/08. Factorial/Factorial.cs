using System;

class Factorial
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if(n >= 1 && n <= 12)
        {
            int a = 1;
            for (int i = 1; i <= n; i++)
            {
                a *= i;
            }
            Console.WriteLine(a);
        }
        
    }
}