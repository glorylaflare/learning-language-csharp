using Linq.Training.Con.App.Data;
using System.Globalization;

namespace Linq.Training.Con.App.Desafios;

/// <summary>
/// Nível 1 — Básico
/// Métodos-alvo: Where, Select, OrderBy/OrderByDescending, First/FirstOrDefault,
/// Any, All, Count, Sum, Min, Max.
/// </summary>
public static class Nivel01Basico
{
    public static void Executar()
    {
        Console.WriteLine("\n========== NÍVEL 1 — BÁSICO ==========");

        Desafio01();
        Desafio02();
        Desafio03();
        Desafio04();
        Desafio05();
        Desafio06();
        Desafio07();
    }

    // 1. Liste todos os clientes ativos.
    private static void Desafio01()
    {
        Console.WriteLine("\n[1] Clientes ativos:");
        // TODO: use Where + ToList
        // var ativos = ...
        var result = Database.Clientes
            .Where(c => c.Ativo)
            .ToList();

        foreach (var item in result)
            Console.WriteLine(item);
    }

    // 2. Selecione apenas os nomes dos clientes.
    private static void Desafio02()
    {
        Console.WriteLine("\n[2] Nomes dos clientes:");
        // TODO: use Select
        var result = Database.Clientes
            .Select(c => c.Nome);

        foreach (var item in result)
            Console.WriteLine(item);
    }

    // 3. Liste produtos com preço acima de R$ 500, ordenados por preço (decrescente).
    private static void Desafio03()
    {
        Console.WriteLine("\n[3] Produtos > R$500 (desc):");
        // TODO: Where + OrderByDescending
        var result = Database.Produtos
            .Where(p => p.Preco > 500)
            .OrderByDescending(p => p.Preco);

        foreach (var item in result)
            Console.WriteLine(item);
    }

    // 4. Encontre o primeiro cliente de São Paulo.
    private static void Desafio04()
    {
        Console.WriteLine("\n[4] Primeiro cliente de SP:");
        // TODO: FirstOrDefault
        var result = Database.Clientes
            .FirstOrDefault(c => c.Estado == "SP");

        Console.WriteLine(result);
    }

    // 5. Verifique se existe algum produto sem estoque.
    private static void Desafio05()
    {
        Console.WriteLine("\n[5] Existe produto sem estoque?");
        // TODO: Any
        var result = Database.Produtos
            .Any(p => p.Estoque == 0);

        Console.WriteLine(result);
    }

    // 6. Conte quantos clientes são do estado de SP.
    private static void Desafio06()
    {
        Console.WriteLine("\n[6] Quantidade de clientes de SP:");
        // TODO: Count com predicado
        var result = Database.Clientes
            .Count(c => c.Estado == "SP");

        Console.WriteLine(result);
    }

    // 7. Some o valor total de todos os produtos em estoque (preço × es1toque).
    private static void Desafio07()
    {
        Console.WriteLine("\n[7] Valor total do estoque:");
        // TODO: Sum com seletor
        var result = Database.Produtos
            .Sum(p => (p.Preco * p.Estoque));

        Console.WriteLine(string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", result));
    }
}
