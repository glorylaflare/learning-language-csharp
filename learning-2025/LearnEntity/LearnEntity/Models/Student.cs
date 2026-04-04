using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearnEntity.Models;

public class Student
{
    [Key]
    public int StudentID { get; set; }
    
    [Column("Name")]
    [MaxLength(100, ErrorMessage = "O nome do estudante não pode exceder 100 caracteres.")]
    [Required(ErrorMessage = "O nome do estudante é obrigatório.")]
    public string StudentName { get; set; }
    
    [ForeignKey("Grade")]
    [Column("Grade_Id")]
    public int GradeId { get; set; }
    
    public Grade Grade { get; set; }
}