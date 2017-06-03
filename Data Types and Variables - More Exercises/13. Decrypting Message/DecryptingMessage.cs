using System;

public class DecryptingMessage
{
    public static void Main()
    {
        var key = int.Parse(Console.ReadLine());
        var numberOfLetters = int.Parse(Console.ReadLine());
        var encriptedMessage = new char[numberOfLetters];
        for (int i = 0; i < numberOfLetters; i++)
        {
            encriptedMessage[i] = (char)((char)Console.Read() + key);
            Console.ReadLine();
        }
        Console.WriteLine(string.Join("", encriptedMessage).ToString());
    }
}