using System;

class GreaterNumber
{
    static void Main()
    {
        Console.WriteLine("Enter two integers:");
        var num1 = int.Parse(Console.ReadLine());
        var num2 = int.Parse(Console.ReadLine());
        if(num1 > num2)
        {
            Console.WriteLine("Greater number: {0}", num1);
        }
        else
        {
            Console.WriteLine("Greater number: {0}", num2);
        }
    }
}