using ConsoleApp1.Data;

namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        BancoDeDados.InicializarDados();
        // Exibe o menu principal
        var menuView = new Views.MenuView();
        menuView.ExibirMenu();

        // Aguarda o usuário pressionar uma tecla antes de encerrar
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
        
        // Encerramento do programa
        Console.Clear();
        Console.WriteLine("Programa encerrado. Até logo!");
    }
}