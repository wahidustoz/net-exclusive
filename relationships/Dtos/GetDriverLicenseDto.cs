public class GetDriverLicenseDto
{
    public Guid Id { get; set; }
    public string Serial { get; set; }
    public DateTime IssuedDate { get; set; }
    public DateTime ExpirationDate { get; set; }
    public bool IsExpired => ExpirationDate < DateTime.UtcNow;
}