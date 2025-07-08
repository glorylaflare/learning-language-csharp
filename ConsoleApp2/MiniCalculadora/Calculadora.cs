namespace MiniCalculadora;

public class Calculadora
{
    public static void Executar()
    {
        Console.WriteLine("Calculadora Simples");
        Console.WriteLine("Digite o primeiro número:");
        double n1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o segundo número:");
        double n2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Qual operação você deseja realizar?");
        Console.WriteLine("1 - Somar");
        Console.WriteLine("2 - Subtrair");
        Console.WriteLine("3 - Multiplicar");
        Console.WriteLine("4 - Dividir");
        int operacao = Convert.ToInt32(Console.ReadLine());
        
        double resultado;
        switch (operacao)
        {
            case 1:
                resultado = Somar(n1, n2);
                Console.WriteLine($"Resultado: {n1} + {n2} = {resultado}");
                break;
            case 2:
                resultado = Subtrair(n1, n2);
                Console.WriteLine($"Resultado: {n1} - {n2} = {resultado}");
                break;
            case 3:
                resultado = Multiplicar(n1, n2);
                Console.WriteLine($"Resultado: {n1} * {n2} = {resultado}");
                break;
            case 4:
                try
                {
                    resultado = Dividir(n1, n2);
                    Console.WriteLine($"Resultado: {n1} / {n2} = {resultado}");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                break;
            default:
                Console.WriteLine("Operação inválida.");
                break;
        }
    }

    private static double Somar(double n1, double n2)
    {
        return n1 + n2;
    }
    
    private static double Subtrair(double n1, double n2)
    {
        return n1 - n2;
    }
    
    private static double Multiplicar(double n1, double n2)
    {
        return n1 * n2;
    }
    
    private static double Dividir(double n1, double n2)
    {
        if (n2 == 0)
        {
            throw new DivideByZeroException("Divisão por zero não é permitida.");
        }
        return n1 / n2;
    }
}