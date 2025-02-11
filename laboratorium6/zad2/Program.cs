using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Podaj nazwę pliku do wczytania: ");
        string fileName = Console.ReadLine();  // Pobierz nazwę pliku od użytkownika

        // Wczytanie zawartości pliku
        try
        {
            string content = File.ReadAllText(fileName);  // Wczytaj zawartość pliku
            Console.WriteLine("Zawartość pliku:");
            Console.WriteLine(content);  // Wyświetl zawartość pliku
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Wystąpił błąd podczas wczytywania pliku: {ex.Message}");
        }
    }
}
