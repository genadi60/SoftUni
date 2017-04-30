using System;

class Profit
{
    static void Main()
    {
        int days = int.Parse(Console.ReadLine());
        decimal wage = decimal.Parse(Console.ReadLine());
        decimal currencyRate = decimal.Parse(Console.ReadLine());
        decimal salary = days * wage;
        decimal yearlySalary = salary * 12.00m + salary * 2.50m;
        decimal taxes = yearlySalary * 0.25m;
        decimal nettSalary = yearlySalary - taxes;
        decimal dailySalary = nettSalary / 365.00m;
        Console.WriteLine("{0:F2}", dailySalary * currencyRate);
    }
}