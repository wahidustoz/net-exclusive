using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types.Enums;

public class BotHostBackgroundService : BackgroundService
{
    private readonly ITelegramBotClient telegramBotClient;
    private readonly ILogger<BotHostBackgroundService> logger;
    private readonly IUpdateHandler updateHandler;

    public BotHostBackgroundService(
        ITelegramBotClient telegramBotClient,
        ILogger<BotHostBackgroundService> logger,
        IUpdateHandler updateHandler)
    {
        this.telegramBotClient = telegramBotClient;
        this.logger = logger;
        this.updateHandler = updateHandler;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var me = await telegramBotClient.GetMeAsync(stoppingToken);
        logger.LogInformation("Bot started: {username}", me.Username);

        telegramBotClient.StartReceiving(
            updateHandler: updateHandler,
            receiverOptions: new Telegram.Bot.Polling.ReceiverOptions(),
            cancellationToken: stoppingToken);
    }
}