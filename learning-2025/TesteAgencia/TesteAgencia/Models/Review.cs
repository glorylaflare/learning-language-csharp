using System.ComponentModel.DataAnnotations;

namespace TesteAgencia.Models;

public class Review
{
    [Key]
    public int ReviewId { get; set; }
    
    [Display(Name = "Pacote ID")]
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public int PackageId { get; set; }
    
    [Display(Name = "Usuário ID")]
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public int UserId { get; set; }
    
    [Display(Name = "Comentário")]
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    [MaxLength(500, ErrorMessage = "O comentário não pode exceder 500 caracteres.")]
    public string Comment { get; set; }
    
    [Display(Name = "Avaliação")]
    [Range(1, 5, ErrorMessage = "A avaliação deve ser entre 1 e 5.")]
    public int Rating { get; set; } 
    
    [Display(Name = "Data de Criação")]
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    
    public StatusEnum Status { get; set; } = StatusEnum.Awaiting;
}