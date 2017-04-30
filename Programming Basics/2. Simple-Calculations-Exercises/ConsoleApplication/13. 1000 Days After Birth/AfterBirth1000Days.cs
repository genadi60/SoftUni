using System;
using System.Globalization;

class AfterBirth1000Days
{
    static void Main()
    {
        int addedDays = 999;
        CultureInfo culture = CultureInfo.CreateSpecificCulture("fr-FR");
        DateTime inputData = DateTime.Parse(Console.ReadLine(), culture, DateTimeStyles.None);
        inputData = inputData.AddDays(addedDays);
        DateTimeFormatInfo dtfi = culture.DateTimeFormat;
        dtfi.DateSeparator = "-";
        Console.WriteLine("{0}", inputData.ToString("d", dtfi));
    }
}