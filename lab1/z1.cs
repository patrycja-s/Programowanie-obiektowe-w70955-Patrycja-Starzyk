// Napisz program obliczający wyróżnik delta i pierwiastki trójmianu kwadratowego.
using System;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("Program oblicza wyróżnik delta i pierwiastki trójmianu kwadratowego.");
        Console.Write("Podaj współczynnik a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj współczynnik b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj współczynnik c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        if (a == 0)
        {
            Console.WriteLine("To nie jest równanie kwadratowe (a = 0).");
            return;
        }

        double delta = b * b - 4 * a * c;
        Console.WriteLine($"Delta = {delta}");

        if (delta > 0)
        {
            double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($"Równanie ma dwa pierwiastki: x1 = {x1}, x2 = {x2}");
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"Równanie ma jeden pierwiastek: x = {x}");
        }
        else
        {
            Console.WriteLine("Równanie nie ma pierwiastków rzeczywistych.");
        }
    }
}

