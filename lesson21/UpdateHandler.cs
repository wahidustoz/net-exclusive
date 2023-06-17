using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;

public class UpdateHandler : IUpdateHandler
{
    private readonly ILogger<UpdateHandler> logger;

    public UpdateHandler(ILogger<UpdateHandler> logger)
    {
        this.logger = logger;
    }

    public Task HandlePollingErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
    {
        logger.LogError(exception, "Error occured. See the exception");
        return Task.CompletedTask;
    }

    public Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
    {
        logger.LogInformation("Received update {updateType} from {userId}", update.Type, update.Message?.Chat?.Id);
        return Task.CompletedTask;
    }
}