using AgendaContatos.View;

namespace AgendaContatos.Controller;

public class ListaController
{
    private static readonly ListaView _listaView = new ListaView();

    public static void Executar()
    {
        _listaView.ExibirMenu();
    }
    
    public void AdicionarContato(Contato contato)
    {
        JsonStorage.SalvarContato(contato);
    }
    
    public void ListarContato(string nome)
    {
        JsonStorage.ListarContato(nome);
    }
    
    public void ListarTodosContatos()
    {
        JsonStorage.ListarContatos();
    }

    public void EditarContato(string nome)
    {
        JsonStorage.EditarContato(nome);
    }
    
    public void RemoverContato(string nome)
    {
        JsonStorage.RemoverContato(nome);   
    }
}