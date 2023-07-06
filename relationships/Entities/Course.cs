public class Course
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime StartDate { get; set; }
    public int DurationInMonths { get; set; }
    public decimal Price { get; set; }

    public List<User> Students { get; set; } = new List<User>();
}