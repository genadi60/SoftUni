using System;

class MaxNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());
        for (int i = 0; i < n-1; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (max < num)
            {
                max = num;
            }
        }
        Console.WriteLine(max);
    }
}