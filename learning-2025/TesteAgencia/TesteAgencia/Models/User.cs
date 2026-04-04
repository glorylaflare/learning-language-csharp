using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace TesteAgencia.Models;

public class User
{
    [Key] 
    public int UserId { get; set; }

    [Display(Name = "Nome")]
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    [MaxLength(100, ErrorMessage = "O nome não pode exceder 100 caracteres.")]
    public string Name { get; set; }

    [Display(Name = "E-mail")]
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    [EmailAddress(ErrorMessage = "O campo {0} deve ser um endereço de e-mail válido.")]
    public string Email { get; set; }

    [Display(Name = "Senha")]
    [DataType(DataType.Password)]
    public string? Password { get; set; }

    [Display(Name = "Telefone")]
    [RegularExpression(@"^\+?[1-9]\d{1,14}$", ErrorMessage = "O telefone deve ser um número válido.")]
    [MaxLength(15, ErrorMessage = "O telefone não pode exceder 15 caracteres.")]
    public string? Phone { get; set; }

    [Display(Name = "CPF")]
    [MaxLength(11, ErrorMessage = "O CPF deve ter 11 dígitos.")]
    [RegularExpression(@"^\d{11}$", ErrorMessage = "O CPF deve conter apenas números e ter 11 dígitos.")]
    public string? Cpf { get; set; }

    [Display(Name = "Passaporte")]
    [RegularExpression(@"^[A-Z0-9]{6,9}$", ErrorMessage = "O passaporte deve conter entre 6 e 9 caracteres alfanuméricos.")]
    [MaxLength(9, ErrorMessage = "O passaporte deve ter no máximo 9 caracteres.")]
    public string? Passport { get; set; }

    public RolesEnum Roles { get; set; } = RolesEnum.Client;
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    bool IsActive { get; set; } = true;
    public DateTime DisabledAt { get; set; }
}