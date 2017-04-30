using System;

class ExcelentResult
{
    static void Main()
    {
        var note = double.Parse(Console.ReadLine());
        if(note >= 5.50)
        {
            Console.WriteLine("Excellent!");
        }
    }
}