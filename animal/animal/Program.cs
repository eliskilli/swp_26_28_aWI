List<Animal> animals = [new Cow(), new Cat()];

foreach (Animal animal in animals)
{
    animal.MakeSound();
}

public abstract class Animal
{
    public abstract void MakeSound();
}

public sealed class Cow : Animal
{
    public override void MakeSound() => Console.WriteLine("Muuuuh");
}

public sealed class Cat : Animal
{
    public override void MakeSound() => Console.WriteLine("Miau");
}