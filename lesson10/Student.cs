
public class Student : Person
{
    public double Grade { get; set; }
    public string Class { get; set; }

    public Student(string name, int age, double grade, string @class)
        : base(name, age)
    {
        Grade = grade;
        Class = @class;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Grade: {Grade}, Class: {Class}");
    }
}
