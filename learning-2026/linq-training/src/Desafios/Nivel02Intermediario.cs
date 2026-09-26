using Linq.Training.Con.App.Data;

namespace Linq.Training.Con.App.Desafios;

/// <summary>
/// Nível 2 — Intermediário
/// Métodos-alvo: GroupBy, Distinct, SelectMany, Join, Take, Skip, ThenBy.
/// </summary>
public static class Nivel02Intermediario
{
    public static void Executar()
    {
        Console.WriteLine("\n========== NÍVEL 2 — INTERMEDIÁRIO ==========");

        Desafio08();
        Desafio09();
        Desafio10();
        Desafio11();
        Desafio12();
        Desafio13();
        Desafio14();
    }

    // 8. Agrupe clientes por estado e mostre a contagem.
    private static void Desafio08()
    {
        Console.WriteLine("\n[8] Clientes por estado:");
        // TODO: GroupBy
        var result = Database.Clientes
            .GroupBy(c => c.Estado, c => c.Nome, (e, q) => new { 
                Estado = e, 
                Quantidade = q.Count() 
            })
            .OrderBy(_ => _.Estado);

        foreach (var item in result)
            Console.WriteLine($"{item.Estado}: {item.Quantidade} cliente(s)");
    }

    // 9. Liste as cidades distintas (sem repetição).
    private static void Desafio09()
    {
        Console.WriteLine("\n[9] Cidades distintas:");
        // TODO: Select + Distinct
        var result = Database.Clientes
            .Select(c => c.Cidade)
            .Distinct()
            .OrderBy(_ => _);

        foreach (var item in result)
            Console.WriteLine(item);
    }

    // 10. Liste todos os itens de todos os pedidos (SelectMany).
    private static void Desafio10()
    {
        Console.WriteLine("\n[10] Todos os itens de todos os pedidos:");
        // TODO: SelectMany
        var result = Database.Pedidos
            .SelectMany(p => p.Itens.Select(i => new { 
                i.ProdutoId, 
                i.Quantidade, 
                i.Subtotal 
            }));

        var itemsPedidos = Database.Pedidos.Select(p => p.Itens);

        Console.WriteLine($"({itemsPedidos.Count()} pedidos, total de {result.Count()} itens)");

        foreach (var item in result)
            Console.WriteLine($"Produto {item.ProdutoId} x{item.Quantidade} = R$ {item.Subtotal:F2}");
    }

    // 11. Join entre Produtos e Categorias (nome do produto + nome da categoria).
    private static void Desafio11() 
    {
        Console.WriteLine("\n[11] Produto -> Categoria:");
        // TODO: Join
        var result = Database.Produtos
            .Join(Database.Categorias, p => p.CategoriaId, c => c.Id, (p, c) => new { 
                NomeProduto = p.Nome, 
                NomeCategoria = c.Nome 
            });

        foreach (var item in result)
            Console.WriteLine($"{item.NomeProduto} -> {item.NomeCategoria}");
    }

    // 12. Pegue os 3 produtos mais caros, pulando o primeiro.
    private static void Desafio12()
    {
        Console.WriteLine("\n[12] Top 3 produtos mais caros (pulando o 1º):");
        // TODO: OrderByDescending + Skip(1) + Take(3)
        var result = Database.Produtos
            .OrderByDescending(p => p.Preco)
            .Skip(1)
            .Take(3);

        foreach (var item in result)
            Console.WriteLine($"{item.Nome} - R$ {item.Preco:F2}");
    }

    // 13. Ordene clientes por estado (asc) e depois por nome (asc).
    private static void Desafio13()
    {
        Console.WriteLine("\n[13] Clientes por estado + nome:");
        // TODO: OrderBy + ThenBy
        var result = Database.Clientes
            .OrderBy(c => c.Estado)
            .ThenBy(c => c.Nome);

        foreach (var item in result)
            Console.WriteLine($"{item.Nome} - {item.Cidade}/{item.Estado}");
    }

    // 14. Top 3 clientes com mais pedidos (Join + GroupBy).
    private static void Desafio14()
    {
        Console.WriteLine("\n[14] Top 3 clientes com mais pedidos:");
        // TODO: Join + GroupBy + OrderByDescending + Take(3)
        var result = Database.Pedidos
            .Join(Database.Clientes, p => p.ClienteId, c => c.Id, (p, c) => new { 
                Items = p.Itens, 
                Cliente = c 
            })
            .GroupBy(c => c.Cliente, (client, items) => new { 
                client.Nome, 
                Quantidade = items.Count() 
            })
            .OrderByDescending(_ => _.Quantidade)
            .Take(3);

        foreach (var item in result)
            Console.WriteLine($"{item.Nome}: {item.Quantidade} pedido(s)");
    }
}
