using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = new HostBuilder();

builder.ConfigureServices((services) => 
{
    // services.AddTransient<IClockPrinter, ClockPrinter>();
    // services.AddTransient<ClockPrinter>();
    // services.AddScoped<IClockPrinter, ClockPrinter>();
    services.AddSingleton<IClockPrinter, ClockPrinter>();
    services.AddHostedService<ClockPrintBackroundService>();    // IHostedService ni implement qiladi
    services.AddHttpClient("OpenMeteo", c => c.BaseAddress = new Uri("httsp://api.open-meteo.com"));
});

var app = builder.Build();
app.Run();