while (true)
{
    Console.WriteLine("Write whats on your mind:");
    string? userInput = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(userInput))
        continue;

    Console.WriteLine("Your Answer is: " + userInput);

    string type = userInput switch
    {
        _ when bool.TryParse(userInput, out _) => "Bool",
        _ when int.TryParse(userInput, out _) => "Integer",
        _ when double.TryParse(userInput, out _) => "rational number",
        _ => "String"
    };

    Console.WriteLine("Thats a " + type);

    if (type == "Integer")
    {
        int number = int.Parse(userInput);

        Console.WriteLine("Geben Sie eine Zahl zwischen 1 und 3 ein um eine Mathematische Operation auszuwählen:");
        Console.WriteLine("1) Quadrat\n2) Wurzel\n3) Fakultät");

        string? choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.WriteLine("Das Quadrat von " + number + " ist: " + (number * number));
                break;
            case "2":
                Console.WriteLine("Die Wurzel von " + number + " ist: " + Math.Sqrt(number));
                break;
            case "3":
                Console.WriteLine("Die Fakultät von " + number + " ist: " + Factorial(number));
                break;
            default:
                Console.WriteLine("Ungültige Auswahl.");
                break;
        }
    }
}

static long Factorial(int n)
{
    if (n < 0) return 0;
    long result = 1;
    for (int i = 2; i <= n; i++)
    {
        result *= i;
    }
    return result;
}