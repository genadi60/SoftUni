using System;

class EnterEvenNumber
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter even number: ");
            try
            {
                int n = int.Parse(Console.ReadLine());
                if(n % 2 == 0)
                {
                    Console.WriteLine("Even number entered: {0}", n);
                    break;
                }
                else
                {
                    Console.WriteLine("The number is not even.");
                }
            }
            catch
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}