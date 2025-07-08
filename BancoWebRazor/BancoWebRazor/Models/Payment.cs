namespace BancoWebRazor.Pages.Models;

public class Payment
{
    public PaymentEnum TipoPagamento { get; set; }
    public decimal ValorPagamento { get; set; }
    public string DescricaoPagamento { get; set; }
    public DateTime dataPagamento { get; set; }
    
    public Payment(PaymentEnum tipoPagamento, decimal valorPagamento, string descricaoPagamento)
    {
        TipoPagamento = tipoPagamento;
        ValorPagamento = valorPagamento;
        DescricaoPagamento = descricaoPagamento;
        dataPagamento = DateTime.Now; 
    }
}