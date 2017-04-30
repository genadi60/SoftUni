using System;
using System.Numerics;

class SimpleLoops
{
    static void Main()
    {
        BigInteger firstTrib = BigInteger.Parse(Console.ReadLine());
        BigInteger secondTrib = BigInteger.Parse(Console.ReadLine());
        BigInteger thirdTrib = BigInteger.Parse(Console.ReadLine());
        int count = int.Parse(Console.ReadLine());
        BigInteger N = 0;
        if(count < 4)
        {
            switch (count)
            {
                case 1:
                    N = firstTrib;
                    Console.WriteLine(N);
                    break;
                case 2:
                    N = secondTrib;
                    Console.WriteLine(N);
                    break;
                case 3:
                    N = thirdTrib;
                    Console.WriteLine(N);
                    break;
                default:
                    break;
            }
        }
        else
        {
            count -= 3;
           while (count > 1)
            {
                N = firstTrib + secondTrib + thirdTrib;
                firstTrib = secondTrib;
                secondTrib = thirdTrib;
                thirdTrib = N;
                count--;
            }
            Console.WriteLine(firstTrib + secondTrib + thirdTrib);
        }
    }
}