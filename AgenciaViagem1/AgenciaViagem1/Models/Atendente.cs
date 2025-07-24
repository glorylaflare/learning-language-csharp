namespace AgenciaViagem1.Models;

public class Atendente : Usuario
{
    public override List<string> ObterPermissao()
    {
        return new List<string>
        {
            "Gerenciar reservas",
            "Atender clientes",
            "Visualizar relatórios"
        };
    }
}