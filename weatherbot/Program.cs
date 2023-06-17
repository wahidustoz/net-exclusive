using Telegram.Bot;
using Telegram.Bot.Polling;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHostedService<BotHostBackgroundService>();
builder.Services.AddTransient<IUpdateHandler, UpdateHandler>();
builder.Services.AddHttpClient<OpenMeteoClient>(client => 
{
    client.BaseAddress = new Uri("https://api.open-meteo.com");
});
builder.Services.AddSingleton<ITelegramBotClient, TelegramBotClient>(provider => 
{
    var botkey = builder.Configuration.GetValue("Botkey", string.Empty);
    return new TelegramBotClient(botkey);
});

var app = builder.Build();
app.Run();