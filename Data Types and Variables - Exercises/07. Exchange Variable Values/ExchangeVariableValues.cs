using System;

public class ExchangeVariableValues
{
    public static void Main()
    {
        var a = Console.ReadLine();
        var b = Console.ReadLine();
        Console.WriteLine("Before:");
        Console.WriteLine($"a = {a}");
        Console.WriteLine($"b = {b}");
        var c = a;
        a = b;
        b = c;
        Console.WriteLine("After:");
        Console.WriteLine($"a = {a}");
        Console.WriteLine($"b = {b}");
    }
}