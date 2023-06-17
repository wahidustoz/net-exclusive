public interface IWeather
{
    IEnumerable<City> Cities { get; }
    IEnumerable<string> GetCityNames();
    Task PrintSingleCityAsync(int id);
    Task PrintSingleCityAsync(string name);
    Task PrintAllCitiesAsync();
    Task PrintRandomCityAsync();
}