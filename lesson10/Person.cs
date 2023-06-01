public class Person
{
    public int Age { get; set; }
    public string Name { get; set; }
    public int Id { get; set; }

    protected int internalId = 1;

    private static int currentId = 0;

    public Person(string name, int age)
    {
        Age = age;
        Name = name;
        Id = GetNextId();
    }

    private int GetNextId() => ++currentId;

    public virtual void Display()
    {
        Console.WriteLine($"Person -> Name: {Name}, Age: {Age}, ID: {Id}");
    }
}
