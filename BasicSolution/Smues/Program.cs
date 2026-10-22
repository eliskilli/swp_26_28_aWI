while (true)
{
    Console.WriteLine("Geben Sie etwas ein:");
    string? input = Console.ReadLine();

    if (int.TryParse(input, out int zahl))
    {
        Console.WriteLine("Sie haben eine ganze Zahl eingegeben, welche mathematische Operation möchten Sie darauf ausfuehren?");
        Console.WriteLine("1) Addition");
        Console.WriteLine("2) Multiplikation");
        Console.WriteLine("3) Division");
        Console.WriteLine("4) Fakultuat");
        Console.WriteLine("5) Wurzelziehen");

        string? auswahl = Console.ReadLine();

        if (auswahl == "1")
        {
            Console.WriteLine("Geben Sie eine zweite ganze Zahl ein:");
            int zweiteZahl = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"Ergebnis: {zahl + zweiteZahl}");
        }

        if (auswahl == "2")
        {
            Console.WriteLine("Geben Sie eine zweite ganze Zahl ein:");
            int zweiteZahl = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"Ergebnis: {zahl * zweiteZahl}");
        }

        if (auswahl == "3")
        {
            Console.WriteLine("Geben Sie eine zweite Zahl ein:");
            double zweiteZahl = double.Parse(Console.ReadLine()!);
            Console.WriteLine($"Ergebnis: {zahl / zweiteZahl}");
        }

        if (auswahl == "4")
        {
            int ergebnis = 1;

            for (int i = 1; i <= zahl; i++)
            {
                ergebnis = ergebnis * i;
            }

            Console.WriteLine($"Fakultuat: {ergebnis}");
        }

        if (auswahl == "5")
        {
            Console.WriteLine($"Wurzel: {Math.Sqrt(zahl)}");
        }
    }
    else
    {
        Console.WriteLine("Sie haben eine Zeichenkette eingegeben. Was wollen Sie damit machen?");
        Console.WriteLine("1) Alle Selbstlaute (a,e,i,o,u) entfernen");
        Console.WriteLine("2) Die Zeichenkette umdrehen");
        Console.WriteLine("3) Die Anzahl an Zeichen ausgeben");

        string? auswahl = Console.ReadLine();

        if (auswahl == "1")
        {
            string ergebnis = input!
                .Replace("a", "")
                .Replace("e", "")
                .Replace("i", "")
                .Replace("o", "")
                .Replace("u", "")
                .Replace("A", "")
                .Replace("E", "")
                .Replace("I", "")
                .Replace("O", "")
                .Replace("U", "");

            Console.WriteLine(ergebnis);
        }

        if (auswahl == "2")
        {
            string umgedreht = "";

            for (int i = input!.Length - 1; i >= 0; i--)
            {
                umgedreht = umgedreht + input[i];
            }

            Console.WriteLine(umgedreht);
        }

        if (auswahl == "3")
        {
            Console.WriteLine(input!.Length);
        }
    }
}
