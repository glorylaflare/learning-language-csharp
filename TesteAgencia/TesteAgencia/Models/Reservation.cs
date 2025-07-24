using System.ComponentModel.DataAnnotations;

namespace TesteAgencia.Models;

public class Reservation
{
    [Key]
    public int ReservationId { get; set; }
    
    [Required(ErrorMessage = "O ID do pacote é obrigatório.")]
    public int PackageId { get; set; }
    
    [Required(ErrorMessage = "O ID do usuário é obrigatório.")]
    public int UserId { get; set; }
    
    [Required(ErrorMessage = "A data da reserva é obrigatória.")]
    public DateTime ReservationDate { get; set; }
    
    public List<TravelersList> Travelers { get; set; } = new List<TravelersList>();
    public StatusEnum Status { get; set; } = StatusEnum.Awaiting;
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; }
}