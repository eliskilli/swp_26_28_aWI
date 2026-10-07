while (true)
{
    Console.WriteLine("Write whats on your mind:");
    string userInput = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(userInput))
        continue;

    Console.WriteLine("Your Answer is:" + userInput);

    string type = userInput switch
    {
        _ when bool.TryParse(userInput, out _) => "Bool",
        _ when int.TryParse(userInput, out _) => "Integer",
        _ when double.TryParse(userInput, out _) => "rational number",
        _ => "String"
    };

    Console.WriteLine("Thats a " + type);
}