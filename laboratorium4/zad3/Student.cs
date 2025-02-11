public class Student : Osoba, IStudent
{
    public string Uczelnia { get; set; }
    public string Kierunek { get; set; }
    public int Rok { get; set; }
    public int Semestr { get; set; }

    public Student(string imie, string nazwisko, string uczelnia, string kierunek, int rok, int semestr)
        : base(imie, nazwisko)
    {
        Uczelnia = uczelnia;
        Kierunek = kierunek;
        Rok = rok;
        Semestr = semestr;
    }

    public string WypiszPelnaNazweIUczelnie()
    {
        return $"{ZwrocPelnaNazwe()} – {Kierunek} {Rok} {Uczelnia}";
    }
}
