using BancoWebRazor.Pages.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BancoWebRazor.Pages.Login;

public class LoginModel : PageModel
{
    [BindProperty]
    public string? Email { get; set; }
    [BindProperty]
    public string? Senha { get; set; }
    
    public void OnGet()
    {
        // This method is called when the page is accessed via GET request.
        // You can initialize any data needed for the page here.
    }
    
    public IActionResult OnPost()
    {
        var clientes = JsonStorage.CarregarClientes();
        var cliente = clientes.FirstOrDefault(c => c.Email == Email && c.Senha == Senha);

        if (cliente != null)
        {
            // Redirect to the customer dashboard or home page
            return RedirectToPage("/Customer/Dashboard");
        }

        ModelState.AddModelError(string.Empty, "Email ou senha inválidos.");
        return Page();
    }
}