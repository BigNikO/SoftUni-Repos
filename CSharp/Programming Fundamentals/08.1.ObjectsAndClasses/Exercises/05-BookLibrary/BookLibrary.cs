using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Ex5BookLibrary
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
    class BookLibrary
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
            Library library = new Library();
            library.Books = books;
            Dictionary<string, decimal> authorsAndPrice = new Dictionary<string, decimal>();
            foreach (var book in books)
            {
                if (authorsAndPrice.ContainsKey(book.Author))
                {
                    authorsAndPrice[book.Author] += book.Price;
                }
                else
                {
                    authorsAndPrice[book.Author] = book.Price;
                }
            }
            foreach (var author in authorsAndPrice.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{author.Key} -> {author.Value:f2}");
            }
            
        }
        static Book ReadBook(string[] input)
        {
            Book book = new Book();
            string title = input[0];
            string author = input[1];
            string publisher = input[2];
            DateTime releaseDate = DateTime.ParseExact(input[3],"dd.MM.yyyy", CultureInfo.InvariantCulture);
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
