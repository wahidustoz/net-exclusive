using System.Collections.Concurrent;
using System.Net.Http.Json;

public class WeatherForecast : IWeatherForecast
{
    private readonly HttpClient httpClient;
    private readonly ConcurrentDictionary<string, WeatherResponse> concurrentWeathers;


    public WeatherForecast(IHttpClientFactory clientFactory)
    {
        this.httpClient = clientFactory.CreateClient("OpenMeteo");
        this.concurrentWeathers = new ConcurrentDictionary<string, WeatherResponse>();
    }

    public Task<WeatherResponse> GetCityAsync(City city)
        => GetCityWeatherAsync(city);

    public async Task<IEnumerable<KeyValuePair<string, WeatherResponse>>> GetCitiesAsync(IEnumerable<City> cities)
    {
        concurrentWeathers.Clear();
        
        var downloadTasks = new List<Task>();
        foreach(var city in cities)
        {
            downloadTasks.Add(AddWeatherToDictionaryAsync(city));
        }

        try
        {
            await Task.WhenAll(downloadTasks);
        }
        catch (Exception ex)
        {
            var message = 
$@"Error downloading weather:
{ex.Message}";
            throw new Exception(message, ex);
        }

        return concurrentWeathers;
    }

    private async Task AddWeatherToDictionaryAsync(City city)
        => concurrentWeathers.TryAdd(city.Name,  await GetCityWeatherAsync(city));

    private Task<WeatherResponse> GetCityWeatherAsync(City city)
    {
       var route = $"/v1/forecast?latitude={city.Latitude}&longitude={city.Longitude}&current_weather=true";
        try
        {
            return httpClient.GetFromJsonAsync<WeatherResponse>(route);
        }
        catch (Exception ex)
        {
            var message = 
$@"Error downloading weather for {city.Name}:
{ex.Message}";
            throw new Exception(message, ex);
        }
    }
}
