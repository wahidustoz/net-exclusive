using System.ComponentModel.DataAnnotations;

public class Student
{
    [Key]       // attribute configuration
    public int Id { get; set;} 

    [Required, MaxLength(255)]
    public string Name { get; set;}

    public int Age { get; set; }

    [Required, MaxLength(255)]
    public string Email { get; set;}

    public DateTime EnrolledDate { get; set; }

    public string Phone { get; set; }
}