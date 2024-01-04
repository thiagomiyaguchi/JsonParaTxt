


using JsonParaTxt;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    Console.Write("Pressione uma tecla para gerar um arquivo TXT com uma frase dita por Kanye West");
    Console.ReadKey();
    try
    {
        string frase = await client.GetStringAsync("https://api.kanye.rest");
        Frase novaFrase = JsonSerializer.Deserialize<Frase>(frase);
        File.WriteAllText("fraseGenial.txt", novaFrase.Citacao);
        Console.WriteLine($"Arquivo Gerado com Sucesso em: {Path.GetFullPath("fraseGenial.txt")}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ocorreu um erro: {ex.Message}");
    }
}