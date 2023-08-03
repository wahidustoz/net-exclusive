public interface IHasTimestamp
{
    public DateTime CreatedAt { get; set; }
    public DateTime ModifiedAt { get; set; }
}