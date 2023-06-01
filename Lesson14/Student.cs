public class Student : IEquatable<Student>, IComparable<Student>
{
    public int Id { get; set; }
    public string Name { get; set; }

    public override bool Equals(object obj)
    {
        return obj is Student s && Equals(s);
    }

    public override int GetHashCode()
    {
        return Id;
    }

    public bool Equals(Student other)
    {
        if(other is null) return false;
        return other.Id.Equals(Id);
    }

    public int CompareTo(Student other)
    {
        if(Id > other.Id) return 1;
        else if (Id < other.Id) return -1;
        else return 0;
    }
}