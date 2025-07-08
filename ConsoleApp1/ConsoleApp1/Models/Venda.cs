namespace ConsoleApp1.Models;

public class Venda
{
    public int Id { get; set; }
    public Cliente Cliente { get; set; } = new();
    public Produto Produto { get; set; } = new();
    public int Quantidade { get; set; }
    public DateTime DataVenda { get; set; } = DateTime.Now;
    public decimal ValorTotal => Produto.Preco * Quantidade;
}