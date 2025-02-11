using System;

namespace Lab3
{
    internal class Book
    {
        // Pola
        public string Title { get; set; }
        public Person Author { get; set; }
        public DateTime PublicationDate { get; set; }

        // Konstruktor
        public Book(string title, Person author, DateTime publicationDate)
        {
            Title = title;
            Author = author;
            PublicationDate = publicationDate;
        }

        // Metoda View
        public void View()
        {
            Console.WriteLine($"Tytuł: {Title}, Autor: {Author.FirstName} {Author.LastName}, Data wydania: {PublicationDate.ToShortDateString()}");
        }
    }
}
