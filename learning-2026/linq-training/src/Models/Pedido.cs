namespace Linq.Training.Con.App.Models;

public class Pedido
{
    public int Id { get; set; }
    public int ClienteId { get; set; }
    public DateTime Data { get; set; }
    public List<ItemPedido> Itens { get; set; } = new();

    public decimal Total => Itens.Sum(i => i.Subtotal);

    public override string ToString() => $"[{Id}] Cliente {ClienteId} - {Data:dd/MM/yyyy} - R$ {Total:F2}";
}
