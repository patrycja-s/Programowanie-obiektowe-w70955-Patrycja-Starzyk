using System;

public class Licz
{
    private int value;

    public Licz(int initialValue)
    {
        value = initialValue;
    }

    public void Dodaj(int liczba)
    {
        value += liczba;
    }

    public void Odejmij(int liczba)
    {
        value -= liczba;
    }

    public void WypiszStan()
    {
        Console.WriteLine($"Aktualna wartość: {value}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Licz liczba1 = new Licz(10);
        Licz liczba2 = new Licz(25);

        liczba1.WypiszStan();
        liczba2.WypiszStan();

        liczba1.Dodaj(5);
        liczba1.WypiszStan();

        liczba2.Odejmij(10);
        liczba2.WypiszStan();
    }
}
