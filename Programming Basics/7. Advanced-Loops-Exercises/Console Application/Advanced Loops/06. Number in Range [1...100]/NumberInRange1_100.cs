using System;

class NumberInRange1_100
{
    static void Main()
    {
        int n = 0;
        while(n < 1 || n > 100)
        {
            Console.Write("Еnter a number in the range [1...100]: ");
            n = int.Parse(Console.ReadLine());
            if(n < 1 || n > 100)
            {
                Console.WriteLine("Invalid number!");
            }
            else
            {
                Console.WriteLine("The number is: {0}", n);
            }
        }
    }
}