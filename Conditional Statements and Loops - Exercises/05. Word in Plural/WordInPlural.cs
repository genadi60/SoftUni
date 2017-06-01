using System;
using System.Text;

class WordInPlural
{
    static void Main()
    {
        var noun = Console.ReadLine();
        if (noun.EndsWith("y"))
        {
            noun = noun.Remove(noun.Length - 1);
            Console.WriteLine(noun + "ies");
        }
        else if (noun.EndsWith("o") || noun.EndsWith("x") ||
                noun.EndsWith("s") ||
                noun.EndsWith("z") ||
                noun.EndsWith("ch") ||
                noun.EndsWith("sh"))
        {
            Console.WriteLine(noun + "es");
        }
        else
        {
            Console.WriteLine(noun + "s");
        }
    }
}