using System;

class InvalidNumber
{
    static void Main()
    {
        var number = int.Parse(Console.ReadLine());
        if(number != 0)
        {
            if(number < 100 || number > 200)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}