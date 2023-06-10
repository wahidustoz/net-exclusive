using System.Text.Json.Serialization;

public class Card
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("number")]
    public long Number { get; set; }

    [JsonPropertyName("expiry")]
    public string Expiry { get; set; }

    [JsonPropertyName("cvc")]
    public int Cvc { get; set; }

    public override string ToString()
        => 
$@"
Type: {Type}, 
Number: {Number}, 
Expiry: {Expiry},
CVC: {Cvc}
";

}