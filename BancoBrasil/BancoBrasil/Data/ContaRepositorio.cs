using BancoBrasil.Models;

namespace BancoBrasil.Data;

public class ContaRepositorio
{
    private readonly List<Conta?> _contas = [];

    public ContaRepositorio()
    {
        if (_contas.Count != 0) return;
        
        //Adiciona contas de exemplo à lista para simular dados iniciais
        _contas.Add(new Conta(100, "João Silva", 1000.00m, TipoContaEnum.CORRENTE, "1234-5", 1500.00m,true));
        _contas.Add(new Conta(101, "Maria Souza", 2500.50m, TipoContaEnum.CORRENTE, "2345-6", 1000.00m,true));
        _contas.Add(new Conta(102, "Carlos Lima", 500.00m, TipoContaEnum.POUPANCA, "3456-7", 500.00m,true));
        _contas.Add(new Conta(103, "Ana Paula", 3200.75m, TipoContaEnum.CORRENTE, "4567-8", 3000.00m,true));
    }
    
    public Conta? BuscarPorNumeroConta(int numeroConta)
    {
        //Estamos iterando DENTRO da List<Conta> a partir do objeto "_contas"
        return _contas.FirstOrDefault((c => c.NumeroConta == numeroConta));
    }
}