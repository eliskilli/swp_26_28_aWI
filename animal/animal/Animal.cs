namespace FirstOOP;

public abstract class Animal
{
    protected Animal(string name, string color, DateTime birthDate)
    {
        if (birthDate.Date > DateTime.Today)
        {
            throw new ArgumentException("Geburtsdatum liegt in der Zukunft");
        }

        Name = name;
        Color = color;
        BirthDate = birthDate.Date;
    }

    public string Name { get; }
    public string Color { get; set; }
    public DateTime BirthDate { get; }

    public int Age
    {
        get
        {
            DateTime today = DateTime.Today;
            int age = today.Year - BirthDate.Year;
            bool birthdayIsStillAhead = today < BirthDate.AddYears(age);
            return birthdayIsStillAhead ? age - 1 : age;
        }
    }

    public abstract string MakeSound();
}