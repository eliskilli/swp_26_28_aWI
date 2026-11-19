using FirstOOP;

Animal cow = new Cow("Kuh1", "weiß", new DateTime(2020, 5, 15));
Cat cat = new Cat("Katze1", "schwarz", new DateTime(2023, 12, 1));

List<Animal> animals = [cow, cat];
foreach (Animal animal in animals)
{
    Console.WriteLine($"{animal.Name} ({animal.Age} Jahre): {animal.MakeSound()}");
}

Console.WriteLine(cat.MakeSound(3));