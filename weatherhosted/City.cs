public class City
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Longitude { get; set; }
    public double Latitude { get; set; }
    
    public City(int id, string name, double longitude, double latitude)
    {
        Id = id;
        Name = name;
        Longitude = longitude;
        Latitude = latitude;
    }
}