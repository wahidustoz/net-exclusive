using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

public class UpdateHandler : IUpdateHandler
{
    private readonly ILogger<UpdateHandler> logger;
    private readonly OpenMeteoClient client;

    public UpdateHandler(
        ILogger<UpdateHandler> logger,
        OpenMeteoClient client)
    {
        this.logger = logger;
        this.client = client;
    }

    public Task HandlePollingErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
    {
        logger.LogError(exception, "Xatolik yuz berdi: {exception.Message}", exception.Message);
        return Task.CompletedTask;
    }

    public async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
    {
        if(update.Type == UpdateType.Message)
        {
            var message = update.Message;
            if(message.Type == MessageType.Location)
            {
                var weather = await client.GetWeatherAsync(
                    longitude: message.Location.Longitude,
                    latitude: message.Location.Latitude);

                await botClient.SendTextMessageAsync(message.Chat.Id, $"Ob havo: {weather.CurrentWeather.Temperature:F2}");
            }
        }
    }
}