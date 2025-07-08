using BancoBrasil.Controllers;

namespace BancoBrasil;

internal abstract class Program
{
    static void Main(string[] args)
    {
        var controller = new ContaController();

        controller.Iniciar();
    }
}