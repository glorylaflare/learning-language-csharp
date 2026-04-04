using BancoWebRazor.Pages.Data;
using BancoWebRazor.Pages.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BancoWebRazor.Pages.Customer;

public class Register : PageModel
{
    public void OnGet()
    {
        
    }
    
    public IActionResult OnPost(string nome, string email, string senha, string cpf)
    {
        var numeroConta = CustomerService.GerarNumeroConta();
        var cliente = new Models.Customer(nome, email, cpf, senha, numeroConta);
        JsonStorage.SalvarClientes([cliente]);
        TempData["Mensagem"] = "Cadastro realizado com sucesso! Faça login para acessar sua conta.";
        
        return RedirectToPage("/Login/Login");
    }
}