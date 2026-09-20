namespace Linq.Training.Con.App.Models;

public class Categoria
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;

    public override string ToString() => $"[{Id}] {Nome}";
}
