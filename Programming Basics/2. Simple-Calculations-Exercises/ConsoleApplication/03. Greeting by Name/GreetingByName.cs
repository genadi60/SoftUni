using System;

class GreetingByName
{
    static void Main()
    {
        //Console.Write("Enter your name: ");
        var name = Console.ReadLine();
        Console.WriteLine("Hello, {0}!", name);
    }
}