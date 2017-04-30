using System;

class PowersOfTwo
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n + 1; i++)
        {
            Console.WriteLine(Math.Pow(2,i));
        }
    }
}