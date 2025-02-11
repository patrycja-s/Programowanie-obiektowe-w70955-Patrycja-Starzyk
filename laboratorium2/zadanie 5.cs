using System;

public class Sumator
{
    private int[] Liczby;

    public Sumator(int[] liczby)
    {
        Liczby = liczby;
    }

    public int Suma()
    {
        int suma = 0;
        foreach (int liczba in Liczby)
        {
            suma += liczba;
        }
        return suma;
    }

    public int SumaPodziel2()
    {
        int suma = 0;
        foreach (int liczba in Liczby)
        {
            if (liczba % 2 == 0)
            {
                suma += liczba;
            }
        }
        return suma;
    }

    public int IleElementów()
    {
        return Liczby.Length;
    }

    public void WypiszWszystkie()
    {
        foreach (int liczba in Liczby)
        {
            Console.WriteLine(liczba);
        }
    }

    public void WypiszZakres(int lowIndex, int highIndex)
    {
        for (int i = lowIndex; i <= highIndex; i++)
        {
            if (i >= 0 && i < Liczby.Length)
            {
                Console.WriteLine(Liczby[i]);
            }
        }
    }
}

public class Program
{
    public static void Main()
    {
        int[] liczby = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Sumator sumator = new Sumator(liczby);

        Console.WriteLine($"Suma liczb: {sumator.Suma()}");
        Console.WriteLine($"Suma liczb podzielnych przez 2: {sumator.SumaPodziel2()}");
        Console.WriteLine($"Ile elementów w tablicy: {sumator.IleElementów()}");
        sumator.WypiszWszystkie();
        sumator.WypiszZakres(2, 5);
    }
}
