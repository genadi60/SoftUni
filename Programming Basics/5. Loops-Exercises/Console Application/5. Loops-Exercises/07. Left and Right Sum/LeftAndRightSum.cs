using System;

class LeftAndRightSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sumLeft = 0;
        int sumRight = 0;
        for (int i = 0; i < 2 * n; i++)
        {
            if (i < n)
            {
                sumLeft += int.Parse(Console.ReadLine());
            }
            else
            {
                sumRight += int.Parse(Console.ReadLine());
            }
        }
        if (sumLeft == sumRight)
        {
            Console.WriteLine("Yes, sum = " + sumLeft);
        }
        else
        {
            Console.WriteLine("No, diff = " + Math.Abs(sumLeft - sumRight));
        }
    }
}
