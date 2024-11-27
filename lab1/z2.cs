// Napisz kalkulator obliczający: sumę, różnicę, iloczyn, iloraz, potęgę, pierwiastek, oraz wartości
// funkcji trygonometrycznych dla zadanego kąta. Użyj biblioteki Math np. Math.Sin(2.5). Proszę
// pamiętać, że wartości kąta podawane do funkcji mierzone są miarą łukową. Wyniki działania
// algorytmów wyświetlaj na konsoli. Do obsługi menu proszę użyć konstrukcji switch-case oraz
// pętli while.
using System;

internal class Kalkulator
{
    static void Main()
    {
        bool kontynuacja = true;

        while (kontynuacja)
        {
            Console.WriteLine("\nKalkulator:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Różnica");
            Console.WriteLine("3. Iloczyn");
            Console.WriteLine("4. Iloraz");
            Console.WriteLine("5. Potęgowanie");
            Console.WriteLine("6. Pierwiastek kwadratowy");
            Console.WriteLine("7. Funkcje trygonometryczne (sin, cos, tan)");
            Console.WriteLine("0. Wyjście");
            Console.Write("Wybierz opcję: ");

            int wybor = int.Parse(Console.ReadLine());

            switch (wybor)
            {
                case 1:
                    Console.Write("Podaj pierwszą liczbę: ");
                    double a1 = double.Parse(Console.ReadLine());
                    Console.Write("Podaj drugą liczbę: ");
                    double b1 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Suma: {a1 + b1}");
                    break;

                case 2:
                    Console.Write("Podaj pierwszą liczbę: ");
                    double a2 = double.Parse(Console.ReadLine());
                    Console.Write("Podaj drugą liczbę: ");
                    double b2 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Różnica: {a2 - b2}");
                    break;

                case 3:
                    Console.Write("Podaj pierwszą liczbę: ");
                    double a3 = double.Parse(Console.ReadLine());
                    Console.Write("Podaj drugą liczbę: ");
                    double b3 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Iloczyn: {a3 * b3}");
                    break;

                case 4:
                    Console.Write("Podaj pierwszą liczbę: ");
                    double a4 = double.Parse(Console.ReadLine());
                    Console.Write("Podaj drugą liczbę: ");
                    double b4 = double.Parse(Console.ReadLine());
                    if (b4 != 0)
                        Console.WriteLine($"Iloraz: {a4 / b4}");
                    else
                        Console.WriteLine("Błąd: Dzielenie przez zero!");
                    break;

                case 5:
                    Console.Write("Podaj podstawę: ");
                    double podstawa = double.Parse(Console.ReadLine());
                    Console.Write("Podaj wykładnik: ");
                    double wykladnik = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Wynik: {Math.Pow(podstawa, wykladnik)}");
                    break;

                case 6:
                    Console.Write("Podaj liczbę: ");
                    double liczba = double.Parse(Console.ReadLine());
                    if (liczba >= 0)
                        Console.WriteLine($"Pierwiastek: {Math.Sqrt(liczba)}");
                    else
                        Console.WriteLine("Błąd: Pierwiastek z liczby ujemnej!");
                    break;

                case 7:
                    Console.Write("Podaj kąt w radianach: ");
                    double kat = double.Parse(Console.ReadLine());
                    Console.WriteLine($"sin({kat}) = {Math.Sin(kat)}");
                    Console.WriteLine($"cos({kat}) = {Math.Cos(kat)}");
                    Console.WriteLine($"tan({kat}) = {Math.Tan(kat)}");
                    break;

                case 0:
                    kontynuacja = false;
                    Console.WriteLine("Koniec programu.");
                    break;

                default:
                    Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
                    break;
            }
        }
    }
}
