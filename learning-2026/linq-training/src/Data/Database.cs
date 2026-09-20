using Linq.Training.Con.App.Models;

namespace Linq.Training.Con.App.Data;

public static class Database
{
    public static List<Cliente> Clientes { get; } = new()
    {
        new() { Id=1, Nome="Ana Silva",     Cidade="São Paulo",      Estado="SP", DataCadastro=new(2022,1,10), Ativo=true  },
        new() { Id=2, Nome="Bruno Souza",   Cidade="Rio de Janeiro", Estado="RJ", DataCadastro=new(2021,5,22), Ativo=true  },
        new() { Id=3, Nome="Carla Dias",    Cidade="Belo Horizonte", Estado="MG", DataCadastro=new(2023,3,15), Ativo=false },
        new() { Id=4, Nome="Daniel Rocha",  Cidade="Curitiba",       Estado="PR", DataCadastro=new(2020,8,30), Ativo=true  },
        new() { Id=5, Nome="Eduarda Lima",  Cidade="São Paulo",      Estado="SP", DataCadastro=new(2023,7,1),  Ativo=true  },
        new() { Id=6, Nome="Felipe Nunes",  Cidade="Salvador",       Estado="BA", DataCadastro=new(2019,2,11), Ativo=false },
        new() { Id=7, Nome="Gabriela Reis", Cidade="Porto Alegre",   Estado="RS", DataCadastro=new(2024,2,20), Ativo=true  },
        new() { Id=8, Nome="Henrique Melo", Cidade="Recife",         Estado="PE", DataCadastro=new(2022,11,5), Ativo=true  },
    };

    public static List<Categoria> Categorias { get; } = new()
    {
        new() { Id=1, Nome="Eletrônicos" },
        new() { Id=2, Nome="Livros" },
        new() { Id=3, Nome="Roupas" },
        new() { Id=4, Nome="Games" },
        new() { Id=5, Nome="Casa" },
    };

    public static List<Produto> Produtos { get; } = new()
    {
        new() { Id=1,  Nome="Notebook",        Preco=4500m, Estoque=10,  CategoriaId=1 },
        new() { Id=2,  Nome="Smartphone",      Preco=2500m, Estoque=25,  CategoriaId=1 },
        new() { Id=3,  Nome="Clean Code",      Preco=90m,   Estoque=50,  CategoriaId=2 },
        new() { Id=4,  Nome="C# in Depth",     Preco=120m,  Estoque=30,  CategoriaId=2 },
        new() { Id=5,  Nome="Camiseta",        Preco=60m,   Estoque=100, CategoriaId=3 },
        new() { Id=6,  Nome="PlayStation 5",   Preco=4000m, Estoque=5,   CategoriaId=4 },
        new() { Id=7,  Nome="Controle Dual",   Preco=450m,  Estoque=0,   CategoriaId=4 },
        new() { Id=8,  Nome="Fone Bluetooth",  Preco=300m,  Estoque=15,  CategoriaId=1 },
        new() { Id=9,  Nome="Luminária",       Preco=150m,  Estoque=40,  CategoriaId=5 },
        new() { Id=10, Nome="Jogo Elden Ring", Preco=250m,  Estoque=20,  CategoriaId=4 },
    };

    public static List<Pedido> Pedidos { get; } = new()
    {
        new() { Id=1, ClienteId=1, Data=new(2024,1,15), Itens=new()
        {
            new() { ProdutoId=1, Quantidade=1, PrecoUnitario=4500m },
            new() { ProdutoId=3, Quantidade=2, PrecoUnitario=90m   },
        }},
        new() { Id=2, ClienteId=2, Data=new(2024,2,3), Itens=new()
        {
            new() { ProdutoId=2, Quantidade=1, PrecoUnitario=2500m },
        }},
        new() { Id=3, ClienteId=1, Data=new(2024,3,20), Itens=new()
        {
            new() { ProdutoId=6, Quantidade=1, PrecoUnitario=4000m },
            new() { ProdutoId=7, Quantidade=2, PrecoUnitario=450m  },
        }},
        new() { Id=4, ClienteId=4, Data=new(2024,4,5), Itens=new()
        {
            new() { ProdutoId=5, Quantidade=3, PrecoUnitario=60m },
        }},
        new() { Id=5, ClienteId=5, Data=new(2024,5,12), Itens=new()
        {
            new() { ProdutoId=8, Quantidade=1, PrecoUnitario=300m },
            new() { ProdutoId=3, Quantidade=1, PrecoUnitario=90m  },
        }},
        new() { Id=6, ClienteId=7, Data=new(2024,6,1), Itens=new()
        {
            new() { ProdutoId=10, Quantidade=1, PrecoUnitario=250m },
            new() { ProdutoId=9,  Quantidade=2, PrecoUnitario=150m },
        }},
        new() { Id=7, ClienteId=2, Data=new(2024,6,18), Itens=new()
        {
            new() { ProdutoId=6, Quantidade=1, PrecoUnitario=4000m },
        }},
        new() { Id=8, ClienteId=8, Data=new(2024,7,2), Itens=new()
        {
            new() { ProdutoId=4, Quantidade=1, PrecoUnitario=120m },
            new() { ProdutoId=5, Quantidade=2, PrecoUnitario=60m  },
        }},
    };
}
