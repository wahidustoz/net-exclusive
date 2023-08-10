using System.Text.Json.Serialization;

public class Todo
{
    [JsonPropertyName("userId")]
    public int userId { get; set; }

    [JsonPropertyName("id")]
    public int id { get; set; }

    [JsonPropertyName("title")]
    public string title { get; set; }

    [JsonPropertyName("completed")]
    public bool completed { get; set; }
}
