namespace CowComperableApp;

public class CowCoolnessCompare : IComparer<Cow>
{
    public CowCoolnessCompare()
    {
    }

    public int Compare(Cow? x, Cow? y)
    {
        if (x == null) return -1;
        if (y == null) return 1;
        if (ReferenceEquals(x,y)) return 0;
        
        int Coolnessx = x.Age * x.Color.Length * x.Name.Length;
        int Coolnessy = y.Age * y.Color.Length * y.Name.Length;
        return Coolnessx.CompareTo(Coolnessy);
    }
}

public class CowNameLenghtCompare : IComparer<Cow>
{
    public CowNameLenghtCompare()
    {
    }

    public int Compare(Cow? x, Cow? y)
    {
        if (x == null) return -1;
        if (y == null) return 1;
        if (ReferenceEquals(x,y)) return 0;
        
        return x.Name.Length.CompareTo(y.Name.Length);
    }
}