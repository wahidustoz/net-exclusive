using System.Text;

var converter = new VideoConverter();
var converte1 = new VideoConverter();
converter.VideoConverted += VideoConvertedHandler;

converter.Convert(Encoding.UTF8.GetBytes("Hello World!"));

void VideoConvertedHandler(object sender, VideoConvertedEventArgs e)
{
    Console.WriteLine($"Received VideoConverted event: {e.Data}");
}