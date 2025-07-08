using System.Text.Json;
using BancoWebRazor.Pages.Models;

namespace BancoWebRazor.Pages.Services;

public class TransacaoService
{
    private static readonly string _caminhoTransacoes = "transacoes.json";
    
    public static List<Transacao> CarregarTransacoes()
    {
        if (!File.Exists(_caminhoTransacoes))
        {
            File.WriteAllText(_caminhoTransacoes, "[]");
            return new List<Transacao>();
        }
        
        var json = File.ReadAllText(_caminhoTransacoes);
        return JsonSerializer.Deserialize<List<Transacao>>(json, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        }) ?? new List<Transacao>();
    }
    
    public static List<Transacao> CarregarTransacoesPorUsuario(int usuarioId)
    {
        var todasTransacoes = CarregarTransacoes();
        return todasTransacoes.Where(t => t.UsuarioId == usuarioId)
                             .OrderByDescending(t => t.Data)
                             .Take(10)
                             .ToList();
    }
    
    public static void SalvarTransacao(Transacao transacao)
    {
        var transacoes = CarregarTransacoes();
        transacoes.Add(transacao);
        
        var json = JsonSerializer.Serialize(transacoes, new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });
        
        File.WriteAllText(_caminhoTransacoes, json);
    }
    
    public static decimal CalcularSaldoUsuario(int usuarioId)
    {
        var transacoes = CarregarTransacoes();
        return transacoes.Where(t => t.UsuarioId == usuarioId)
                        .Sum(t => t.Valor);
    }
}
