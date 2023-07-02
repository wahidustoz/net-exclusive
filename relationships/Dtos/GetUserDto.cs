public class GetUserDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public DateTime? Birthday { get; set; }
    public string Email { get; set; }
    public string Username { get; set; }
    public GetDriverLicenseDto DriverLicense { get; set; }
}