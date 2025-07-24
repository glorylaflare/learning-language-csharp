using System.ComponentModel.DataAnnotations;

namespace TesteAgencia.Models;

public class Payment
{
    [Key]
    public int PaymentId { get; set; }
    [Required(ErrorMessage = "ID da reserva é obrigatório.")]
    
    public int ReservationId { get; set; }
    [Required(ErrorMessage = "O valor do pagamento é obrigatório.")]
    [Range(0.01, double.MaxValue, ErrorMessage = "O valor do pagamento deve ser maior que zero.")]
    public decimal Amount { get; set; }
    
    [Required(ErrorMessage = "O método de pagamento é obrigatório.")]
    public PaymentMethodEnum PaymentMethod { get; set; }
    
    public StatusEnum Status { get; set; } = StatusEnum.Awaiting;
}