namespace CowComperableApp;
class Program
{
    static void Main(string[] args)
    {
        List<Cow> liste = new List<Cow>()
        {
            new Cow("Milka","lila",4),
            new Cow("Paula","weiss",6),
            new Cow("Conny","schwarz",4),
            new Cow("Berta","weiss",7),
            new Cow("Mathias","rosa",4),
            new Cow("Milka","rosa",4),
            new Cow("Milka","lila",5)
        };

        // List.Sort() verwendet Cow.CompareTo aus Cow.cs.
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
