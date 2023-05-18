public struct User
{
    public int Age { get; set; }
    public string Name { get; set; }
    public Gender Gender { get; set; }


    public void Read()
    {
        var input = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        Age = int.Parse(input[0]); 
        Name = input[1]; 
        Gender = Enum.Parse<Gender>(input[2], true); 
    }

    public override string ToString()
        => $"{Name} {Age} {Gender}";
}

public enum Gender
{
    Male,
    Female
}