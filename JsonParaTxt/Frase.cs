
using System.Text.Json.Serialization;

namespace JsonParaTxt;

internal class Frase
{
    [JsonPropertyName("quote")]
    public string Citacao { get; set; }

    public void MostraFrase()
    {
        Console.WriteLine($"Frase Genial de Kanye West: {Citacao}");
    }
}


