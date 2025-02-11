using System;
using System.Linq;

public class Student
{
       public string Imie { get; set; }
    public string Nazwisko { get; set; }
    private int[] oceny; 


    public Student(string imie, string nazwisko)
    {
        Imie = imie;
        Nazwisko = nazwisko;
        oceny = new int[0]; 
    }

     public double SredniaOcen
    {
        get
        {
            if (oceny.Length == 0)
            {
                return 0; 
            }
            return oceny.Average(); 
        }
    }

    public void DodajOcene(int ocena)
    {
            Array.Resize(ref oceny, oceny.Length + 1);
        oceny[oceny.Length - 1] = ocena;
    }

        public void WyswietlInformacje()
    {
        Console.WriteLine($"Student: {Imie} {Nazwisko}");
        Console.WriteLine($"Średnia ocen: {SredniaOcen:F2}");
        Console.WriteLine("Oceny: " + string.Join(", ", oceny));
    }
}

public class Program
{
    public static void Main(string[] args)
    {
             Student student = new Student("Patrycja", "Starzyk");

          student.DodajOcene(5);
        student.DodajOcene(4);
        student.DodajOcene(3);

                student.WyswietlInformacje();
    }
}
