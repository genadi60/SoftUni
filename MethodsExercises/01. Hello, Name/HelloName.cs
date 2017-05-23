using System;

class HelloName
{
    static void Main()
    {
        var name = Console.ReadLine();
        PrintName(name);
    }

    static void PrintName(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
}