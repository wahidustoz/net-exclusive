public class Weather : IWeather
{
    private readonly IWeatherForecast weatherForecast;

    public Weather(IWeatherForecast weatherForecast)
    {
        this.weatherForecast = weatherForecast;
    }

    public IEnumerable<City> Cities => new List<City>()
    {
        new City(id: 1, name: "New York", latitude: 40.712776, longitude:0 -74.005974),
        new City(id: 2, name: "Seoul", latitude: 37.566536, longitude: 126.977966 ),
        new City(id: 3, name: "Ottawa", latitude: 45.424721, longitude: -75.695000),
        new City(id: 4, name: "Tailand", latitude: 13.753960, longitude: 100.502243),
        new City(id: 5, name: "Berlin", latitude: 52.520008, longitude: 13.404954),
        new City(id: 6, name: "Toshkent", latitude: 41.299496, longitude: 13.404954),
        new City(id: 7, name: "Paris", latitude: 48.8566, longitude: 2.35227),
        new City(id: 8, name: "Istanbul", latitude: 41.008240, longitude: 28.978359),
        new City(id: 9, name: "Safiya", latitude: 26.758060, longitude: 80.327179),
        new City(id: 10, name: "Mecca", longitude: 21.422510, latitude: 39.826168),
        new City(id: 11, name: "Madinah",latitude: 24.524654, longitude: 39.569183)
    };

    public IEnumerable<string> GetCityNames() => Cities.Select(c => c.Name);

    public async Task PrintAllCitiesAsync()
    {
        try
        {
            var weatherResponses = await weatherForecast.GetCitiesAsync(Cities);
            foreach(var response in weatherResponses)
                PrintTemperature(response.Key, response.Value.CurrentWeather.Temperature);
        }
        catch (Exception ex)
        {
            PrintException(ex);
        }
    }

    public Task PrintRandomCityAsync()
    {
        throw new NotImplementedException();
    }

    public Task PrintSingleCityAsync(int id)
    {
        var city = Cities.FirstOrDefault(c => c.Id == id);
        if (city == null)
            throw new CityNotFoundException(id);
        
        return PrintSingleCityAsync(city);
    }

    public Task PrintSingleCityAsync(string name)
    {
        var city = Cities.FirstOrDefault(c => string.Equals(c.Name, name, StringComparison.InvariantCultureIgnoreCase));
        if (city == null)
            throw new CityNotFoundException(name);
        
        return PrintSingleCityAsync(city);
    }

    private async Task PrintSingleCityAsync(City city)
    {
        var cityWeather = await weatherForecast.GetCityAsync(city);
        PrintTemperature(city.Name, cityWeather.CurrentWeather.Temperature);
    }

    private void PrintTemperature(string cityName, double temperature)
    {
        var color = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.Write($"{cityName}: ");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"{temperature:F2}°");
        Console.ForegroundColor = color;
    }

    private void PrintException(Exception ex)
    {
        var color = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(ex.Message);
        Console.ForegroundColor = color;
    }
}

public class WeatherV2 : IWeather
{
    public IEnumerable<City> Cities => throw new NotImplementedException();

    public IEnumerable<string> GetCityNames()
    {
        throw new NotImplementedException();
    }

    public Task PrintAllCitiesAsync()
    {
        throw new NotImplementedException();
    }

    public Task PrintRandomCityAsync()
    {
        throw new NotImplementedException();
    }

    public Task PrintSingleCityAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task PrintSingleCityAsync(string name)
    {
        throw new NotImplementedException();
    }
}