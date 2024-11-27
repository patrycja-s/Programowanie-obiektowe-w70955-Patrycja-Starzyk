//Napisz program umożliwiający wprowadzanie n liczb oraz sortujący te liczby metodą
//bąbelkową lub wstawiania. Wyniki wyświetlaj na konsoli.

using System;

internal class Program
{
    static void Main()
    {

        Console.Write("Podaj ilość liczb do wprowadzenia: ");
        int n = int.Parse(Console.ReadLine());


        int[] liczby = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Podaj liczbę {i + 1}: ");
            liczby[i] = int.Parse(Console.ReadLine());
        }

        // Sortowanie bąbelkowe
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (liczby[j] > liczby[j + 1])
                {
                    int temp = liczby[j];
                    liczby[j] = liczby[j + 1];
                    liczby[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("\nPosortowane liczby:");
        foreach (int liczba in liczby)
        {
            Console.WriteLine(liczba);
        }
    }
}
