using System;

class DebitCardNumber
{
    static void Main()
    {
        var inputs = new int[4];
        for (int i = 0; i < inputs.Length; i++)
        {
            inputs[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("{0:D4} {1:D4} {2:D4} {3:D4}", inputs[0], inputs[1], inputs[2], inputs[3]);
    }
}