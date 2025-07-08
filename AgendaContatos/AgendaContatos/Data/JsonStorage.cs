using System.Text.Json;

namespace AgendaContatos;

public class JsonStorage
{
    private const string _CAMINHO = "../../../ListaContatos.json";
    
    public static void SalvarContato(Contato contato)
    {
        var contatosExistentes = FiltrarContatos();
        contatosExistentes.Add(contato);
        
        var json = JsonSerializer.Serialize(contatosExistentes, new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });
        
        File.WriteAllText(_CAMINHO, json);
        Console.WriteLine("Contato adicionado com sucesso!");
    }

    public static void ListarContato(string nome)
    {
        var contatos = FiltrarContatos();
        var contato = contatos.FirstOrDefault(c => c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));

        if (contato != null)
        {
            Console.WriteLine($"Contato encontrado: {contato.Nome}, Email: {contato.Email}, Telefone: {contato.Telefone}");
            return;
        }
        
        Console.WriteLine("Contato não encontrado.");
    }
    
    public static void ListarContatos()
    {
        if (!File.Exists(_CAMINHO))
        {
            File.WriteAllText(_CAMINHO, "[]");
        }
        
        var json = File.ReadAllText(_CAMINHO);
        var contatos = JsonSerializer.Deserialize<List<Contato>>(json, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });
        
        if (contatos == null || !contatos.Any())
        {
            Console.WriteLine("Nenhum contato encontrado.");
            return;
        }
        
        Console.WriteLine("Lista de Contatos:");
        foreach (var contato in contatos)
        {
            Console.WriteLine($"Nome: {contato.Nome}, Email: {contato.Email}, Telefone: {contato.Telefone}");    
        }
        Console.WriteLine("Total de contatos: " + contatos.Count);
        Console.WriteLine(new string('#', 30));
    }

    public static void EditarContato(string nome)
    {
        var contatos = FiltrarContatos();
        var contato = contatos.FirstOrDefault(c => c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
        
        if (contato == null)
        {
            Console.WriteLine("Contato não encontrado.");
            return;
        }
        
        Console.WriteLine("Digite o novo nome do contato (deixe em branco para não alterar):");
        var novoNome = Console.ReadLine();
        Console.WriteLine("Digite o novo email do contato (deixe em branco para não alterar):");
        var novoEmail = Console.ReadLine();
        Console.WriteLine("Digite o novo telefone do contato (deixe em branco para não alterar):");
        var novoTelefone = Console.ReadLine();
        
        contato.Nome = !string.IsNullOrWhiteSpace(novoNome) ? novoNome : contato.Nome;
        contato.Email = !string.IsNullOrWhiteSpace(novoEmail) ? novoEmail : contato.Email;
        contato.Telefone = !string.IsNullOrWhiteSpace(novoTelefone) ? novoTelefone : contato.Telefone;
        
        var json = JsonSerializer.Serialize(contatos, new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });
        File.WriteAllText(_CAMINHO, json);
    }
    
    public static void RemoverContato(string nome)
    {
        var contatos = FiltrarContatos();
        var contato = contatos.FirstOrDefault(c => c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
        
        if (contato == null)
        {
            Console.WriteLine("Contato não encontrado.");
            return;
        }
        
        contatos.Remove(contato);
        
        var json = JsonSerializer.Serialize(contatos, new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });
        
        File.WriteAllText(_CAMINHO, json);
        Console.WriteLine("Contato removido com sucesso!");
    }
    
    private static List<Contato> FiltrarContatos()
    {
        if (!File.Exists(_CAMINHO))
        {
            File.WriteAllText(_CAMINHO, "[]");
        }
        
        var json = File.ReadAllText(_CAMINHO);
        return JsonSerializer.Deserialize<List<Contato>>(json, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        }) ?? new List<Contato>();
    }
}