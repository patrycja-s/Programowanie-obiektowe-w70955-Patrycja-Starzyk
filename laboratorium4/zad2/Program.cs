using System;

class Program
{
    static void Main()
    {
        // Tworzenie nauczyciela
        Nauczyciel nauczyciel = new Nauczyciel();
        nauczyciel.SetFirstName("Jan");
        nauczyciel.SetLastName("Kowalski");
        nauczyciel.SetPesel("81020312345"); 
        nauczyciel.SetSchool("Liceum Ogólnokształcące");
        nauczyciel.SetTytulNaukowy("Magister");

        // Tworzenie uczniów
        Uczen uczen1 = new Uczen();
        uczen1.SetFirstName("Anna");
        uczen1.SetLastName("Nowak");
        uczen1.SetPesel("12051234567"); 
        uczen1.SetSchool("Liceum Ogólnokształcące");
        uczen1.SetCanGoHomeAlone(true); // Ma pozwolenie

        Uczen uczen2 = new Uczen();
        uczen2.SetFirstName("Tomasz");
        uczen2.SetLastName("Wiśniewski");
        uczen2.SetPesel("15082167890"); 
        uczen2.SetSchool("Liceum Ogólnokształcące");
        uczen2.SetCanGoHomeAlone(false); // Nie ma pozwolenia

        // Dodanie uczniów do listy nauczyciela
        nauczyciel.DodajUcznia(uczen1);
        nauczyciel.DodajUcznia(uczen2);

        // Sprawdzenie, kto może wrócić do domu sam
        nauczyciel.WhichStudentCanGoHomeAlone(DateTime.Now);
    }
}
