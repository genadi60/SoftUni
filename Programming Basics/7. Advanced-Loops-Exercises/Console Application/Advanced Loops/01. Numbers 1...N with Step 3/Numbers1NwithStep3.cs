using System;

class Numbers1NwithStep3
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i+=3)
        {
            Console.WriteLine(i);
        }
    }
}