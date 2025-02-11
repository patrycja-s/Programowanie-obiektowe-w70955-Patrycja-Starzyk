using System;

namespace Lab3
{
    internal class Reviewer : Reader
    {
        // Konstruktor
        public Reviewer(string firstName, string lastName, int age)
            : base(firstName, lastName, age)
        { }

        // Metoda WriteReview, wypisująca książki z ocenami
        public void WriteReview()
        {
            Random random = new Random();
            Console.WriteLine("Recenzje książek:");
            foreach (var book in BooksRead)
            {
                int rating = random.Next(1, 6); // Losowanie oceny (1-5)
                Console.WriteLine($"- {book.Title} - Ocena: {rating}/5");
            }
        }
    }
}
