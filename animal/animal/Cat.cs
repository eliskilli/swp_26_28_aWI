namespace FirstOOP;

public class Cat(string name, string color, DateTime birthDate)
    : Animal(name, color, birthDate)
{
    public override string MakeSound() => "Meow";

    public string MakeSound(int times) =>
        string.Join("\n", Enumerable.Repeat(MakeSound(), times));
}