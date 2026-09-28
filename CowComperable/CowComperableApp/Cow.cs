namespace CowComperableApp;

public class Cow : IEquatable<Cow>, IComparable<Cow>
{
  public string Name { get; private set; }  
  public string Color { get; private set; }
  public int Age { get; private set; }

  public Cow(string name, string color, int age)
  {
    Name = name;
    Color = color;
    Age = age;
  }

  public bool Equals(Cow? other)
  {
    if (other is null) return false;
    if (ReferenceEquals(this, other)) return true;
    return Name == other.Name && Color == other.Color && Age == other.Age;
  }

  public int CompareTo(Cow? other)
  {
    if (other is null) return 1;
    if (ReferenceEquals(this, other)) return 0;
    if (Name == other.Name)
    {
      if (Color == other.Color)
      {
        return Age.CompareTo(other.Age);
      }
      else
      {
        return Color.CompareTo(other.Color);
      }
    }
    else
    {
      return Name.CompareTo(other.Name);
    }
  }

  public override bool Equals(object? obj)
  {
    if (obj is null) return false;
    if (ReferenceEquals(this, obj)) return true;
    if (obj.GetType() != GetType()) return false;
    return Equals((Cow)obj);
  }

  public override int GetHashCode()
  {
    return HashCode.Combine(Name, Color, Age);
  }
}
