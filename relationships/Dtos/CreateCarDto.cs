using System.ComponentModel.DataAnnotations;

public class CreateCarDto
{
    [Required, MinLength(2), MaxLength(20)]
    public string Brand { get; set; }
    [Required, MinLength(2), MaxLength(20)]
    public string Model { get; set; }
    public string Color { get; set; }

    [Required, CarAge(minimumAge: 0, maximumAge: 10)]
    public DateTime ManufacturedAt { get; set; }
    public Guid OwnerId { get; set; }
}
