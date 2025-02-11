using System;
using System.Collections.Generic;

namespace Lab3
{
    internal class Reader : Person
    {
        public List<Book> BooksRead { get; set; }

        // Konstruktor
        public Reader(string firstName, string lastName, int age)
            : base(firstName, lastName, age)
        {
            BooksRead = new List<Book>();
        }

        // Metoda dodająca książki do przeczytanych
        public void AddBook(Book book)
        {
            BooksRead.Add(book);
        }

        // Metoda ViewBook, wypisująca tytuły przeczytanych książek
        public void ViewBook()
        {
            Console.WriteLine("Przeczytane książki:");
            foreach (var book in BooksRead)
            {
                Console.WriteLine($"- {book.Title}");
            }
        }

        // Nadpisana metoda View
        public new void View()
        {
            base.View();  // Wywołanie View z klasy Person
            ViewBook();   // Wywołanie ViewBook, by pokazać przeczytane książki
        }
    }
}
