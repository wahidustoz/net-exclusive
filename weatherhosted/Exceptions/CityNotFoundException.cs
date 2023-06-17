public class CityNotFoundException : Exception
{
    public CityNotFoundException(int id)
        : base($"City with ID {id} does not exist.") { }
    
    public CityNotFoundException(string name)
        : base($"City with NAME {name} does not exist.") { }
}