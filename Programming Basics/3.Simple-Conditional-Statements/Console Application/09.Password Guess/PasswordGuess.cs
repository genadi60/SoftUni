using System;

class PasswordGuess
{
    static void Main()
    {
        string password = "s3cr3t!P@ssw0rd";
        string userInput = Console.ReadLine();
        if(userInput == password)
        {
            Console.WriteLine("Welcome");
        }
        else
        {
            Console.WriteLine("Wrong password!");
        }
    }
}