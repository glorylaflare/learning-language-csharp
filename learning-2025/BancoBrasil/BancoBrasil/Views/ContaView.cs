namespace BancoBrasil.Views;

public class ContaView
{
    public int SolicitarNumeroConta()
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine(" BEM-VINDO AO BANCO BRASIL S.A. (MVC)");
        Console.WriteLine("===================================");
        Console.WriteLine("Digite o número da sua conta: ");
        Console.WriteLine("Digite 0 para sair.");

        return int.Parse(Console.ReadLine());
    }
    
    public string ObterOpcaoMenu(string nomeTitular, decimal saldo, bool estaAtiva)
    {
        Console.Clear();
        Console.WriteLine($"Olá {nomeTitular}, bem-vindo!");
        Console.WriteLine($"Seu saldo atual é: {saldo:C}");
        Console.WriteLine($"Conta ativa? {estaAtiva}");
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1 - Extrato");
        Console.WriteLine("2 - Depósito");
        Console.WriteLine("3 - Saque");
        Console.WriteLine("4 - Transferir");
        Console.WriteLine("5 - Verificar Limite de Cheque Especial");
        Console.WriteLine("6 - Encerrar Conta");
        Console.WriteLine("7 - Sair");
        Console.Write("Opção: ");

        return Console.ReadLine();
    }

    public void PausarEVoltarParaOMenu()
    {
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    }

    public void FecharMenu()
    {
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
        SolicitarNumeroConta();
    }
}