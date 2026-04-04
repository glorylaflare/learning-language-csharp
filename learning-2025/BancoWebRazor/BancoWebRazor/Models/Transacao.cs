namespace BancoWebRazor.Pages.Models;

public class Transacao
{
    public int Id { get; set; }
    public int UsuarioId { get; set; }
    public DateTime Data { get; set; }
    public string Descricao { get; set; }
    public string Tipo { get; set; }
    public decimal Valor { get; set; }
    public string Icone { get; set; }

    public Transacao()
    {
        
    }

    public Transacao(int usuarioId, string descricao, string tipo, decimal valor, string icone)
    {
        Id = Math.Abs(Guid.NewGuid().GetHashCode());
        UsuarioId = usuarioId;
        Data = DateTime.Now;
        Descricao = descricao;
        Tipo = tipo;
        Valor = valor;
        Icone = icone;
    }
}
