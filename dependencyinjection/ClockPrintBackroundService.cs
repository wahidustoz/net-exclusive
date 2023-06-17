using Microsoft.Extensions.Hosting;

public class ClockPrintBackroundService : BackgroundService
{
    private readonly IClockPrinter clockPrinter;
    public ClockPrintBackroundService(IClockPrinter clockPrinter)
    {
        this.clockPrinter = clockPrinter; 
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while(true)
        {
            clockPrinter.PrintTime();
            await Task.Delay(1000, stoppingToken);
        }
    }
}   