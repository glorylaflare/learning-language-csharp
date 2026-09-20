namespace Linq.Training.Con.App.Desafios;

/// <summary>
/// Nível 4 — Especialista
/// Métodos-alvo: Chunk, DistinctBy, MaxBy/MinBy, TakeWhile, SkipWhile,
/// relatórios compostos (GroupBy + Join + Aggregate).
/// </summary>
public static class Nivel04Especialista
{
    public static void Executar()
    {
        Console.WriteLine("\n========== NÍVEL 4 — ESPECIALISTA ==========");

        Desafio23();
        Desafio24();
        Desafio25();
        Desafio26();
        Desafio27();
        Desafio28();
        Desafio29();
        Desafio30();
    }

    // 23. Divida a lista de produtos em grupos de 3 (Chunk).
    private static void Desafio23()
    {
        Console.WriteLine("\n[23] Produtos em chunks de 3:");
        // TODO: Chunk(3)
    }

    // 24. Liste um produto por categoria (DistinctBy).
    private static void Desafio24()
    {
        Console.WriteLine("\n[24] Um produto por categoria:");
        // TODO: DistinctBy(p => p.CategoriaId)
    }

    // 25. Cliente mais recente com MaxBy.
    private static void Desafio25()
    {
        Console.WriteLine("\n[25] Cliente mais recente:");
        // TODO: MaxBy(c => c.DataCadastro)
    }

    // 26. Pegue produtos enquanto o preço for < 500 (lista ordenada por preço).
    private static void Desafio26()
    {
        Console.WriteLine("\n[26] Produtos enquanto preço < 500:");
        // TODO: OrderBy(Preco).TakeWhile(p => p.Preco < 500)
    }

    // 27. Pule clientes até encontrar um do RJ.
    private static void Desafio27()
    {
        Console.WriteLine("\n[27] Pular até achar cliente do RJ:");
        // TODO: SkipWhile(c => c.Estado != "RJ")
    }

    // 28. Relatório: Nome | QtdPedidos | TotalGasto (0 se não tiver pedido).
    private static void Desafio28()
    {
        Console.WriteLine("\n[28] Relatório por cliente:");
        // TODO: GroupJoin + Select
    }

    // 29. Ranking de produtos mais vendidos (por quantidade total).
    private static void Desafio29()
    {
        Console.WriteLine("\n[29] Ranking produtos mais vendidos:");
        // TODO: SelectMany(itens) + GroupBy(ProdutoId) + Sum(Quantidade) + Join com Produtos
    }

    // 30. Categoria que mais faturou (soma Subtotal dos itens).
    private static void Desafio30()
    {
        Console.WriteLine("\n[30] Categoria que mais faturou:");
        // TODO: Itens -> Produto -> Categoria -> GroupBy -> Sum
    }
}
