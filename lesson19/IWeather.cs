public interface IWeather
{
    static IEnumerable<City> Cities { get; }
    static IEnumerable<string> GetCityNames { get; }
    Task PrintSingleCityAsync(int id);
    Task PrintSingleCityAsync(string name);
    Task PrintAllCitiesAsync();
    Task PrintRandomCityAsync();
}