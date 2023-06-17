public class OpenMeteoClient
{
    private readonly HttpClient httpClient;

    public OpenMeteoClient(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }
    public Task<WeatherResponse> GetWeatherAsync(double longitude, double latitude)
    {
        var route = $"/v1/forecast?latitude={latitude}&longitude={longitude}&current_weather=true";
        return httpClient.GetFromJsonAsync<WeatherResponse>(route);
    }
}