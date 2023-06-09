using System.Text;

public class VideoConverter
{
    public event EventHandler<VideoConvertedEventArgs> VideoConverted;
    public void Convert(byte[] data)
    {
        Console.WriteLine("Starting to convert");
        Task.Delay(2000).Wait();
        OnVideoConverted(new VideoConvertedEventArgs()
        {
            Data = Encoding.UTF8.GetString(data)
        });
    }

    protected void OnVideoConverted(VideoConvertedEventArgs e)
    {
        VideoConverted?.Invoke(this, e);
    }
}

public class VideoConvertedEventArgs : EventArgs
{
    public string Data { get; set; }
}