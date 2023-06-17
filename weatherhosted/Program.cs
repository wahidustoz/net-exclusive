using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

var builder = new HostBuilder();
builder.ConfigureServices(services =>
{
    // register services
    services.AddHttpClient("OpenMeteo", client => client.BaseAddress = new Uri("https://api.open-meteo.com"));
    services.AddTransient<IWeather, WeatherV2>();
    services.AddTransient<IWeatherForecast, WeatherForecast>();
    services.AddHostedService<MenuBackgroundService>();
});

var app = builder.Build();
app.Run();