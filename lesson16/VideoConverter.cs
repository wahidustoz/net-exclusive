public class VideoConverter
{
    public delegate void OnVideoConverted();
    public void Convert(byte[] videoBytes, OnVideoConverted callback)
    {
        Console.WriteLine("Started");
        Task.Delay(2000).Wait();
        callback();
    }
}