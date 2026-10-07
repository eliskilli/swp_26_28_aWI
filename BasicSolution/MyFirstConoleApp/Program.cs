while (true)
{
    Console.WriteLine("Write whats on your mind:");
    string userInput = Console.ReadLine();
    Console.WriteLine("Your Answer is:" + userInput);

    if (bool.TryParse(userInput, out bool b))
        Console.WriteLine("Thats a Bool");
    else if (int.TryParse(userInput, out int i))
        Console.WriteLine("Thats an Integer");
    else if (double.TryParse(userInput, out double d))
        Console.WriteLine("Thats a rational number");
    else
        Console.WriteLine("Thats a String");
}