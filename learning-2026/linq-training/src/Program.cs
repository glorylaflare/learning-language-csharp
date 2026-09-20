using Linq.Training.Con.App.Desafios;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("╔════════════════════════════════════════════╗");
Console.WriteLine("║        LINQ TRAINING — C# / .NET 8         ║");
Console.WriteLine("╚════════════════════════════════════════════╝");

Console.WriteLine("\nEscolha um nível para executar:");
Console.WriteLine("1 - Básico");
Console.WriteLine("2 - Intermediário");
Console.WriteLine("3 - Avançado");
Console.WriteLine("4 - Especialista");
Console.WriteLine("0 - Todos");
Console.Write("\nOpção: ");

string? opcao = Console.ReadLine();

switch (opcao)
{
    case "1": Nivel01Basico.Executar(); break;
    case "2": Nivel02Intermediario.Executar(); break;
    case "3": Nivel03Avancado.Executar(); break;
    case "4": Nivel04Especialista.Executar(); break;
    case "0":
        Nivel01Basico.Executar();
        Nivel02Intermediario.Executar();
        Nivel03Avancado.Executar();
        Nivel04Especialista.Executar();
        break;
    default:
        Console.WriteLine("Opção inválida.");
        break;
}

Console.WriteLine("\nPressione qualquer tecla para sair...");
Console.ReadKey();