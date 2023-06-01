public class Teacher : Person
{
    public Teacher(string name, int age, int experienceInYears, string field)
        : base(name, age)
    {
        ExperienceInYears = experienceInYears;
        Field = field;
    }

    public int ExperienceInYears { get; set; }
    public string Field { get; set; }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Experience: {ExperienceInYears}, Field: {Field}");
    }
}
