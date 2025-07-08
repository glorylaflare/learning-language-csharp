using AgendaContatos.Controller;

namespace AgendaContatos;

class Program
{
    static void Main(string[] args)
    {
        ListaController.Executar();
        
        Console.WriteLine("Pressione 1 para uma nova operação");
        Console.WriteLine("Ou pressione qualquer outra tecla para sair...");
        
        if (Console.ReadLine() == "1")
        {
            Console.Clear();
            Main(args);
        }
        
        Console.Clear();
        Console.WriteLine("Programa encerrado. Até logo!");
    }
}