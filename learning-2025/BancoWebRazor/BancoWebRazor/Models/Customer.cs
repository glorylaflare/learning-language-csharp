namespace BancoWebRazor.Pages.Models;

public class Customer
{
    public int Id { get; set; } // Unique identifier for the customer
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Cpf { get; set; }
    public string Senha { get; set; }
    public string NumeroConta { get; set; }
    public int Agencia { get; set; }
    public decimal Saldo { get; set; }
    public DateTime DataCriacaoConta { get; set; }

    public Customer(string nome, string email, string cpf, string senha, string numeroConta)
    {
        Id = Math.Abs(Guid.NewGuid().GetHashCode());
        Nome = nome;
        Email = email;
        Cpf = cpf;
        Senha = senha;
        NumeroConta = numeroConta;
        Agencia = 803; 
        Saldo = 0m; 
        DataCriacaoConta = DateTime.Now;
    }
}