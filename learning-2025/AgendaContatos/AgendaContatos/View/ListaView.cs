using AgendaContatos.Controller;

namespace AgendaContatos.View;

public class ListaView
{
    private readonly ListaController _listaController = new();
    
    public void ExibirMenu()
    {
        Console.Clear();
        Console.WriteLine("Bem-vindo à Agenda de Contatos!");
        Console.WriteLine("1 - Adicionar Contato");
        Console.WriteLine("2 - Listar Contato");
        Console.WriteLine("3 - Listar Todos os Contatos");
        Console.WriteLine("4 - Editar Contato");
        Console.WriteLine("5 - Remover Contato");
        Console.WriteLine("0 - Sair");
        
        var opcao = Console.ReadLine();
        string? nome;
        
        switch (opcao)
        {
            case "1":
                Console.WriteLine("Digite o nome do contato:");
                nome = Console.ReadLine();
                Console.WriteLine("Digite o email do contato:");
                var email = Console.ReadLine();
                Console.WriteLine("Digite o telefone do contato:");
                var telefone = Console.ReadLine();
                _listaController.AdicionarContato(new Contato(nome, email, telefone));
                break;
            case "2":
                Console.WriteLine("Digite o nome do contato:");
                nome = Console.ReadLine();
                _listaController.ListarContato(nome);
                break;
            case "3":
                _listaController.ListarTodosContatos();
                break;
            case "4":
                Console.WriteLine("Digite o nome do contato:");
                nome = Console.ReadLine();
                _listaController.EditarContato(nome);
                break;
            case "5":
                Console.WriteLine("Digite o nome do contato:");
                nome = Console.ReadLine();
                _listaController.RemoverContato(nome);
                break;
            case "0":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Opção inválida. Tente novamente.");
                ExibirMenu();
                break;
        }
    }
}