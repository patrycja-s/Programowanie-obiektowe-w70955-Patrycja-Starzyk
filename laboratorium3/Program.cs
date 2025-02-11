using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new Person("Jan", "Kowalski", 30);
            Reader reader1 = new Reader("Anna", "Nowak", 25);
            Reviewer reviewer1 = new Reviewer("Marek", "Zielinski", 35);

            Book book1 = new Book("Władca Pierścieni", person1, new DateTime(1954, 7, 29));
            Book book2 = new Book("Harry Potter", person1, new DateTime(1997, 6, 26));

            reader1.AddBook(book1);
            reader1.AddBook(book2);
            reviewer1.AddBook(book1);
            reviewer1.AddBook(book2);

            
            person1.View();   
            reader1.View();   
            reviewer1.WriteReview();  

            Console.ReadKey();  
        }
    }
}
