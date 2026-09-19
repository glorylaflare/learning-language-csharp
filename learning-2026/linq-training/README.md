# LINQ Training — C#

Projeto de treino de LINQ em C# (.NET 8) com 30 desafios divididos em 4 níveis.

## Como rodar

```bash
dotnet restore
dotnet run
```

## Estrutura

- `Models/` — entidades (Cliente, Produto, Pedido, etc)
- `Data/Database.cs` — dados mockados
- `Desafios/` — os 4 níveis com TODOs pra você implementar
- `Program.cs` — menu de execução

## 🎯 Níveis

| Nível | Foco | Métodos |
|-------|------|---------|
| 1 | Básico | Where, Select, OrderBy, First, Any, Count, Sum |
| 2 | Intermediário | GroupBy, Distinct, SelectMany, Join, Take, Skip, ThenBy |
| 3 | Avançado | GroupJoin, ToLookup, Aggregate, Zip, Except, Union, All |
| 4 | Especialista | Chunk, DistinctBy, MaxBy, TakeWhile, SkipWhile, relatórios |

## 💡 Dicas

- Resolva primeiro com method syntax, depois tente query syntax.
- Rode `dotnet run` e escolha o nível.
- Cada `DesafioXX` tem um `TODO` — implemente ali.