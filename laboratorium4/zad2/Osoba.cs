using System;

public abstract class Osoba
{
    public string Imie { get; private set; }
    public string Nazwisko { get; private set; }
    public string Pesel { get; private set; }

    public void SetFirstName(string imie) => Imie = imie;
    public void SetLastName(string nazwisko) => Nazwisko = nazwisko;
    public void SetPesel(string pesel) => Pesel = pesel;

    public int GetAge()
    {
        int rok = int.Parse(Pesel.Substring(0, 2));
        int miesiac = int.Parse(Pesel.Substring(2, 2));

        if (miesiac > 12) // Korekta dla osób urodzonych po 2000 roku
            rok += 2000;
        else
            rok += 1900;

        return DateTime.Now.Year - rok;
    }

    public string GetGender()
    {
        int genderDigit = int.Parse(Pesel[9].ToString());
        return (genderDigit % 2 == 0) ? "Kobieta" : "Mężczyzna";
    }

    public abstract string GetEducationInfo();
    public string GetFullName() => $"{Imie} {Nazwisko}";
    public abstract bool CanGoAloneToHome();
}
