using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _05.BookLibrary
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Book> books = new List<Book>();

            for (int i = 0; i < n; i++)
            {
                books.Add(GetBook(Console.ReadLine()));
            }

            Library library = new Library { Name = "Library", Books = books };

            DateTime date = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);

            Dictionary<string, DateTime> booksByDate = new Dictionary<string, DateTime>();


            foreach (Book book in library.Books)
            {
                if (book.ReleaseDate.CompareTo(date) > 0)
                {
                    booksByDate.Add(book.Title, book.ReleaseDate);
                }
            }

            foreach (var pair in booksByDate.OrderBy(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine("{0} -> {1:dd.MM.yyyy}", pair.Key, pair.Value);
            }
        }

        private static Book GetBook(string input)
        {
            string[] inputArr = input.Split(' ');
            string title = inputArr[0];
            string author = inputArr[1];
            string publisher = inputArr[2];
            DateTime releaseDate = DateTime.ParseExact(inputArr[3], "d.M.yyyy", CultureInfo.InvariantCulture);
            string isbn = inputArr[4];
            decimal price = decimal.Parse(inputArr[5]);

            return new Book { Title = title, Author = author, Publisher = publisher, ReleaseDate = releaseDate, ISBN = isbn, Price = price };
        }
    }

    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
    }

    internal class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
}