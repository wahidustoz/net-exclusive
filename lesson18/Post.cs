using System.Text.Json.Serialization;

public class Post
{
    [JsonPropertyName("userId")]
    public int UserId { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("body")]
    public string Body { get; set; }

    public override string ToString()
        => 
@$"
UserId: {UserId}, 
Id: {Id}, 
Title: {Title}, 
Body: {Body}
";

}