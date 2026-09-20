namespace Linq.Training.Con.App.Models;

public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Cidade { get; set; } = string.Empty;
    public string Estado { get; set; } = string.Empty;
    public DateTime DataCadastro { get; set; }
    public bool Ativo { get; set; }

    public override string ToString() => $"[{Id}] {Nome} - {Cidade}/{Estado} ({(Ativo ? "Ativo" : "Inativo")})";
}
