using System;

class EvenPowersOf2
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n + 1; i+=2)
        {
            Console.WriteLine(Math.Pow(2, i));
        }
    }
}