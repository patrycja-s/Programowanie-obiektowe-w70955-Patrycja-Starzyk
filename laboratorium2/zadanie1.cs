using System;

class Osoba
{
    private string imie;
    private string nazwisko;
    private int wiek;

    public string Imie
    {
        get { return imie; }
        set
        {
            if (value.Length < 2)
                throw new ArgumentException("Imię musi mieć co najmniej 2 znaki.");
            imie = value;
        }
    }

    public string Nazwisko
    {
        get { return nazwisko; }
        set
        {
            if (value.Length < 2)
                throw new ArgumentException("Nazwisko musi mieć co najmniej 2 znaki.");
            nazwisko = value;
        }
    }

    public int Wiek
    {
        get { return wiek; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("Wiek musi być liczbą dodatnią.");
            wiek = value;
        }
    }

    public Osoba(string imie, string nazwisko, int wiek)
    {
        Imie = imie;
        Nazwisko = nazwisko;
        Wiek = wiek;
    }

    public void WyswietlInformacje()
    {
        Console.WriteLine($"Imię: {Imie}, Nazwisko: {Nazwisko}, Wiek: {Wiek}");
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Osoba osoba = new Osoba("Patrycja", "Starzyk", 20);
            osoba.WyswietlInformacje();
        }
        catch (Exception e)
        {
            Console.WriteLine("Błąd: " + e.Message);
        }
    }
}
