using System;

class Fibonacci
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int f = 0;
        int s = 1;
        int t = 1;
        for (int i = 0; i < n; i++)
        {
            t = f + s;
            f = s;
            s = t;
        }
        Console.WriteLine(t);
    }
}