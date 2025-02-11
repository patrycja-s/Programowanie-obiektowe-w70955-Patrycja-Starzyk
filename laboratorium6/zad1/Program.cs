using System;
using System.IO;

class Program
{
    static void Main()
    {
        string albumNumber = "70956"; 
        string fileName = "albumNumber.txt"; // nazwa pliku

        // Zapisanie numeru albumu do pliku
        try
        {
            File.WriteAllText(fileName, albumNumber);
            Console.WriteLine($"Numer albumu zapisano do pliku {fileName}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Wystąpił błąd podczas zapisywania do pliku: {ex.Message}");
        }
    }
}

