namespace FirstOOP;

public class Cow(string name, string color, DateTime birthDate)
    : Animal(name, color, birthDate)
{
    public override string MakeSound() => "Moo";
}