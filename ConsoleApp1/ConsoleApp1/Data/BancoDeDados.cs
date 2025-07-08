using ConsoleApp1.Models;

namespace ConsoleApp1.Data;

public class BancoDeDados
{
    public static List<Cliente> Clientes { get; set; } = new();
    public static List<Produto> Produtos { get; set; } = new();
    public static List<Venda> Vendas { get; set; } = new();
    
    public static void InicializarDados()
    {
        // Adicionando clientes
        Clientes.Add(new Cliente { Id = 1, Nome = "João Silva", Email = "joao@email" });
        Clientes.Add(new Cliente { Id = 2, Nome = "Maria Oliveira", Email = "maria@email" });
        Clientes.Add(new Cliente { Id = 3, Nome = "Carlos Souza", Email = "carlos@email" });

        // Adicionando produtos
        Produtos.Add(new Produto { Id = 1, Nome = "Café Gourmet", Preco = 12.99m, Quantidade = 80 });
        Produtos.Add(new Produto { Id = 2, Nome = "Fone de Ouvido Bluetooth", Preco = 99.90m, Quantidade = 30 });
        Produtos.Add(new Produto { Id = 3, Nome = "Caderno Universitário", Preco = 18.50m, Quantidade = 120 });
        Produtos.Add(new Produto { Id = 4, Nome = "Garrafa Térmica", Preco = 45.00m, Quantidade = 60 });
    }
}