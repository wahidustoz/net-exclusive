using Telegram.Bot;
using Telegram.Bot.Types;

public partial class UpdateHandler
{
    public Task HandleMessageUpdateAsync(ITelegramBotClient botClient, Message message, CancellationToken cancellationToken)
    {
        logger.LogInformation("Received message from {userId}: {text}", message.Chat.Id, message.Text);
        return Task.CompletedTask;
    }
}