//Napisz program umożliwiający wprowadzanie 10-ciu liczb rzeczywistych do tablicy. Następnie
//utwórz następujące funkcjonalności używając pętli for:
//• Wyświetlanie tablicy od pierwszego do ostatniego indeksu.
//• Wyświetlanie tablicy od ostatniego do pierwszego indeksu.
//• Wyświetlanie elementów o nieparzystych indeksach.
//• Wyświetlanie elementów o parzystych indeksach.
//Wyniki działania algorytmów wyświetlaj na konsoli. Dla wyboru powyższych funkcjonalności programu
//utwórz odpowiednie menu. Do obsługi menu użyć rozbudowanej konstrukcji else-if oraz pętli do-while.

using System;

internal class Program
{
    static void Main()
    {
        double[] numbers = new double[10];

        Console.WriteLine("Wprowadź 10 liczb rzeczywistych:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Liczba {i + 1}: ");
            numbers[i] = Convert.ToDouble(Console.ReadLine());
        }

        int choice;
        do
        {

            Console.WriteLine("\nWybierz opcję:");
            Console.WriteLine("1. Wyświetl tablicę od pierwszego do ostatniego indeksu");
            Console.WriteLine("2. Wyświetl tablicę od ostatniego do pierwszego indeksu");
            Console.WriteLine("3. Wyświetl elementy o nieparzystych indeksach");
            Console.WriteLine("4. Wyświetl elementy o parzystych indeksach");
            Console.WriteLine("5. Zakończ program");
            Console.Write("Twój wybór: ");
            choice = Convert.ToInt32(Console.ReadLine());


            if (choice == 1)
            {
                Console.WriteLine("\nTablica od pierwszego do ostatniego indeksu:");
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Indeks {i}: {numbers[i]}");
                }
            }
            else if (choice == 2)
            {
                Console.WriteLine("\nTablica od ostatniego do pierwszego indeksu:");
                for (int i = 9; i >= 0; i--)
                {
                    Console.WriteLine($"Indeks {i}: {numbers[i]}");
                }
            }
            else if (choice == 3)
            {

                Console.WriteLine("\nElementy o nieparzystych indeksach:");
                for (int i = 1; i < 10; i += 2)
                {
                    Console.WriteLine($"Indeks {i}: {numbers[i]}");
                }
            }
            else if (choice == 4)
            {

                Console.WriteLine("\nElementy o parzystych indeksach:");
                for (int i = 0; i < 10; i += 2)
                {
                    Console.WriteLine($"Indeks {i}: {numbers[i]}");
                }
            }
            else if (choice == 5)
            {
                Console.WriteLine("Zakończenie programu.");
            }
            else
            {
                Console.WriteLine("Nieprawidłowy wybór, spróbuj ponownie.");
            }

        } while (choice != 5);
    }
}