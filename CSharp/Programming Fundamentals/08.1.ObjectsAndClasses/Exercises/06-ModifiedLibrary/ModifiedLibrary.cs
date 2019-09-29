using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Ex6ModifiedLibrary
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
    }
    class Library
    {
        public string Name = "Library";
        public List<Book> Books { get; set; }
    }
    class ModifiedLibrary
    {
        static void Main(string[] args)
        {
            int numberOfBooks = int.Parse(Console.ReadLine());
            List<Book> books = new List<Book>();
            for (int i = 0; i < numberOfBooks; i++)
            {
                string[] inputLine = Console.ReadLine().Split();
                books.Add(ReadBook(inputLine));
            }
            string inputDate = Console.ReadLine();
            DateTime checkDate = DateTime.ParseExact(inputDate, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            Library library = new Library();
            library.Books = books;
            Dictionary<string, DateTime> booksAndDate = new Dictionary<string, DateTime>();
            foreach (var book in books)
            {
                if (book.ReleaseDate>checkDate)
                {
                    booksAndDate[book.Title] = book.ReleaseDate;
                }  
            }
            foreach (var book in booksAndDate.OrderBy(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{book.Key} -> {book.Value.ToString("dd.MM.yyyy")}");
            }
        }
        static Book ReadBook(string[] input)
        {
            Book book = new Book();
            string title = input[0];
            string author = input[1];
            string publisher = input[2];
            DateTime releaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            string isbn = input[4];
            decimal price = decimal.Parse(input[5]);
            book.Title = title;
            book.Author = author;
            book.Publisher = publisher;
            book.ReleaseDate = releaseDate;
            book.ISBN = isbn;
            book.Price = price;
            return book;
        }
    }
}
