using ConsoleApp1.Controllers;

namespace ConsoleApp1.Views;

public class MenuView
{
    public void ExibirMenu()
    {
        while (true)
        {
            Console.WriteLine("=== Menu Principal ===");
            Console.WriteLine("1. Realizar Venda");
            Console.WriteLine("2. Listar Vendas");
            Console.WriteLine("3. Sair");
            Console.Write("Escolha uma opção: ");
            var opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao)
            {
                case "1":
                    // Chamar método para realizar venda
                    VendaController.RealizarVenda();
                    break;
                case "2":
                    // Chamar método para listar vendas
                    VendaController.ListarVendas();
                    break;
                case "3":
                    Console.WriteLine("Saindo do programa...");
                    return; // Sair do loop e encerrar o programa
                default:
                    Console.WriteLine("Opção inválida, tente novamente.");
                    break;
            }
        }
    }
}