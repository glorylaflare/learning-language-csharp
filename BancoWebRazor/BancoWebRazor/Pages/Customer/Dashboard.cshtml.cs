using Microsoft.AspNetCore.Mvc.RazorPages;
using BancoWebRazor.Pages.Models;
using BancoWebRazor.Pages.Services;
using BancoWebRazor.Pages.Data;

namespace BancoWebRazor.Pages.Customer;

public class Dashboard : PageModel
{
    public Models.Customer? UsuarioLogado { get; set; }
    public List<Transacao> TransacoesRecentes { get; set; } = new List<Transacao>();
    public decimal SaldoAtual { get; set; }
    
    public void OnGet()
    {
        // Por enquanto, vamos usar o primeiro usuário como exemplo
        // Em uma aplicação real, você pegaria o ID do usuário logado da sessão
        var usuarios = JsonStorage.CarregarClientes();
        
        if (usuarios.Any())
        {
            UsuarioLogado = usuarios.First();
            
            // Carregar transações do usuário
            TransacoesRecentes = TransacaoService.CarregarTransacoesPorUsuario(UsuarioLogado.Id);
            
            // Usar o saldo do usuário (não calcular pelas transações)
            SaldoAtual = UsuarioLogado.Saldo;
        }
    }
}