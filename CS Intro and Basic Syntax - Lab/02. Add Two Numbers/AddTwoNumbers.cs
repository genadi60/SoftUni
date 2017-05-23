using System;

class AddTwoNumbers
{
    static void Main(string[] args)
    {
        var firstNumber = long.Parse(Console.ReadLine());
        var secondNumber = long.Parse(Console.ReadLine());
        var sum = firstNumber + secondNumber;
        Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, sum);
    }
}