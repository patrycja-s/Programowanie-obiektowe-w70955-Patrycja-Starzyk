using System;
using System.Collections.Generic;

public class Nauczyciel : Uczen
{
    public string TytulNaukowy { get; private set; }
    public List<Uczen> PodwladniUczniowie { get; private set; } = new List<Uczen>();

    public void SetTytulNaukowy(string tytul) => TytulNaukowy = tytul;
    public void DodajUcznia(Uczen uczen) => PodwladniUczniowie.Add(uczen);

    public override string GetEducationInfo() => $"{TytulNaukowy} - nauczyciel w {Szkola}";

    public void WhichStudentCanGoHomeAlone(DateTime dateToCheck)
    {
        Console.WriteLine($"Lista uczniów mogących wrócić do domu {dateToCheck.ToShortDateString()}:");

        foreach (var uczen in PodwladniUczniowie)
        {
            if (uczen.CanGoAloneToHome())
            {
                Console.WriteLine($"- {uczen.GetFullName()}");
            }
        }
    }
}
