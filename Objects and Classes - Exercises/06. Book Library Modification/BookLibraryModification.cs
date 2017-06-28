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
        var numberOfBooks = int.Parse(Console.ReadLine());
        var books = new List<string[]>();
        for (int i = 0; i < numberOfBooks; i++)
        {
            var book = Console.ReadLine()
                .Split()
                .ToArray();
            books.Add(book);
        }
        var startDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
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
        foreach (var book in libr.Books.Where(x => x.ReleaseDate > startDate).OrderBy(x => x.ReleaseDate).ThenBy(x => x.Title))
        {
            Console.WriteLine("{0} -> {1:D2}.{2:D2}.{3}", book.Title, book.ReleaseDate.Day, book.ReleaseDate.Month, book.ReleaseDate.Year);
        }
    }
}