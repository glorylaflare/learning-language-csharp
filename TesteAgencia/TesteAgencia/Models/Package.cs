using System.ComponentModel.DataAnnotations;

namespace TesteAgencia.Models;

public class Package
{
    [Key]
    public int PackageId { get; set; }
    
    [Display(Name = "Titulo do Pacote")]
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public string Title { get; set; }
    
    [Display(Name = "Descrição do Pacote")]
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    [MaxLength(500, ErrorMessage = "A descrição não pode exceder {1} caracteres.")]
    public string Description { get; set; }
    
    [Display(Name = "Destinos")]
    public List<DestinationList> Destination { get; set; } = new List<DestinationList>();
    
    [Display(Name = "Duração (dias)")]
    [Range(1, 365, ErrorMessage = "A duração deve ser entre {1} e {2} dias.")]
    public int Duration { get; set; } 
    
    [Display(Name = "Datas Disponíveis")]
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public List<DateList> Dates { get; set; } = new List<DateList>();
    
    [Display(Name = "Preço")]
    [Range(0.01, double.MaxValue, ErrorMessage = "O preço deve ser maior que zero.")]
    [DataType(DataType.Currency)]
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public decimal Price { get; set; }
    
    [Display(Name = "Lista de Imagens")]
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public List<string> ImageUrl { get; set; } = new List<string>();

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}