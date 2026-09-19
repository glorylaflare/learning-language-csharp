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
    }

    // 9. Liste as cidades distintas (sem repetição).
    private static void Desafio09()
    {
        Console.WriteLine("\n[9] Cidades distintas:");
        // TODO: Select + Distinct
    }

    // 10. Liste todos os itens de todos os pedidos (SelectMany).
    private static void Desafio10()
    {
        Console.WriteLine("\n[10] Todos os itens de todos os pedidos:");
        // TODO: SelectMany
    }

    // 11. Join entre Produtos e Categorias (nome do produto + nome da categoria).
    private static void Desafio11()
    {
        Console.WriteLine("\n[11] Produto -> Categoria:");
        // TODO: Join
    }

    // 12. Pegue os 3 produtos mais caros, pulando o primeiro.
    private static void Desafio12()
    {
        Console.WriteLine("\n[12] Top 3 produtos mais caros (pulando o 1º):");
        // TODO: OrderByDescending + Skip(1) + Take(3)
    }

    // 13. Ordene clientes por estado (asc) e depois por nome (asc).
    private static void Desafio13()
    {
        Console.WriteLine("\n[13] Clientes por estado + nome:");
        // TODO: OrderBy + ThenBy
    }

    // 14. Top 3 clientes com mais pedidos (Join + GroupBy).
    private static void Desafio14()
    {
        Console.WriteLine("\n[14] Top 3 clientes com mais pedidos:");
        // TODO: Join + GroupBy + OrderByDescending + Take(3)
    }
}
