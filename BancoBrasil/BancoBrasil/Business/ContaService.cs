using BancoBrasil.Models;
using BancoBrasil.Views;

namespace BancoBrasil.Business;

public class ContaService
{
    public void MostrarExtrato(Conta conta)
    {
        foreach (var transacoe in conta.ListaTransacoes)
        {
            Console.WriteLine(transacoe);
        }
    }
    
    public void Depositar(Conta conta, decimal valor)
    {
        if (valor < 0) Console.WriteLine("Por favor, insira um valor válido.");
        
        conta.Saldo += valor;
        Console.WriteLine($"Saldo atual: {conta.Saldo}");
        conta.ListaTransacoes.Add($"Data: {DateTime.Now} | Tipo: Depósito | Valor: {valor:C}");
    }

    public void Sacar(Conta conta, decimal valor)
    {
        if (valor < 0)
        {
            Console.WriteLine("Por favor, insira um valor válido...");
            return;
        }

        var limiteDeSaque = conta.Saldo + conta.LimiteChequeEspecial;
        
        if (valor < limiteDeSaque)
        {
            conta.Saldo -= valor;
            Console.WriteLine($"Saldo atual: {conta.Saldo}");
            conta.ListaTransacoes.Add($"Data: {DateTime.Now} | Tipo: Saque | Valor: -{valor:C}");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente");
        }
    }

    public void Transferir(Conta conta, decimal valor, Conta? contaParaTransferencia)
    {
        if (contaParaTransferencia == null)
        {
            Console.WriteLine("A conta na qual você está tentando transferir dinheiro não é válida.");
            return;
        }
        
        if (!contaParaTransferencia.Ativa) Console.WriteLine("A conta na qual você está tentando transferir dinheiro, está inativa.");

        contaParaTransferencia.Saldo += valor;
        conta.Saldo -= valor;
        Console.WriteLine($"Saldo atual: {conta.Saldo}");
        conta.ListaTransacoes.Add($"Data: {DateTime.Now} | Tipo: Transferência | Valor: -{valor:C}");
        contaParaTransferencia.ListaTransacoes.Add($"Data: {DateTime.Now} | Tipo: Transferência | Valor: +{valor:C}");
    }
    
    public void VerificarLimiteChequeEspecial(Conta conta)
    {
        Console.WriteLine($"O seu cheque especial atual é de: {conta.LimiteChequeEspecial}");
    }

    public void EncerrarConta(Conta conta)
    {
        conta.Ativa = false;
        Console.WriteLine("A sua conta foi desativada. Obrigado!");
    }
}