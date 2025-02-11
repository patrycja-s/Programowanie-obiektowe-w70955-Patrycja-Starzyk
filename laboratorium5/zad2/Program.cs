using System;
using System.Collections.Generic;

class Program
{
    // Definicja typu wyliczeniowego StatusZamowienia
    public enum StatusZamowienia
    {
        Oczekujące,
        Przyjęte,
        Zrealizowane,
        Anulowane
    }

    // Słownik przechowujący zamówienia (numer zamówienia, lista produktów)
    static Dictionary<int, List<string>> zamowienia = new Dictionary<int, List<string>>();

    // Słownik przechowujący statusy zamówień
    static Dictionary<int, StatusZamowienia> statusy = new Dictionary<int, StatusZamowienia>();

    static void Main()
    {
        // Dodanie przykładowych zamówień
        dodajZamowienie(1, new List<string> { "Produkt A", "Produkt B" });
        dodajZamowienie(2, new List<string> { "Produkt C" });
        dodajZamowienie(3, new List<string> { "Produkt D", "Produkt E", "Produkt F" });

        // Zmiana statusu zamówienia
        zmienStatusZamowienia(1, StatusZamowienia.Przyjęte);
        zmienStatusZamowienia(2, StatusZamowienia.Zrealizowane);

        // Wyświetlenie wszystkich zamówień
        wyswietlZamowienia();

        // Próbujemy zmienić status na ten sam (powinno wywołać wyjątek)
        try
        {
            zmienStatusZamowienia(1, StatusZamowienia.Przyjęte);  // Błąd, bo status już jest "Przyjęte"
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Błąd: {ex.Message}");
        }

        // Zmiana statusu na inny
        zmienStatusZamowienia(1, StatusZamowienia.Zrealizowane);
        zmienStatusZamowienia(3, StatusZamowienia.Anulowane);

        // Wyświetlenie zamówień po zmianach
        wyswietlZamowienia();
    }

    // Metoda do dodawania zamówienia
    static void dodajZamowienie(int numerZamowienia, List<string> produkty)
    {
        if (!zamowienia.ContainsKey(numerZamowienia))
        {
            zamowienia[numerZamowienia] = produkty;
            statusy[numerZamowienia] = StatusZamowienia.Oczekujące;  // Domyślny status
        }
        else
        {
            Console.WriteLine($"Zamówienie o numerze {numerZamowienia} już istnieje.");
        }
    }

    // Metoda zmieniająca status zamówienia
    static void zmienStatusZamowienia(int numerZamowienia, StatusZamowienia nowyStatus)
    {
        try
        {
            // Sprawdzamy, czy zamówienie istnieje
            if (!zamowienia.ContainsKey(numerZamowienia))
            {
                throw new KeyNotFoundException($"Zamówienie o numerze {numerZamowienia} nie istnieje.");
            }

            // Sprawdzamy, czy użytkownik nie próbuje ustawić tego samego statusu
            if (statusy[numerZamowienia] == nowyStatus)
            {
                throw new ArgumentException("Zamówienie ma już ten sam status.");
            }

            // Zmieniamy status
            statusy[numerZamowienia] = nowyStatus;
            Console.WriteLine($"Status zamówienia {numerZamowienia} został zmieniony na {nowyStatus}.");
        }
        catch (KeyNotFoundException ex)
        {
            Console.WriteLine($"Błąd: {ex.Message}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Błąd: {ex.Message}");
        }
    }

    // Metoda wyświetlająca wszystkie zamówienia i ich statusy
    static void wyswietlZamowienia()
    {
        Console.WriteLine("\nZamówienia:");
        foreach (var zamowienie in zamowienia)
        {
            int numerZamowienia = zamowienie.Key;
            List<string> produkty = zamowienie.Value;
            StatusZamowienia status = statusy[numerZamowienia];

            Console.WriteLine($"Zamówienie #{numerZamowienia}:");
            Console.WriteLine($"Status: {status}");
            Console.WriteLine("Produkty:");
            foreach (var produkt in produkty)
            {
                Console.WriteLine($"- {produkt}");
            }
            Console.WriteLine();
        }
    }
}
