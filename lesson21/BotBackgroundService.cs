using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types.Enums;

public class BotBackgroundService : BackgroundService
{
    private readonly ILogger<BotBackgroundService> logger;
    private readonly ITelegramBotClient botClient;
    private readonly IUpdateHandler updateHandler;

    public BotBackgroundService(
        ILogger<BotBackgroundService> logger,
        ITelegramBotClient botClient,
        IUpdateHandler updateHandler)
    {
        this.logger = logger;
        this.botClient = botClient;
        this.updateHandler = updateHandler;
    }
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var me = await botClient.GetMeAsync(stoppingToken);
        logger.LogInformation("Bot {username} started at {time}", me.Username, DateTime.UtcNow);

        botClient.StartReceiving(
            updateHandler: updateHandler,
            receiverOptions: new ReceiverOptions
            {
                AllowedUpdates = new [] 
                { 
                    UpdateType.Message, 
                    UpdateType.EditedMessage 
                },
                ThrowPendingUpdates = true
            },
            cancellationToken: stoppingToken);
    }
}