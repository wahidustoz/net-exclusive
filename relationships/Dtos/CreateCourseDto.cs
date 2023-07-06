using System.ComponentModel.DataAnnotations;

public class CreateCourseDto
{
    [Required, MinLength(2), MaxLength(20)]
    public string Name { get; set; }
    public DateTime StartDate { get; set; }
    public int DurationInMonths { get; set; }
    public decimal Price { get; set; }
}

public class GetCourseDto
{
    public GetCourseDto(Course entity)
    {
        Id = entity.Id;
        Name = entity.Name;
        StartDate = entity.StartDate;
        DurationInMonths = entity.DurationInMonths;
        Price = entity.Price;
        StudentCount = entity.Students?.Count() ?? 0;
        Students = entity.Students?.Select(x => new GetUserDto(x));
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime StartDate { get; set; }
    public int DurationInMonths { get; set; }
    public decimal Price { get; set; }
    public int StudentCount { get; set; }
    public IEnumerable<GetUserDto> Students { get; set; }
}
