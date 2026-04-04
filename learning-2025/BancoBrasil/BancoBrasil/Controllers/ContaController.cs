using BancoBrasil.Business;
using BancoBrasil.Data;
using BancoBrasil.Models;
using BancoBrasil.Views;

namespace BancoBrasil.Controllers;

public class ContaController
{
    private readonly ContaView _contaView;
    private readonly ContaRepositorio _contaRepositorio;
    private readonly ContaService _contaService;

    public ContaController()
    {
        _contaView = new ContaView();
        _contaService = new ContaService();
        _contaRepositorio = new ContaRepositorio();
    }
    
    public void Iniciar()
    {
        while (true)
        {
            var numeroConta = _contaView.SolicitarNumeroConta();
            var contaLogada = _contaRepositorio.BuscarPorNumeroConta(numeroConta);
            
            if (numeroConta == 0)
            {
                Console.WriteLine("Saindo...");
                break;
            }

            if (contaLogada == null)
            {
                Console.WriteLine("A conta na qual você está tentando acessar não é válida.");
                _contaView.PausarEVoltarParaOMenu();
            }
            else
            {
                MenuPrincipal(contaLogada);
            }
        }
    }

    private void MenuPrincipal(Conta conta)
    {
        var continua = true;
        while (continua)
        {
            if (!conta.Ativa)
            {
                Console.WriteLine($"A conta de número '{conta.NumeroConta}' na qual você está tentando acessar está inativa...");
                Console.WriteLine("Por favor, vá até a unidade mais próxima para mais informações.");
                Console.ReadKey();
                break;
            }
            
            var opcao = _contaView.ObterOpcaoMenu(conta.NomeDoTitular, conta.Saldo, conta.Ativa);
            
            switch (opcao)
            {
                case "1":
                    MostrarExtrato(conta);
                    break;
                case "2":
                    Depositar(conta);
                    break;
                case "3":
                    Sacar(conta);
                    break;
                case "4": 
                    Transferir(conta);
                    break;
                case "5":
                    VerificarLimiteChequeEspecial(conta);
                    break;
                case "6":
                    EncerrarConta(conta);
                    break;
                case "7":
                    Console.WriteLine("Saindo...");
                    continua = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida...Tente novamente.");
                    break;
            }    
        }
    }

    private void MostrarExtrato(Conta conta)
    {
        _contaService.MostrarExtrato(conta);
    }
    
    private void Depositar(Conta conta)
    {
        Console.WriteLine("Qual você você deseja depositar?");
        var valor = decimal.Parse(Console.ReadLine() ?? string.Empty);
        _contaService.Depositar(conta, valor);
        
        _contaView.PausarEVoltarParaOMenu();
    }
    
    private void Sacar(Conta conta)
    {
        Console.WriteLine("Qual você você deseja sacar?");
        var valor = decimal.Parse(Console.ReadLine() ?? string.Empty);
        _contaService.Sacar(conta, valor);
        
        _contaView.PausarEVoltarParaOMenu();
    }
    
    private void Transferir(Conta conta)
    {
        Console.WriteLine("Informe o número da conta para qual você deseja transferir dinheiro:");
        var numeroContaTransferencia = int.Parse(Console.ReadLine() ?? string.Empty);
        
        Console.WriteLine("Qual valor você deseja transferir?");
        var valor = decimal.Parse(Console.ReadLine() ?? string.Empty);
        _contaService.Transferir(conta, valor, _contaRepositorio.BuscarPorNumeroConta(numeroContaTransferencia));
        
        _contaView.PausarEVoltarParaOMenu();
    }

    private void VerificarLimiteChequeEspecial(Conta conta)
    {
        _contaService.VerificarLimiteChequeEspecial(conta);
        
        _contaView.PausarEVoltarParaOMenu();
    }
    
    private void EncerrarConta(Conta conta)
    {
        _contaService.EncerrarConta(conta);
        
        _contaView.FecharMenu();
    }
}