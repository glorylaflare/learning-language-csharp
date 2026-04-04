using System.Text.Json;

namespace BancoWebRazor.Pages.Data;

public abstract class JsonStorage
{
    private static readonly string _caminho = "usuarios.json";
    
    public static void SalvarClientes(List<Models.Customer> novosClientes)
    {
        var clientesExistentes = CarregarClientes();
        clientesExistentes.AddRange(novosClientes);

        var json = JsonSerializer.Serialize(clientesExistentes, new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });
        
        File.WriteAllText(_caminho, json);
    }

    public static List<Models.Customer> CarregarClientes()
    {
        if (!File.Exists(_caminho))
        {
            File.WriteAllText(_caminho, "[]"); 
            return new List<Models.Customer>();
        }
        
        var json = File.ReadAllText(_caminho);
        return JsonSerializer.Deserialize<List<Models.Customer>>(json, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        }) ?? new List<Models.Customer>();
    }
}