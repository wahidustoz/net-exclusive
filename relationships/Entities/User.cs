public class User
{
    public Guid Id { get; set; }
    public string Username { get; set; }
    public string Name { get; set; }
    public DateTime? Birthday { get; set; }
    public string Email { get; set; }

    public virtual DriverLicense DriverLicense { get; set; }
    public virtual ICollection<Car> Cars { get; set; }
    public List<Course> Cources { get; set; } = new List<Course>();
}
