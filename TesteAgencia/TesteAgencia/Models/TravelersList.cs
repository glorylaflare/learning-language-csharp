using System.ComponentModel.DataAnnotations;

namespace TesteAgencia.Models;

public class TravelersList
{
    [Key]
    public int TravelersListId { get; set; }
    
    [Display(Name = "Nome do Viajante")]
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    [MaxLength(100, ErrorMessage = "O nome não pode exceder {1} caracteres.")]
    public string Name { get; set; }
    
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public int ReservationId { get; set; }
    public Reservation Reservation { get; set; }
}