using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearnEntity.Models;

public class Grade
{
    [Key]
    public int GradeId { get; set; }
    
    [Column("Name")]
    [MaxLength(10, ErrorMessage = "O nome da série não pode exceder 10 caracteres.")]
    [Required(ErrorMessage = "O nome da série é obrigatória.")]
    public string GradeName { get; set; }
    
    [MaxLength(10, ErrorMessage = "A seção não pode exceder 10 caracteres.")]
    [Required(ErrorMessage = "A seção é obrigatória.")]
    public string Section { get; set; }
    
    public ICollection<Student> Students { get; set; }
}