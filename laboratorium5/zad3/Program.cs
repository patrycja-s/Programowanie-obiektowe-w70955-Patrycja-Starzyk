using System;
using System.Collections.Generic;

class Program
{
    // Definicja typu wyliczeniowego Kolor
    public enum Kolor
    {
        Czerwony,
        Niebieski,
        Zielony,
        Żółty,
        Fioletowy
    }

    static void Main()
    {
        // Lista dostępnych kolorów
        List<Kolor> kolory = new List<Kolor>
        {
            Kolor.Czerwony,
            Kolor.Niebieski,
            Kolor.Zielony,
            Kolor.Żółty,
            Kolor.Fioletowy
        };

        // Losowe wybranie koloru
        Random random = new Random();
        Kolor wylosowanyKolor = kolory[random.Next(kolory.Count)];

        // Zmienna do przechowywania zgadywanego koloru
        Kolor zgadywanyKolor;

        Console.WriteLine("Witaj w grze! Zgadnij kolor.");

        do
        {
            Console.Write("Podaj kolor (Czerwony, Niebieski, Zielony, Żółty, Fioletowy): ");
            string input = Console.ReadLine();

            try
            {
                // Próbujemy przekonwertować dane wejściowe na odpowiedni kolor
                zgadywanyKolor = (Kolor)Enum.Parse(typeof(Kolor), input, true);

                // Sprawdzamy, czy użytkownik odgadł prawidłowy kolor
                if (zgadywanyKolor == wylosowanyKolor)
                {
                    Console.WriteLine("Brawo! Zgadłeś kolor!");
                    break;
                }
                else
                {
                    Console.WriteLine("Niestety, to nie jest właściwy kolor. Spróbuj ponownie.");
                }
            }
            catch (ArgumentException)
            {
                // Obsługuje wyjątek, gdy użytkownik wpisze nieprawidłowy kolor
                Console.WriteLine("Błąd: Wpisz prawidłowy kolor z listy (Czerwony, Niebieski, Zielony, Żółty, Fioletowy).");
            }
        } while (true);

        Console.WriteLine("Dziękujemy za grę!");
    }
}
