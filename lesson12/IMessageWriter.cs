public interface IMessageWriter
{
    void Write(string message);
}

public class ConsoleWriter : IMessageWriter
{
    public void Write(string message)
    {
        Console.WriteLine($"Message: {message}");
    }
}

public class FileWriter : IMessageWriter
{
    public void Write(string message)
    {
        File.WriteAllText("message.txt", $"Message: {message}");
    }
}