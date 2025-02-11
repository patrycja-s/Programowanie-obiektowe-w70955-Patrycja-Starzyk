using System;
using System.Collections.Generic;

class Program
{
    // Typ wyliczeniowy do reprezentowania dostępnych operacji
    enum Operacja
    {
        Dodawanie,
        Odejmowanie,
        Mnożenie,
        Dzielenie
    }

    static void Main(string[] args)
    {
        // Kolekcja do przechowywania wyników poprzednich obliczeń
        List<double> wyniki = new List<double>();

        while (true)
        {
            try
            {
                // Wprowadzenie dwóch liczb
                Console.WriteLine("Podaj pierwszą liczbę:");
                double liczba1 = WczytajLiczbe();

                Console.WriteLine("Podaj drugą liczbę:");
                double liczba2 = WczytajLiczbe();

                // Wybór operacji
                Console.WriteLine("Wybierz operację:");
                Console.WriteLine("0 - Dodawanie");
                Console.WriteLine("1 - Odejmowanie");
                Console.WriteLine("2 - Mnożenie");
                Console.WriteLine("3 - Dzielenie");

                int wybor = int.Parse(Console.ReadLine());

                // Sprawdzenie, czy wybór jest poprawny
                if (wybor < 0 || wybor > 3)
                {
                    Console.WriteLine("Niepoprawny wybór operacji.");
                    continue;
                }

                Operacja operacja = (Operacja)wybor;
                double wynik = 0;

                // Wykonywanie odpowiedniej operacji
                switch (operacja)
                {
                    case Operacja.Dodawanie:
                        wynik = liczba1 + liczba2;
                        break;
                    case Operacja.Odejmowanie:
                        wynik = liczba1 - liczba2;
                        break;
                    case Operacja.Mnożenie:
                        wynik = liczba1 * liczba2;
                        break;
                    case Operacja.Dzielenie:
                        // Obsługa wyjątku dzielenia przez zero
                        if (liczba2 == 0)
                        {
                            throw new DivideByZeroException("Nie można dzielić przez zero!");
                        }
                        wynik = liczba1 / liczba2;
                        break;
                }

                // Dodanie wyniku do listy wyników
                wyniki.Add(wynik);

                // Wyświetlenie wyniku
                Console.WriteLine($"Wynik operacji: {wynik}");

                // Zapytanie użytkownika, czy chce kontynuować
                Console.WriteLine("Czy chcesz kontynuować? (t/n)");
                string odpowiedz = Console.ReadLine().ToLower();
                if (odpowiedz != "t")
                {
                    break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Błąd: Wprowadzono niepoprawny format liczby. Spróbuj ponownie.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Wystąpił nieoczekiwany błąd: {ex.Message}");
            }
        }

        // Wyświetlenie wyników wszystkich poprzednich obliczeń
        Console.WriteLine("\nWyniki poprzednich obliczeń:");
        foreach (var wynik in wyniki)
        {
            Console.WriteLine(wynik);
        }
    }

    // Metoda do wczytywania liczby z obsługą błędów
    static double WczytajLiczbe()
    {
        double liczba;
        while (true)
        {
            string input = Console.ReadLine();
            if (double.TryParse(input, out liczba))
            {
                return liczba;
            }
            else
            {
                Console.WriteLine("Błąd: Wprowadzono niepoprawną liczbę. Spróbuj ponownie.");
            }
        }
    }
}
