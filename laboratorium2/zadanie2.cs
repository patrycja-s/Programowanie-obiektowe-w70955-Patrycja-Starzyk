using System;

class BankAccount
{
    public string Wlasciciel { get; }
    public decimal Saldo { get; private set; }

    public BankAccount(string wlasciciel, decimal poczatkoweSaldo)
    {
        Wlasciciel = wlasciciel;
        Saldo = poczatkoweSaldo;
    }

    public void Wplata(decimal kwota)
    {
        if (kwota <= 0)
        {
            Console.WriteLine("Kwota wpłaty musi być większa niż zero.");
            return;
        }
        Saldo += kwota;
        Console.WriteLine($"Wpłacono {kwota}. Nowe saldo: {Saldo}");
    }

    public void Wyplata(decimal kwota)
    {
        if (kwota <= 0)
        {
            Console.WriteLine("Kwota wypłaty musi być większa niż zero.");
            return;
        }
        if (kwota > Saldo)
        {
            Console.WriteLine("Brak wystarczających środków na koncie.");
            return;
        }
        Saldo -= kwota;
        Console.WriteLine($"Wypłacono {kwota}. Nowe saldo: {Saldo}");
    }
}

class Program
{
    static void Main()
    {
        BankAccount konto = new BankAccount("Patrycja Starzyk", 1000);
        konto.Wplata(500);
        konto.Wyplata(200);
        Console.WriteLine($"Saldo: {konto.Saldo}");
    }
}
