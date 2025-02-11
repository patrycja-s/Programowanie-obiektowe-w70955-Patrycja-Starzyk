using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<IOsoba> osoby = new List<IOsoba>
        {
            new Osoba("Jan", "Kowalski"),
            new Osoba("Anna", "Nowak"),
            new Student("Piotr", "Zieliński", "Politechnika", "Informatyka", 2, 4),
            new StudentWSIiZ("Marta", "Lewandowska", "4IID-P", 2018, 1)
        };

        Console.WriteLine("Osoby przed sortowaniem:");
        osoby.WypiszOsoby();

        osoby.PosortujOsobyPoNazwisku();

        Console.WriteLine("\nOsoby po sortowaniu:");
        osoby.WypiszOsoby();

        Console.WriteLine("\nInformacje o studentach:");
        foreach (var osoba in osoby)
        {
            if (osoba is Student student)
            {
                Console.WriteLine(student.WypiszPelnaNazweIUczelnie());
            }
        }
    }
}
