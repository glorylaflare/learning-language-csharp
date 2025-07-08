namespace BancoBrasil.Models;

public class Conta
{
    public int NumeroConta { get; set; }
    public string NomeDoTitular { get; set; }
    public decimal Saldo { get; set; }
    public TipoContaEnum TipoConta { get; set; }
    public string Agencia { get; set; }
    public decimal LimiteChequeEspecial { get; set; }
    public bool Ativa { get; set; }
    public readonly List<string> ListaTransacoes = [];

    public Conta(int numeroConta, string nomeDoTitular, decimal saldo, TipoContaEnum tipoConta, string agencia, decimal limiteChequeEspecial, bool ativa)
    {
        NumeroConta = numeroConta;
        NomeDoTitular = nomeDoTitular;
        Saldo = saldo;
        TipoConta = tipoConta;
        Agencia = agencia;
        LimiteChequeEspecial = limiteChequeEspecial;
        Ativa = ativa;
    }
}