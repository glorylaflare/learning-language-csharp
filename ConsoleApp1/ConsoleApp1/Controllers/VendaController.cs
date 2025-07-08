using ConsoleApp1.Data;
using ConsoleApp1.Models;

namespace ConsoleApp1.Controllers;

public class VendaController
{
    public static void RealizarVenda()
    {
        Console.WriteLine("Selecione o cliente:");
        foreach (var cliente in BancoDeDados.Clientes)
            Console.WriteLine($"{cliente.Id} - {cliente.Nome}");

        Console.Write("ID do cliente: ");
        int idCliente = int.Parse(Console.ReadLine() ?? "0");
        var clienteSelecionado = BancoDeDados.Clientes.FirstOrDefault(c => c.Id == idCliente);
        if (clienteSelecionado == null)
        {
            Console.WriteLine("Cliente não encontrado.");
            return;
        }

        Console.WriteLine("\nSelecione o produto:");
        foreach (var produto in BancoDeDados.Produtos)
            Console.WriteLine($"{produto.Id} - {produto.Nome} - R${produto.Preco} ({produto.Quantidade} em estoque)");

        Console.Write("ID do produto: ");
        int idProduto = int.Parse(Console.ReadLine() ?? "0");
        var produtoSelecionado = BancoDeDados.Produtos.FirstOrDefault(p => p.Id == idProduto);
        if (produtoSelecionado == null)
        {
            Console.WriteLine("Produto não encontrado.");
            return;
        }

        Console.Write("Quantidade: ");
        int quantidade = int.Parse(Console.ReadLine() ?? "0");

        if (quantidade > produtoSelecionado.Quantidade)
        {
            Console.WriteLine("Estoque insuficiente.");
            return;
        }

        produtoSelecionado.Quantidade -= quantidade;

        var venda = new Venda
        {
            Id = BancoDeDados.Vendas.Count + 1,
            Cliente = clienteSelecionado,
            Produto = produtoSelecionado,
            Quantidade = quantidade,
        };

        BancoDeDados.Vendas.Add(venda);

        Console.WriteLine($"\n✅ Venda realizada: {clienteSelecionado.Nome} comprou {quantidade}x {produtoSelecionado.Nome} por R${venda.ValorTotal}\n");
    }
    
    public static void ListarVendas()
    {
        Console.WriteLine("📋 Histórico de Vendas:");
        foreach (var venda in BancoDeDados.Vendas)
        {
            Console.WriteLine($"{venda.DataVenda:dd/MM/yyyy HH:mm} | Cliente: {venda.Cliente.Nome} | Produto: {venda.Produto.Nome} | Quantidade: {venda.Quantidade} | Total: R${venda.ValorTotal}");
        }
        Console.WriteLine();
    }
}