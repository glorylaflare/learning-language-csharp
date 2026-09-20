namespace Linq.Training.Con.App.Models;

public class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public decimal Preco { get; set; }
    public int Estoque { get; set; }
    public int CategoriaId { get; set; }

    public override string ToString() => $"[{Id}] {Nome} - R$ {Preco:F2} (Estoque: {Estoque})";
}
