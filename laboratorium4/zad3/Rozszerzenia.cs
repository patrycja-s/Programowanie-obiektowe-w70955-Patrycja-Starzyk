using System;
using System.Collections.Generic;
using System.Linq;

public static class Rozszerzenia
{
    public static void WypiszOsoby(this List<IOsoba> osoby)
    {
        foreach (var osoba in osoby)
        {
            Console.WriteLine(osoba.ZwrocPelnaNazwe());
        }
    }

    public static void PosortujOsobyPoNazwisku(this List<IOsoba> osoby)
    {
        osoby.Sort((x, y) => x.Nazwisko.CompareTo(y.Nazwisko));
    }
}
