//Napisz program umożliwiający wprowadzanie 10-ciu liczb. Dla wprowadzonych liczb wykonaj
//odpowiednie algorytmy:
//• oblicz sumę elementów tablicy,
//• oblicz iloczyn elementów tablicy,
//• wyznacz wartość średnią,
//• wyznacz wartość minimalną,
//• wyznacz wartość maksymalną.
//Wyniki działania algorytmów wyświetlaj na konsoli.

internal class Program
{
    static void Main()
    {
        double[] liczby = new double[10];

        Console.WriteLine("Wprowadź 10 liczb:");

        for (int i = 0; i < liczby.Length; i++)
        {
            Console.Write($"Podaj liczbę {i + 1}: ");
            liczby[i] = double.Parse(Console.ReadLine());
        }

        double suma = 0;
        foreach (double liczba in liczby)
        {
            suma += liczba;
        }

        double iloczyn = 1;
        foreach (double liczba in liczby)
        {
            iloczyn *= liczba;
        }

        double srednia = suma / liczby.Length;

        double min = liczby[0];
        foreach (double liczba in liczby)
        {
            if (liczba < min)
            {
                min = liczba;
            }
        }

        double max = liczby[0];
        foreach (double liczba in liczby)
        {
            if (liczba > max)
            {
                max = liczba;
            }
        }

        Console.WriteLine("\nWyniki:");
        Console.WriteLine($"Suma elementów: {suma}");
        Console.WriteLine($"Iloczyn elementów: {iloczyn}");
        Console.WriteLine($"Średnia wartość: {srednia}");
        Console.WriteLine($"Minimalna wartość: {min}");
        Console.WriteLine($"Maksymalna wartość: {max}");
    }
}
