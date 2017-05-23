using System;

class EmployeeData
{
    static void Main()
    {
        var name = Console.ReadLine();
        var age = Console.ReadLine();
        var employeeID = int.Parse(Console.ReadLine());
        var salary = double.Parse(Console.ReadLine());
        Console.WriteLine("Name: {0}", name);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Employee ID: {0:D8}", employeeID);
        Console.WriteLine("Salary: {0:F2}", salary);
    }
}