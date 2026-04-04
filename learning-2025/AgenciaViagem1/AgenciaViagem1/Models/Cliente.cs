namespace AgenciaViagem1.Models;

public class Cliente : Usuario
{
    public override List<string> ObterPermissao()
    {
        return new List<string>
        {
            "Visualizar Viagens",
            "Reservar Viagens",
            "Cancelar Reservas"
        };
    }
}