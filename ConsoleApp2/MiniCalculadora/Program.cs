namespace MiniCalculadora;

class Program
{
    static void Main(string[] args)
    {
        Calculadora.Executar();
        
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