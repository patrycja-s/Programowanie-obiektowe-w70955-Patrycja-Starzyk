//Napisz program wyświetlający liczby od 20-0, z wyłączeniem liczb {2,6,9,15,19}. Do realizacji
// wyłączenia użyj instrukcji continue;

using System;

internal class Program
{
    static void Main()
    {

        for (int i = 20; i >= 0; i--)
        {

            if (i == 2 || i == 6 || i == 9 || i == 15 || i == 19)
            {
                continue;
            }


            Console.WriteLine(i);
        }
    }
}
