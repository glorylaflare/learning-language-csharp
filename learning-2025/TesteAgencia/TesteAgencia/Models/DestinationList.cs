using System.ComponentModel.DataAnnotations;

namespace TesteAgencia.Models;

public class DestinationList
{
    [Key]
    public int DestinationId { get; set; }
    
    [Display(Name = "Nome do Destino")]
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public List<string> Name { get; set; } = new List<string>();
    
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public int PackageId { get; set; }
    public Package? Package { get; set; }
}