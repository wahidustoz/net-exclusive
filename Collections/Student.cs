public class Student
{
    public Student(int id, string name, double grade)
    {
        Id = id;
        Name = name;
        Grade = grade;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public double Grade { get; set; }
}