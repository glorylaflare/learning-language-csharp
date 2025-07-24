using System.ComponentModel.DataAnnotations;

namespace TesteAgencia.Models;

public class DateList
{
    [Key]
    public int DateListId { get; set; }
    
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    [Display(Name = "Data Disponível")]
    [DataType(DataType.Date)]
    public DateTime Date { get; set; }
    
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public int PackageId { get; set; }
    public Package? Package { get; set; }
}