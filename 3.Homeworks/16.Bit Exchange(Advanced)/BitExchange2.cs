using System;


class BitExchange2
{
    static void Main()
    {
        long userInput = long.Parse(Console.ReadLine());
        int firstPosition = int.Parse(Console.ReadLine());
        int secondPosition = int.Parse(Console.ReadLine());
        int numberOfSwapedBits = int.Parse(Console.ReadLine());
        if((firstPosition + numberOfSwapedBits) <= 32 && (secondPosition  + numberOfSwapedBits) <= 32)
        {
            if (Math.Min(firstPosition, secondPosition) + numberOfSwapedBits < Math.Max(firstPosition, secondPosition))
            {
                int firstMask = 0;
            }
            else
            {
                Console.WriteLine("overlapping");
            }
        }
        else
        {
            Console.WriteLine("out of range");
        }
    }
}

