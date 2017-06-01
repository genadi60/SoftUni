using System;

class MultiplicationTable2
{
    static void Main()
    {
        var theInteger = int.Parse(Console.ReadLine());
        var multiplier = long.Parse(Console.ReadLine());
        long product = 0L;
        if (multiplier >= 10)
        {
            product = theInteger * multiplier;
            Console.WriteLine($"{theInteger} X {multiplier} = {product}");
        }
        else
        {
            for (long i = multiplier; i <= 10; i++)
            {
                product = theInteger * i;
                Console.WriteLine($"{theInteger} X {i} = {product}");
            }
        }
    }
}