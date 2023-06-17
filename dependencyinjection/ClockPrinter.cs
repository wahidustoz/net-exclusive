public class ClockPrinter : IClockPrinter
{
    public void PrintTime()
        => Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
}

public interface IClockPrinter
{
    void PrintTime();
}