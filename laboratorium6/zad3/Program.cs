using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

class PopulationData
{
    public int Year { get; set; }
    public long Population { get; set; }
}

class Program
{
    static void Main()
    {
        // Wczytanie danych z pliku JSON
        var data = LoadDataFromJson("db.json");

        Console.WriteLine("Wybierz opcję:");
        Console.WriteLine("1. Różnica populacji w Indiach między 1970 a 2000.");
        Console.WriteLine("2. Różnica populacji w USA między 1965 a 2010.");
        Console.WriteLine("3. Różnica populacji w Chinach między 1980 a 2018.");
        Console.WriteLine("4. Wybierz kraj i rok, aby sprawdzić populację.");
        Console.WriteLine("5. Różnica populacji w zadanym zakresie lat i kraju.");
        Console.WriteLine("6. Procentowy wzrost populacji dla każdego kraju.");

        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                // Różnica populacji w Indiach między 1970 a 2000
                Console.WriteLine("Różnica populacji w Indiach między 1970 a 2000: " + CalculatePopulationDifference(data["India"], 1970, 2000));
                break;
            case 2:
                // Różnica populacji w USA między 1965 a 2010
                Console.WriteLine("Różnica populacji w USA między 1965 a 2010: " + CalculatePopulationDifference(data["USA"], 1965, 2010));
                break;
            case 3:
                // Różnica populacji w Chinach między 1980 a 2018
                Console.WriteLine("Różnica populacji w Chinach między 1980 a 2018: " + CalculatePopulationDifference(data["China"], 1980, 2018));
                break;
            case 4:
                // Wybór roku i kraju
                Console.WriteLine("Podaj kraj (USA, India, China):");
                string selectedCountry = Console.ReadLine();
                Console.WriteLine("Podaj rok:");
                int year;
                if (!int.TryParse(Console.ReadLine(), out year))
                {
                    Console.WriteLine("Podano niepoprawny rok.");
                    return; // Zakończ działanie programu
                }
                if (data.ContainsKey(selectedCountry))
                {
                    Console.WriteLine($"Populacja w {selectedCountry} w roku {year}: {GetPopulation(data[selectedCountry], year)}");
                }
                else
                {
                    Console.WriteLine("Nie znaleziono danych dla tego kraju.");
                }
                break;
            case 5:
                // Różnica populacji w zadanym zakresie lat i kraju
                Console.WriteLine("Podaj kraj (USA, India, China):");
                string countryForRange = Console.ReadLine();
                Console.WriteLine("Podaj początkowy rok:");
                int startYear = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj końcowy rok:");
                int endYear = int.Parse(Console.ReadLine());
                if (data.ContainsKey(countryForRange))
                {
                    Console.WriteLine($"Różnica populacji w {countryForRange} między {startYear} a {endYear}: {CalculatePopulationDifference(data[countryForRange], startYear, endYear)}");
                }
                else
                {
                    Console.WriteLine("Nie znaleziono danych dla tego kraju.");
                }
                break;
            case 6:
                // Procentowy wzrost populacji
                foreach (var country in data.Keys)
                {
                    Console.WriteLine($"Procentowy wzrost populacji dla {country}:");
                    CalculatePopulationGrowthPercentage(data[country]);
                }
                break;
        }
    }

    static Dictionary<string, List<PopulationData>> LoadDataFromJson(string filePath)
    {
        string json = File.ReadAllText(filePath);
        return JsonConvert.DeserializeObject<Dictionary<string, List<PopulationData>>>(json);
    }

    static long CalculatePopulationDifference(List<PopulationData> countryData, int startYear, int endYear)
    {
        long startPopulation = GetPopulation(countryData, startYear);
        long endPopulation = GetPopulation(countryData, endYear);
        return endPopulation - startPopulation;
    }

    static long GetPopulation(List<PopulationData> countryData, int year)
    {
        var yearData = countryData.Find(x => x.Year == year);
        if (yearData != null)
        {
            return yearData.Population;
        }
        return 0;
    }

    static void CalculatePopulationGrowthPercentage(List<PopulationData> countryData)
    {
        for (int i = 1; i < countryData.Count; i++)
        {
            long previousPopulation = countryData[i - 1].Population;
            long currentPopulation = countryData[i].Population;
            double growthPercentage = ((double)(currentPopulation - previousPopulation) / previousPopulation) * 100;
            Console.WriteLine($"{countryData[i].Year}: {growthPercentage:F2}%");
        }
    }
}
