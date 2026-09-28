namespace CowComperableApp;
class Program
{
    static void Main(string[] args)
    {
        string inputPfad = Path.Combine(AppContext.BaseDirectory, "input.txt");
        List<Cow> liste = new List<Cow>();
        foreach (string zeile in File.ReadAllLines(inputPfad))
        {
            string[] werte = zeile.Split(';');
            liste.Add(new Cow(werte[0], werte[1], int.Parse(werte[2])));
        }

        
        foreach (Cow kuh in liste)
        {
            Console.WriteLine($"{kuh.Name}, {kuh.Color}, {kuh.Age}");
        }
        liste.Sort();
        Console.WriteLine("\n\n\n");
        foreach (Cow kuh in liste)
        {
            Console.WriteLine($"{kuh.Name}, {kuh.Color}, {kuh.Age}");
        }
        Console.WriteLine("\n\n\n");
        Console.WriteLine("\nNach Coolness sortiert:");
        liste.Sort(new CowCoolnessCompare());
        foreach (Cow kuh in liste)
        {
            Console.WriteLine($"{kuh.Name}, {kuh.Color}, {kuh.Age}");
        }
        Console.WriteLine("\n\n\n");
        Console.WriteLine("\nNach Namenslaenge sortiert:");
        liste.Sort(new CowNameLenghtCompare());
        foreach (Cow kuh in liste)
        {
            Console.WriteLine($"{kuh.Name}, {kuh.Color}, {kuh.Age}");
        }
        
    }
}
