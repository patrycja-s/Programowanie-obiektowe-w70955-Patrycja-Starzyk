public class Uczen : Osoba
{
    public string Szkola { get; private set; }
    public bool MozeSamWracacDoDomu { get; private set; }

    public void SetSchool(string szkola) => Szkola = szkola;
    public void ChangeSchool(string nowaSzkola) => Szkola = nowaSzkola;
    public void SetCanGoHomeAlone(bool pozwolenie) => MozeSamWracacDoDomu = pozwolenie;

    public override string GetEducationInfo() => $"Uczeń szkoły: {Szkola}";

    public override bool CanGoAloneToHome()
    {
        int wiek = GetAge();
        return wiek >= 12 || MozeSamWracacDoDomu;
    }
}
