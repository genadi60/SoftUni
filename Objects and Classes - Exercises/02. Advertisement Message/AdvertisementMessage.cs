using System;

public class AdvertisementMessage
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var phrases = new string[]{ "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
        var events = new string[]{ "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
        var autors = new string[]{ "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
        var cities = new string[]{ "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
        var phrase = string.Empty;
        var ev = string.Empty;
        var autor = string.Empty;
        var city = string.Empty;
        var rand = new Random();
        for (int i = 0; i < n; i++)
        {
            phrase = phrases[rand.Next(0, phrases.Length)];
            ev = events[rand.Next(0, events.Length)];
            autor = autors[rand.Next(0, autors.Length)];
            city = cities[rand.Next(0, cities.Length)];
            Console.WriteLine($"{phrase} {ev} {autor} - {city}");
        }
    }
}