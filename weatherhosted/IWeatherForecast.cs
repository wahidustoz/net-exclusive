public interface IWeatherForecast
{
    Task<WeatherResponse> GetCityAsync(City city);
    Task<IEnumerable<KeyValuePair<string, WeatherResponse>>> GetCitiesAsync(IEnumerable<City> cities);
}