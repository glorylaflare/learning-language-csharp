namespace AgenciaViagem1.Models;

public class Administrador : Usuario
{
    public override List<string> ObterPermissao()
    {
        return new List<string>
        {
            "Gerenciar usuários",
            "Gerenciar reservas",
            "Visualizar relatórios",
            "Configurar sistema"
        };
    }
}