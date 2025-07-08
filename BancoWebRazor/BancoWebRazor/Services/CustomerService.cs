namespace BancoWebRazor.Pages.Services;

public class CustomerService
{
    public static string GerarNumeroConta()
    {
        var random = new Random();
        var numeroConta = random.Next(100000, 999999).ToString(); 
        return numeroConta;
    }
}