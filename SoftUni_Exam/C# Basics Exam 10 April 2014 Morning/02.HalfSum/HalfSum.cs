using System;

class HalfSum
{
    static void Main()
    {
        int halfCount = int.Parse(Console.ReadLine());
        int sum1 = 0;
        int sum2 = 0;
        int diff = 0;
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < halfCount; j++)
            {
                int userInput = int.Parse(Console.ReadLine());
                if(i == 1)
                {
                    sum1 += userInput;
                }
                else
                {
                    sum2 += userInput;
                }
            }
        }
        if(sum1 == sum2)
        {
            Console.WriteLine("Yes, sum={0}", sum1);
        }
        else
        {
            diff = Math.Abs(sum1 - sum2);
            Console.WriteLine("No, diff={0}", diff);
        }
    }
}