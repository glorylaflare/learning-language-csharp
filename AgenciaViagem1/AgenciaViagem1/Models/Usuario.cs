using System.ComponentModel.DataAnnotations;
using AgenciaViagem1.Models.Enum;

namespace AgenciaViagem1.Models;

public abstract class Usuario
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "O nome é obrigatório.")]
    public string Nome { get; set; }
    [Required(ErrorMessage = "O email é obrigatório.")]
    public string Email { get; set; }
    [Required(ErrorMessage = "O cpf é obrigatório.")]
    public string Cpf { get; set; }
    public string Passaporte { get; set; }
    [Required(ErrorMessage = "A senha é obrigatório.")]
    public string Senha { get; set; }
    [Required(ErrorMessage = "O telefone é obrigatório.")]
    public string Telefone { get; set; }
    [Required(ErrorMessage = "O tipo de usuário é obrigatório.")]
    public TipoUsuarioEnum Tipo { get; set; }

    public abstract List<string> ObterPermissao();
}
