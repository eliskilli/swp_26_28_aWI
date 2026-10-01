Console.WriteLine("Whats 9x7+4?:");
int number;

while (!int.TryParse(Console.ReadLine(), out number))
{
    Console.WriteLine("Das ist keine Zahl, bitte nochmals eingeben:");
}

Console.WriteLine("Your Answer is:" + number);

if (number == 67)
{
    Console.WriteLine("Correct Answer!");
}
else
{
    Console.WriteLine("Wrong Answer!");
}

