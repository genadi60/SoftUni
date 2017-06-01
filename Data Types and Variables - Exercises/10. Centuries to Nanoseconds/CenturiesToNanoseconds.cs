using System;
using System.Numerics;

public class CenturiesToNanoseconds
{
    public static void Main()
    {
        var numberOfCenturies = int.Parse(Console.ReadLine());

        var years = numberOfCenturies * 100;
        var days = (int)(years * 365.2422m);
        var hours = days * 24;
        var minutes = (ulong)(hours * 60);
        var seconds = minutes * 60;
        var miliseconds = seconds * 1000;
        var microseconds = miliseconds * 1000;
        var nanoseconds = microseconds * (BigInteger)1000;
        
        Console.WriteLine($"{numberOfCenturies} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {miliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
    }
}
