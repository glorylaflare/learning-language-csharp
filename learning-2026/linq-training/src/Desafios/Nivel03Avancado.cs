namespace Linq.Training.Con.App.Desafios;

/// <summary>
/// Nível 3 — Avançado
/// Métodos-alvo: GroupJoin, ToLookup, Aggregate, Zip, Except, Intersect, Union, All.
/// </summary>
public static class Nivel03Avancado
{
    public static void Executar()
    {
        Console.WriteLine("\n========== NÍVEL 3 — AVANÇADO ==========");

        Desafio15();
        Desafio16();
        Desafio17();
        Desafio18();
        Desafio19();
        Desafio20();
        Desafio21();
        Desafio22();
    }

    // 15. Todos os clientes e seus pedidos (GroupJoin), inclusive quem não tem pedido.
    private static void Desafio15()
    {
        Console.WriteLine("\n[15] Clientes + Pedidos (GroupJoin):");
        // TODO: GroupJoin
    }

    // 16. ToLookup de produtos por categoria.
    private static void Desafio16()
    {
        Console.WriteLine("\n[16] Lookup de produtos por categoria:");
        // TODO: ToLookup
    }

    // 17. Aggregate para montar "Ana, Bruno, Carla, ..." com os nomes dos clientes.
    private static void Desafio17()
    {
        Console.WriteLine("\n[17] Nomes concatenados (Aggregate):");
        // TODO: Aggregate
    }

    // 18. Zip entre clientes e pedidos -> "Cliente X fez o pedido Y".
    private static void Desafio18()
    {
        Console.WriteLine("\n[18] Zip clientes x pedidos:");
        // TODO: Zip
    }

    // 19. Produtos que nunca foram vendidos (Except).
    private static void Desafio19()
    {
        Console.WriteLine("\n[19] Produtos nunca vendidos:");
        // TODO: Except
    }

    // 20. Categorias que possuem pelo menos um produto em estoque.
    private static void Desafio20()
    {
        Console.WriteLine("\n[20] Categorias com estoque:");
        // TODO: Where produto em estoque -> Select CategoriaId -> Join/Distinct
    }

    // 21. Verifique com All se todos os clientes ativos foram cadastrados após 2019.
    private static void Desafio21()
    {
        Console.WriteLine("\n[21] Todos os ativos foram cadastrados após 2019?");
        // TODO: Where(Ativo).All(...)
    }

    // 22. Union de clientes de SP e RJ (sem repetição).
    private static void Desafio22()
    {
        Console.WriteLine("\n[22] Clientes de SP ∪ RJ:");
        // TODO: Union
    }
}
