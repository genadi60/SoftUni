using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class BookLibrary
{
    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Autor { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public long ISBN { get; set; }
        public decimal Price { get; set; }
    }
    public static void Main()
    {
        var autors = new Dictionary<string, decimal>();
        var numberOfBooks = int.Parse(Console.ReadLine());
        var books = new List<string[]>();
        for (int i = 0; i < numberOfBooks; i++)
        {
            var book = Console.ReadLine()
                .Split()
                .ToArray();
            books.Add(book);
        }
        var libr = new Library();
        libr.Name = "The Wonderful Library";
        libr.Books = new List<Book>();
        foreach (var b in books)
        {
            var book = new Book();
            var date = new DateTime();
            date = DateTime.ParseExact(b[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            book.Title = b[0];
            book.Autor = b[1];
            book.Publisher = b[2];
            book.ReleaseDate = date;
            book.ISBN = long.Parse(b[4]);
            book.Price = decimal.Parse(b[5]);
            libr.Books.Add(book);
        }
        foreach (var book in libr.Books)
        {
            if (!autors.ContainsKey(book.Autor))
            {
                autors[book.Autor] = 0.00m;
            }
            autors[book.Autor] += book.Price;
        }
        foreach (var kvp in autors.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
        {
            var autor = kvp.Key;
            var prices = kvp.Value;
            Console.WriteLine($"{autor} -> {prices:F2}");
        }
    }
}