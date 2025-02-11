using System;

namespace Lab3
{
    internal class Person
    {
        // Pola
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        // Konstruktor
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        // Metoda View
        public void View()
        {
            Console.WriteLine($"Imię: {FirstName}, Nazwisko: {LastName}, Wiek: {Age}");
        }
    }
}

