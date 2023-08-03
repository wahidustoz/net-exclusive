public class Student : IHasTimestamp
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Birthday { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime ModifiedAt { get; set; }
}