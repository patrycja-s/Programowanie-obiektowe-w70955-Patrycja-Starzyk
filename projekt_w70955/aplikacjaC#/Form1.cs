using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace KorepetycjeApp
{
   
    public partial class Form1 : Form
    {
        private UczenManager uczenManager = new UczenManager();
        private const string sciezkaPlikuJson = "baza_uczniow.json";

        public Form1()
        {
            InitializeComponent();
            WczytajDaneZPlikuJson();
        }

        // Dodawanie ucznia
        private void buttonDodajUcznia_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxImieNazwisko.Text))
            {
                uczenManager.DodajUcznia(textBoxImieNazwisko.Text);
                AktualizujListeUczniow();
                ZapiszDaneDoPlikuJson();
                textBoxImieNazwisko.Clear();
            }
            else
            {
                MessageBox.Show("Podaj imiê i nazwisko.");
            }
        }

        // Dodawanie oceny
        private void buttonDodajOcene_Click(object sender, EventArgs e)
        {
            var uczen = listBoxUczniowie.SelectedItem as Uczen;
            if (uczen != null && int.TryParse(textBoxOcena.Text, out int ocena))
            {
                uczenManager.DodajOcene(uczen, ocena);
                AktualizujListeUczniow();
                ZapiszDaneDoPlikuJson();
                textBoxOcena.Clear();
            }
            else
            {
                MessageBox.Show("Wybierz ucznia i podaj ocenê.");
            }
        }

        // Dodawanie tematu
        private void buttonDodajTemat_Click(object sender, EventArgs e)
        {
            var uczen = listBoxUczniowie.SelectedItem as Uczen;
            if (uczen != null && !string.IsNullOrWhiteSpace(textBoxTemat.Text))
            {
                uczenManager.DodajTemat(uczen, textBoxTemat.Text);
                AktualizujListeUczniow();
                ZapiszDaneDoPlikuJson();
                textBoxTemat.Clear();
            }
            else
            {
                MessageBox.Show("Wybierz ucznia i podaj temat.");
            }
        }

        // Dodawanie terminu
        private void buttonDodajTermin_Click(object sender, EventArgs e)
        {
            var uczen = listBoxUczniowie.SelectedItem as Uczen;
            if (uczen != null)
            {
                uczenManager.DodajTermin(uczen, dateTimePickerTermin.Value);
                AktualizujListeUczniow();
                ZapiszDaneDoPlikuJson();
            }
            else
            {
                MessageBox.Show("Wybierz ucznia i podaj termin.");
            }
        }

        // Usuwanie ucznia
        private void buttonUsunUcznia_Click(object sender, EventArgs e)
        {
            var uczen = listBoxUczniowie.SelectedItem as Uczen;
            if (uczen != null)
            {
                uczenManager.UsunUcznia(uczen);
                AktualizujListeUczniow();
                ZapiszDaneDoPlikuJson();
            }
            else
            {
                MessageBox.Show("Wybierz ucznia, którego chcesz usun¹æ.");
            }
        }

        // Generowanie raportu
        private void buttonGenerujRaport_Click(object sender, EventArgs e)
        {
            var uczen = listBoxUczniowie.SelectedItem as Uczen;
            if (uczen != null)
            {
                string raport = $"Raport dla: {uczen.ImieNazwisko}\n";
                raport += "Oceny: " + string.Join(", ", uczen.Oceny.Select(o => o.Wartosc)) + "\n";
                raport += "Tematy: " + string.Join(", ", uczen.Tematy.Select(t => t.Nazwa)) + "\n";
                raport += "Terminy: " + string.Join(", ", uczen.Terminy.Select(t => t.Data.ToString("dd/MM/yyyy"))) + "\n";

                MessageBox.Show(raport);
            }
            else
            {
                MessageBox.Show("Wybierz ucznia.");
            }
        }

        // Aktualizowanie listy uczniów 
        private void AktualizujListeUczniow()
        {
            listBoxUczniowie.Items.Clear();
            foreach (var uczen in uczenManager.Uczniowie)
            {
                listBoxUczniowie.Items.Add(uczen);
            }
        }

        // Zapisz dane do pliku JSON
        private void ZapiszDaneDoPlikuJson()
        {
            JsonHandler.ZapiszDaneDoPlikuJson(uczenManager.Uczniowie, sciezkaPlikuJson);
        }

        // Wczytaj dane z pliku JSON
        private void WczytajDaneZPlikuJson()
        {
            uczenManager = JsonHandler.WczytajDaneZPlikuJson(sciezkaPlikuJson);
            AktualizujListeUczniow();
        }
    }

    // Klasa Uczen
    public class Uczen
    {
        public string ImieNazwisko { get; set; }
        public List<Ocena> Oceny { get; set; } = new List<Ocena>();
        public List<Temat> Tematy { get; set; } = new List<Temat>();
        public List<Termin> Terminy { get; set; } = new List<Termin>();

        public override string ToString()
        {
            return $"{ImieNazwisko}";
        }
    }

    // Klasa Ocena
    public class Ocena
    {
        public int Wartosc { get; set; }
    }

    // Klasa Temat
    public class Temat
    {
        public string Nazwa { get; set; }
    }

    // Klasa Termin
    public class Termin
    {
        public DateTime Data { get; set; }
    }

    // Klasa UczenManager 
    public class UczenManager
    {
        public List<Uczen> Uczniowie { get; set; } = new List<Uczen>();

        public void DodajUcznia(string imieNazwisko)
        {
            Uczniowie.Add(new Uczen { ImieNazwisko = imieNazwisko });
        }

        public void DodajOcene(Uczen uczen, int ocena)
        {
            uczen.Oceny.Add(new Ocena { Wartosc = ocena });
        }

        public void DodajTemat(Uczen uczen, string temat)
        {
            uczen.Tematy.Add(new Temat { Nazwa = temat });
        }

        public void DodajTermin(Uczen uczen, DateTime termin)
        {
            uczen.Terminy.Add(new Termin { Data = termin });
        }

        public void UsunUcznia(Uczen uczen)
        {
            Uczniowie.Remove(uczen);
        }
    }

    // Klasa JsonHandler -obs³uguje zapis i odczyt z pliku JSON
    public static class JsonHandler
    {
        public static void ZapiszDaneDoPlikuJson(List<Uczen> uczniowie, string sciezka)
        {
            try
            {
                var json = JsonConvert.SerializeObject(uczniowie, Formatting.Indented);
                File.WriteAllText(sciezka, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"B³¹d zapisu danych do pliku JSON: {ex.Message}");
            }
        }

        public static UczenManager WczytajDaneZPlikuJson(string sciezka)
        {
            try
            {
                if (File.Exists(sciezka))
                {
                    var json = File.ReadAllText(sciezka);
                    var uczniowie = JsonConvert.DeserializeObject<List<Uczen>>(json) ?? new List<Uczen>();
                    return new UczenManager { Uczniowie = uczniowie };
                }
                return new UczenManager();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"B³¹d wczytywania danych z pliku JSON: {ex.Message}");
                return new UczenManager();
            }
        }
    }
}
