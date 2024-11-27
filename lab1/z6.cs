//Napisz program, który w nieskończoność pyta użytkownika o liczby całkowite. Pętla
//nieskończona powinna się zakończyć gdy użytkownik wprowadzi liczbę mniejszą od zera. Do
//opuszczenia pętli nieskończonej użyj instrukcji break. Pętle nieskończoną realizuje się
//następującymi konstrukcjami:
//while (true)
//{ ciało pętli }
//lub
//for(; ;)
//{ ciało pętli }
using System;

internal class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Podaj liczbę całkowitą: ");
            int liczba = int.Parse(Console.ReadLine());

            if (liczba < 0)
            {
                Console.WriteLine("Wprowadzono liczbę mniejszą od zera. Kończę program.");
                break;
            }


            Console.WriteLine($"Podana liczba to: {liczba}");
        }
    }
}

